namespace Klijent
{
    partial class FrmUbaciLek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUbaciLek));
            buttonKreiraj = new Button();
            textBoxNaziv = new TextBox();
            textBoxProizvodjac = new TextBox();
            textBoxSerija = new TextBox();
            textBoxCena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonKreiraj
            // 
            buttonKreiraj.BackColor = Color.Crimson;
            buttonKreiraj.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKreiraj.ForeColor = SystemColors.ButtonHighlight;
            buttonKreiraj.Location = new Point(606, 369);
            buttonKreiraj.Name = "buttonKreiraj";
            buttonKreiraj.Size = new Size(164, 59);
            buttonKreiraj.TabIndex = 0;
            buttonKreiraj.Text = "Sacuvaj";
            buttonKreiraj.UseVisualStyleBackColor = false;
            buttonKreiraj.Click += button1_Click;
            // 
            // textBoxNaziv
            // 
            textBoxNaziv.Location = new Point(372, 69);
            textBoxNaziv.Name = "textBoxNaziv";
            textBoxNaziv.Size = new Size(398, 23);
            textBoxNaziv.TabIndex = 1;
            // 
            // textBoxProizvodjac
            // 
            textBoxProizvodjac.Location = new Point(372, 191);
            textBoxProizvodjac.Name = "textBoxProizvodjac";
            textBoxProizvodjac.Size = new Size(398, 23);
            textBoxProizvodjac.TabIndex = 2;
            // 
            // textBoxSerija
            // 
            textBoxSerija.Location = new Point(372, 250);
            textBoxSerija.Name = "textBoxSerija";
            textBoxSerija.Size = new Size(398, 23);
            textBoxSerija.TabIndex = 3;
            // 
            // textBoxCena
            // 
            textBoxCena.Location = new Point(372, 312);
            textBoxCena.Name = "textBoxCena";
            textBoxCena.Size = new Size(398, 23);
            textBoxCena.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(372, 49);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 6;
            label1.Text = "Naziv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(372, 230);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 7;
            label2.Text = "Serija proizvodnje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(372, 292);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 8;
            label3.Text = "Cena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(372, 171);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 9;
            label4.Text = "Proizvodjac";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(372, 109);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 10;
            label5.Text = "Kategorija";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(372, 129);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(398, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 420);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FrmUbaciLek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(813, 452);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCena);
            Controls.Add(textBoxSerija);
            Controls.Add(textBoxProizvodjac);
            Controls.Add(textBoxNaziv);
            Controls.Add(buttonKreiraj);
            Name = "FrmUbaciLek";
            Text = "Ubaci Lek";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button buttonKreiraj;
        public TextBox textBoxNaziv;
        public TextBox textBoxProizvodjac;
        public TextBox textBoxSerija;
        public TextBox textBoxCena;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public ComboBox comboBox1;
        private PictureBox pictureBox1;
    }
}