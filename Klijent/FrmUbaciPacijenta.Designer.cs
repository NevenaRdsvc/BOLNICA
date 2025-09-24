namespace Klijent
{
    partial class FrmUbaciPacijenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUbaciPacijenta));
            textBoxIme = new TextBox();
            pictureBox2 = new PictureBox();
            textBoxJMBG = new TextBox();
            textBoxAdresa = new TextBox();
            textBoxPol = new TextBox();
            textBoxPrezime = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonSacuvaj = new Button();
            comboBoxMesto = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBoxIme
            // 
            textBoxIme.BackColor = Color.Azure;
            textBoxIme.Location = new Point(432, 110);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(393, 23);
            textBoxIme.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(381, 370);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // textBoxJMBG
            // 
            textBoxJMBG.Location = new Point(432, 287);
            textBoxJMBG.Name = "textBoxJMBG";
            textBoxJMBG.Size = new Size(393, 23);
            textBoxJMBG.TabIndex = 3;
            // 
            // textBoxAdresa
            // 
            textBoxAdresa.Location = new Point(432, 347);
            textBoxAdresa.Name = "textBoxAdresa";
            textBoxAdresa.Size = new Size(393, 23);
            textBoxAdresa.TabIndex = 4;
            // 
            // textBoxPol
            // 
            textBoxPol.Location = new Point(432, 222);
            textBoxPol.Name = "textBoxPol";
            textBoxPol.Size = new Size(393, 23);
            textBoxPol.TabIndex = 6;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(432, 168);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(393, 23);
            textBoxPrezime.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(432, 46);
            label2.Name = "label2";
            label2.Size = new Size(219, 18);
            label2.TabIndex = 15;
            label2.Text = "Unesite podatke za korisnika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.Location = new Point(432, 83);
            label3.Name = "label3";
            label3.Size = new Size(30, 17);
            label3.TabIndex = 16;
            label3.Text = "Ime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F);
            label4.Location = new Point(432, 145);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 17;
            label4.Text = "Prezime";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.Location = new Point(432, 264);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 18;
            label5.Text = "JMBG";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F);
            label6.Location = new Point(432, 199);
            label6.Name = "label6";
            label6.Size = new Size(26, 17);
            label6.TabIndex = 19;
            label6.Text = "Pol";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F);
            label7.Location = new Point(432, 329);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 20;
            label7.Text = "Adresa";
            // 
            // buttonSacuvaj
            // 
            buttonSacuvaj.BackColor = Color.Crimson;
            buttonSacuvaj.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSacuvaj.ForeColor = SystemColors.ButtonHighlight;
            buttonSacuvaj.Location = new Point(658, 456);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new Size(167, 61);
            buttonSacuvaj.TabIndex = 34;
            buttonSacuvaj.Text = "Sacuvaj";
            buttonSacuvaj.UseVisualStyleBackColor = false;
            buttonSacuvaj.Click += buttonUbaciKorisnika_Click_1;
            // 
            // comboBoxMesto
            // 
            comboBoxMesto.FormattingEnabled = true;
            comboBoxMesto.Location = new Point(432, 405);
            comboBoxMesto.Name = "comboBoxMesto";
            comboBoxMesto.Size = new Size(393, 23);
            comboBoxMesto.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F);
            label1.Location = new Point(432, 384);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 36;
            label1.Text = "Mesto";
            // 
            // FrmUbaciPacijenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(872, 542);
            Controls.Add(label1);
            Controls.Add(comboBoxMesto);
            Controls.Add(buttonSacuvaj);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPol);
            Controls.Add(textBoxPrezime);
            Controls.Add(textBoxAdresa);
            Controls.Add(textBoxJMBG);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxIme);
            Name = "FrmUbaciPacijenta";
            Text = "Ubaci Pacijent";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxIme;
        public PictureBox pictureBox2;
        public TextBox textBoxJMBG;
        public TextBox textBoxAdresa;
        public TextBox textBoxPol;
        public TextBox textBoxPrezime;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label label7;
        public Button buttonSacuvaj;
        public ComboBox comboBoxMesto;
        public Label label1;
    }
}