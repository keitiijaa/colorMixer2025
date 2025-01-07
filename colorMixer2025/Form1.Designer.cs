namespace colorMixer2025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDownRed = new NumericUpDown();
            pictureBoxRed = new PictureBox();
            pictureBoxGreen = new PictureBox();
            numericUpDownGreen = new NumericUpDown();
            pictureBoxBlue = new PictureBox();
            numericUpDownBlue = new NumericUpDown();
            trackBarRed = new TrackBar();
            trackBarBlue = new TrackBar();
            trackBarGreen = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownRed
            // 
            numericUpDownRed.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownRed.Location = new Point(49, 33);
            numericUpDownRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownRed.Name = "numericUpDownRed";
            numericUpDownRed.Size = new Size(170, 50);
            numericUpDownRed.TabIndex = 0;
            numericUpDownRed.ValueChanged += numericUpDownRed_ValueChanged;
            // 
            // pictureBoxRed
            // 
            pictureBoxRed.Location = new Point(49, 102);
            pictureBoxRed.Name = "pictureBoxRed";
            pictureBoxRed.Size = new Size(170, 170);
            pictureBoxRed.TabIndex = 1;
            pictureBoxRed.TabStop = false;
            // 
            // pictureBoxGreen
            // 
            pictureBoxGreen.Location = new Point(320, 102);
            pictureBoxGreen.Name = "pictureBoxGreen";
            pictureBoxGreen.Size = new Size(170, 170);
            pictureBoxGreen.TabIndex = 3;
            pictureBoxGreen.TabStop = false;
            // 
            // numericUpDownGreen
            // 
            numericUpDownGreen.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownGreen.Location = new Point(320, 33);
            numericUpDownGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownGreen.Name = "numericUpDownGreen";
            numericUpDownGreen.Size = new Size(170, 50);
            numericUpDownGreen.TabIndex = 2;
            numericUpDownGreen.ValueChanged += numericUpDownGreen_ValueChanged;
            // 
            // pictureBoxBlue
            // 
            pictureBoxBlue.Location = new Point(582, 102);
            pictureBoxBlue.Name = "pictureBoxBlue";
            pictureBoxBlue.Size = new Size(170, 170);
            pictureBoxBlue.TabIndex = 5;
            pictureBoxBlue.TabStop = false;
            // 
            // numericUpDownBlue
            // 
            numericUpDownBlue.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownBlue.Location = new Point(582, 33);
            numericUpDownBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownBlue.Name = "numericUpDownBlue";
            numericUpDownBlue.Size = new Size(170, 50);
            numericUpDownBlue.TabIndex = 4;
            numericUpDownBlue.ValueChanged += numericUpDownBlue_ValueChanged;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(49, 298);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(170, 45);
            trackBarRed.TabIndex = 6;
            trackBarRed.TickStyle = TickStyle.None;
            trackBarRed.Scroll += trackBarRed_Scroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(582, 298);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(170, 45);
            trackBarBlue.TabIndex = 7;
            trackBarBlue.TickStyle = TickStyle.None;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(320, 298);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(170, 45);
            trackBarGreen.TabIndex = 8;
            trackBarGreen.TickStyle = TickStyle.None;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarRed);
            Controls.Add(pictureBoxBlue);
            Controls.Add(numericUpDownBlue);
            Controls.Add(pictureBoxGreen);
            Controls.Add(numericUpDownGreen);
            Controls.Add(pictureBoxRed);
            Controls.Add(numericUpDownRed);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownRed;
        private PictureBox pictureBoxRed;
        private PictureBox pictureBoxGreen;
        private NumericUpDown numericUpDownGreen;
        private PictureBox pictureBoxBlue;
        private NumericUpDown numericUpDownBlue;
        private TrackBar trackBarRed;
        private TrackBar trackBarBlue;
        private TrackBar trackBarGreen;
    }
}