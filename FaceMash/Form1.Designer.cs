namespace FaceMash
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
            picLeft = new PictureBox();
            btnLeft = new Button();
            picRight = new PictureBox();
            btnRight = new Button();
            btnStart = new Button();
            lblInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)picLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRight).BeginInit();
            SuspendLayout();
            // 
            // picLeft
            // 
            picLeft.BackgroundImageLayout = ImageLayout.None;
            picLeft.Location = new Point(12, 12);
            picLeft.Name = "picLeft";
            picLeft.Size = new Size(552, 446);
            picLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            picLeft.TabIndex = 0;
            picLeft.TabStop = false;
            picLeft.Click += picLeft_Click;
            // 
            // btnLeft
            // 
            btnLeft.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeft.Location = new Point(177, 464);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(223, 176);
            btnLeft.TabIndex = 1;
            btnLeft.Text = "Samba on teh Left?";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // picRight
            // 
            picRight.BackgroundImageLayout = ImageLayout.None;
            picRight.Location = new Point(633, 12);
            picRight.Name = "picRight";
            picRight.Size = new Size(552, 446);
            picRight.SizeMode = PictureBoxSizeMode.StretchImage;
            picRight.TabIndex = 2;
            picRight.TabStop = false;
            picRight.Click += picRight_Click;
            // 
            // btnRight
            // 
            btnRight.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRight.Location = new Point(787, 464);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(223, 176);
            btnRight.TabIndex = 3;
            btnRight.Text = "Samba on teh right?";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(570, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(57, 446);
            btnStart.TabIndex = 4;
            btnStart.Text = "Re/START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.Location = new Point(432, 530);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 30);
            lblInfo.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 657);
            Controls.Add(lblInfo);
            Controls.Add(btnStart);
            Controls.Add(btnRight);
            Controls.Add(picRight);
            Controls.Add(btnLeft);
            Controls.Add(picLeft);
            Name = "Form1";
            Text = "Samba or Not?";
            ((System.ComponentModel.ISupportInitialize)picLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLeft;
        private Button btnLeft;
        private PictureBox picRight;
        private Button btnRight;
        private Button btnStart;
        private Label lblInfo;
    }
}