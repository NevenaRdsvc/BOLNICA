namespace Klijent
{
    partial class FrmUbaciBolnicu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUbaciBolnicu));
            pictureBox1 = new PictureBox();
            textBoxNaziv = new TextBox();
            textBoxAdresa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonSacuvaj = new Button();
            label3 = new Label();
            textBoxBrojZaposlenih = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxNaziv
            // 
            textBoxNaziv.Font = new Font("Century Gothic", 9.75F);
            textBoxNaziv.Location = new Point(382, 79);
            textBoxNaziv.Name = "textBoxNaziv";
            textBoxNaziv.Size = new Size(354, 23);
            textBoxNaziv.TabIndex = 1;
            // 
            // textBoxAdresa
            // 
            textBoxAdresa.Font = new Font("Century Gothic", 9.75F);
            textBoxAdresa.Location = new Point(382, 134);
            textBoxAdresa.Name = "textBoxAdresa";
            textBoxAdresa.Size = new Size(354, 23);
            textBoxAdresa.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F);
            label1.Location = new Point(382, 61);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 4;
            label1.Text = "Naziv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F);
            label2.Location = new Point(382, 116);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 5;
            label2.Text = "Adresa";
            // 
            // buttonSacuvaj
            // 
            buttonSacuvaj.BackColor = Color.Crimson;
            buttonSacuvaj.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSacuvaj.ForeColor = SystemColors.ButtonHighlight;
            buttonSacuvaj.Location = new Point(606, 260);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new Size(130, 61);
            buttonSacuvaj.TabIndex = 7;
            buttonSacuvaj.Text = "Sacuvaj";
            buttonSacuvaj.UseVisualStyleBackColor = false;
            buttonSacuvaj.Click += buttonUbaci_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F);
            label3.Location = new Point(382, 178);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 9;
            label3.Text = "Broj Zaposlenih";
            // 
            // textBoxBrojZaposlenih
            // 
            textBoxBrojZaposlenih.Enabled = false;
            textBoxBrojZaposlenih.Font = new Font("Century Gothic", 9.75F);
            textBoxBrojZaposlenih.Location = new Point(382, 196);
            textBoxBrojZaposlenih.Name = "textBoxBrojZaposlenih";
            textBoxBrojZaposlenih.Size = new Size(354, 23);
            textBoxBrojZaposlenih.TabIndex = 8;
            // 
            // FrmUbaciBolnicu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(764, 389);
            Controls.Add(label3);
            Controls.Add(textBoxBrojZaposlenih);
            Controls.Add(buttonSacuvaj);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAdresa);
            Controls.Add(textBoxNaziv);
            Controls.Add(pictureBox1);
            Name = "FrmUbaciBolnicu";
            Text = "Ubaci Bolnicu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public TextBox textBoxNaziv;
        public TextBox textBoxAdresa;
        private Label label1;
        private Label label2;
        public Button buttonSacuvaj;
        private Label label3;
        public TextBox textBoxBrojZaposlenih;
    }
}