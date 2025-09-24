namespace Klijent
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            buttonLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Crimson;
            buttonLogin.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ControlLightLight;
            buttonLogin.Location = new Point(493, 290);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(172, 49);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Prijavi se";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F);
            label1.Location = new Point(412, 122);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 3;
            label1.Text = "Korisnicko ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F);
            label2.Location = new Point(412, 197);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 4;
            label2.Text = "Sifra";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, -23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 516);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(411, 153);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(323, 23);
            textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(410, 233);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(324, 23);
            textBoxPassword.TabIndex = 7;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(766, 430);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Name = "FrmLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button buttonLogin;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        public TextBox textBoxUsername;
        public TextBox textBoxPassword;
    }
}
