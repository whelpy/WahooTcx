namespace WahooTcx
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileOpenButton = new System.Windows.Forms.Button();
            this.distanceUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.distanceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FileOpenButton
            // 
            this.FileOpenButton.Location = new System.Drawing.Point(12, 69);
            this.FileOpenButton.Name = "FileOpenButton";
            this.FileOpenButton.Size = new System.Drawing.Size(173, 24);
            this.FileOpenButton.TabIndex = 0;
            this.FileOpenButton.Text = "Patch TCX file";
            this.FileOpenButton.UseVisualStyleBackColor = true;
            this.FileOpenButton.Click += new System.EventHandler(this.FileOpenButton_Click);
            // 
            // distanceUpDown
            // 
            this.distanceUpDown.Location = new System.Drawing.Point(84, 31);
            this.distanceUpDown.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.distanceUpDown.Name = "distanceUpDown";
            this.distanceUpDown.Size = new System.Drawing.Size(101, 20);
            this.distanceUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Distance (m)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distanceUpDown);
            this.Controls.Add(this.FileOpenButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(209, 141);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(209, 141);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Wahoo TCX";
            ((System.ComponentModel.ISupportInitialize)(this.distanceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileOpenButton;
        private System.Windows.Forms.NumericUpDown distanceUpDown;
        private System.Windows.Forms.Label label1;
    }
}

