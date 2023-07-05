namespace PictureGrid
{
    partial class secretlyAGridBox
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
            gridPictureBox = new PictureBox();
            lbl_ClickValue = new Label();
            lbl_clickValueDisplayer = new Label();
            lbl_X = new Label();
            lbl_Y = new Label();
            ((System.ComponentModel.ISupportInitialize)gridPictureBox).BeginInit();
            SuspendLayout();
            // 
            // gridPictureBox
            // 
            gridPictureBox.Image = Properties.Resources.isThisWhatYouHadInMind;
            gridPictureBox.Location = new Point(75, 50);
            gridPictureBox.Name = "gridPictureBox";
            gridPictureBox.Size = new Size(200, 200);
            gridPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gridPictureBox.TabIndex = 0;
            gridPictureBox.TabStop = false;
            gridPictureBox.Click += gridPictureBox_Click;
            gridPictureBox.MouseMove += gridPictureBox_MouseMove;
            // 
            // lbl_ClickValue
            // 
            lbl_ClickValue.AutoSize = true;
            lbl_ClickValue.Location = new Point(281, 50);
            lbl_ClickValue.Name = "lbl_ClickValue";
            lbl_ClickValue.Size = new Size(95, 25);
            lbl_ClickValue.TabIndex = 1;
            lbl_ClickValue.Text = "Click Value";
            // 
            // lbl_clickValueDisplayer
            // 
            lbl_clickValueDisplayer.AutoSize = true;
            lbl_clickValueDisplayer.Location = new Point(301, 75);
            lbl_clickValueDisplayer.Name = "lbl_clickValueDisplayer";
            lbl_clickValueDisplayer.Size = new Size(45, 25);
            lbl_clickValueDisplayer.TabIndex = 2;
            lbl_clickValueDisplayer.Text = "click";
            // 
            // lbl_X
            // 
            lbl_X.AutoSize = true;
            lbl_X.Location = new Point(100, 300);
            lbl_X.Name = "lbl_X";
            lbl_X.Size = new Size(27, 25);
            lbl_X.TabIndex = 3;
            lbl_X.Text = "X:";
            // 
            // lbl_Y
            // 
            lbl_Y.AutoSize = true;
            lbl_Y.Location = new Point(200, 300);
            lbl_Y.Name = "lbl_Y";
            lbl_Y.Size = new Size(26, 25);
            lbl_Y.TabIndex = 4;
            lbl_Y.Text = "Y:";
            // 
            // secretlyAGridBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 444);
            Controls.Add(lbl_Y);
            Controls.Add(lbl_X);
            Controls.Add(lbl_clickValueDisplayer);
            Controls.Add(lbl_ClickValue);
            Controls.Add(gridPictureBox);
            Name = "secretlyAGridBox";
            Text = "secretlyAGridBox";
            ((System.ComponentModel.ISupportInitialize)gridPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox gridPictureBox;
        private Label lbl_ClickValue;
        private Label lbl_clickValueDisplayer;
        private Label lbl_X;
        private Label lbl_Y;
    }
}