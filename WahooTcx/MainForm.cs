using System;
using System.Windows.Forms;
using System.Xml;

namespace WahooTcx
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FileOpenButton_Click(object sender, EventArgs e)
        {
            var distanceValue = distanceUpDown.Value;

            var dialog = new OpenFileDialog { Filter = "TCX (*.tcx)|*.tcx" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var doc = new XmlDocument();
                doc.Load(dialog.FileName);

                foreach (XmlNode tcd in doc.ChildNodes)
                {
                    if (tcd.Name != "TrainingCenterDatabase")
                        continue;

                    foreach (XmlNode activities in tcd.ChildNodes)
                    {
                        if (activities.Name != "Activities")
                            continue;

                        foreach (XmlNode activity in activities.ChildNodes)
                        {
                            if (activity.Name != "Activity")
                                continue;

                            foreach (XmlNode lap in activity.ChildNodes)
                            {
                                if (lap.Name != "Lap")
                                    continue;

                                foreach (XmlNode distance in lap.ChildNodes)
                                {
                                    if (distance.Name != "DistanceMeters")
                                        continue;

                                    var element = distance.FirstChild;
                                    element.Value = distanceValue.ToString("F");
                                }

                                foreach (XmlNode track in lap.ChildNodes)
                                {
                                    if (track.Name != "Track")
                                        continue;

                                    var pointsCount = track.ChildNodes.Count;
                                    var curDistance = 0m;
                                    var chunk = distanceValue/(pointsCount - 1);

                                    foreach (XmlNode trackpoints in track.ChildNodes)
                                    {
                                        bool hasDistance = false;
                                        foreach (XmlNode distanceNode in trackpoints.ChildNodes)
                                        {
                                            if (distanceNode.Name != "DistanceMeters")
                                                continue;

                                            var element = distanceNode.FirstChild;
                                            element.Value = curDistance.ToString("F");
                                            curDistance += chunk;

                                            hasDistance = true;
                                        }

                                        if (hasDistance)
                                            continue;

                                        var node = doc.CreateNode(XmlNodeType.Element, "DistanceMeters", null);
                                        node.InnerText = curDistance.ToString("F");
                                        trackpoints.AppendChild(node);

                                        curDistance += chunk;
                                    }
                                }

                                // only single Lap files are supported for now
                                break;
                            }
                        }
                    }
                }

                doc.Save(dialog.FileName);
                MessageBox.Show("Done");
            }
        }
    }
}
