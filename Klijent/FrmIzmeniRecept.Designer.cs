namespace Klijent
{
    partial class FrmIzmeniRecept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIzmeniRecept));
            buttonSacuvaj = new Button();
            dataGridViewStavke = new DataGridView();
            dateTimePickerDatumIsteka = new DateTimePicker();
            dateTimePickerDatumIzdavanja = new DateTimePicker();
            label11 = new Label();
            comboBoxPacijent = new ComboBox();
            panel1 = new Panel();
            comboBoxDoza = new ComboBox();
            buttonIzbrisiStavku = new Button();
            textBoxUputstvo = new TextBox();
            buttonDodajStavku = new Button();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            comboBoxLek = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBoxNapomena = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBoxVremeTrajanja = new TextBox();
            label7 = new Label();
            comboBoxLekar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStavke).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSacuvaj
            // 
            buttonSacuvaj.BackColor = Color.Crimson;
            buttonSacuvaj.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSacuvaj.ForeColor = SystemColors.ButtonHighlight;
            buttonSacuvaj.Location = new Point(632, 634);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new Size(156, 56);
            buttonSacuvaj.TabIndex = 60;
            buttonSacuvaj.Text = "Sacuvaj";
            buttonSacuvaj.UseVisualStyleBackColor = false;
            buttonSacuvaj.Click += buttonIzmeniRecept_Click;
            // 
            // dataGridViewStavke
            // 
            dataGridViewStavke.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStavke.Location = new Point(394, 35);
            dataGridViewStavke.Name = "dataGridViewStavke";
            dataGridViewStavke.Size = new Size(338, 200);
            dataGridViewStavke.TabIndex = 65;
            // 
            // dateTimePickerDatumIsteka
            // 
            dateTimePickerDatumIsteka.Location = new Point(319, 189);
            dateTimePickerDatumIsteka.Name = "dateTimePickerDatumIsteka";
            dateTimePickerDatumIsteka.Size = new Size(469, 23);
            dateTimePickerDatumIsteka.TabIndex = 64;
            // 
            // dateTimePickerDatumIzdavanja
            // 
            dateTimePickerDatumIzdavanja.Location = new Point(319, 133);
            dateTimePickerDatumIzdavanja.Name = "dateTimePickerDatumIzdavanja";
            dateTimePickerDatumIzdavanja.Size = new Size(469, 23);
            dateTimePickerDatumIzdavanja.TabIndex = 63;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F);
            label11.Location = new Point(319, 14);
            label11.Name = "label11";
            label11.Size = new Size(43, 17);
            label11.TabIndex = 62;
            label11.Text = "Lekari";
            // 
            // comboBoxPacijent
            // 
            comboBoxPacijent.Font = new Font("Century Gothic", 9F);
            comboBoxPacijent.FormattingEnabled = true;
            comboBoxPacijent.Location = new Point(319, 82);
            comboBoxPacijent.Name = "comboBoxPacijent";
            comboBoxPacijent.Size = new Size(469, 25);
            comboBoxPacijent.TabIndex = 61;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(comboBoxDoza);
            panel1.Controls.Add(buttonIzbrisiStavku);
            panel1.Controls.Add(textBoxUputstvo);
            panel1.Controls.Add(buttonDodajStavku);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dataGridViewStavke);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(comboBoxLek);
            panel1.Location = new Point(30, 343);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 266);
            panel1.TabIndex = 59;
            // 
            // comboBoxDoza
            // 
            comboBoxDoza.Font = new Font("Century Gothic", 9F);
            comboBoxDoza.FormattingEnabled = true;
            comboBoxDoza.Location = new Point(24, 90);
            comboBoxDoza.Name = "comboBoxDoza";
            comboBoxDoza.Size = new Size(331, 25);
            comboBoxDoza.TabIndex = 50;
            // 
            // buttonIzbrisiStavku
            // 
            buttonIzbrisiStavku.BackColor = Color.Crimson;
            buttonIzbrisiStavku.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzbrisiStavku.ForeColor = SystemColors.ButtonHighlight;
            buttonIzbrisiStavku.Location = new Point(199, 190);
            buttonIzbrisiStavku.Name = "buttonIzbrisiStavku";
            buttonIzbrisiStavku.Size = new Size(156, 45);
            buttonIzbrisiStavku.TabIndex = 49;
            buttonIzbrisiStavku.Text = "Izbrisi Stavku";
            buttonIzbrisiStavku.UseVisualStyleBackColor = false;
            buttonIzbrisiStavku.Click += buttonIzbrisiStavku_Click;
            // 
            // textBoxUputstvo
            // 
            textBoxUputstvo.Location = new Point(24, 142);
            textBoxUputstvo.Name = "textBoxUputstvo";
            textBoxUputstvo.Size = new Size(331, 23);
            textBoxUputstvo.TabIndex = 48;
            // 
            // buttonDodajStavku
            // 
            buttonDodajStavku.BackColor = Color.Crimson;
            buttonDodajStavku.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDodajStavku.ForeColor = SystemColors.ButtonHighlight;
            buttonDodajStavku.Location = new Point(24, 190);
            buttonDodajStavku.Name = "buttonDodajStavku";
            buttonDodajStavku.Size = new Size(156, 45);
            buttonDodajStavku.TabIndex = 21;
            buttonDodajStavku.Text = "Dodaj Stavku";
            buttonDodajStavku.UseVisualStyleBackColor = false;
            buttonDodajStavku.Click += buttonDodajStavku_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F);
            label8.Location = new Point(330, 122);
            label8.Name = "label8";
            label8.Size = new Size(0, 17);
            label8.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(24, 122);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 22;
            label5.Text = "Uputstvo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(24, 70);
            label6.Name = "label6";
            label6.Size = new Size(38, 17);
            label6.TabIndex = 20;
            label6.Text = "Doza";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(24, 15);
            label9.Name = "label9";
            label9.Size = new Size(28, 17);
            label9.TabIndex = 47;
            label9.Text = "Lek";
            // 
            // comboBoxLek
            // 
            comboBoxLek.Font = new Font("Century Gothic", 9F);
            comboBoxLek.FormattingEnabled = true;
            comboBoxLek.Location = new Point(24, 35);
            comboBoxLek.Name = "comboBoxLek";
            comboBoxLek.Size = new Size(331, 25);
            comboBoxLek.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F);
            label4.Location = new Point(319, 169);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 58;
            label4.Text = "Datum Isteka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.Location = new Point(319, 277);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 57;
            label3.Text = "Napomena";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F);
            label1.Location = new Point(319, 110);
            label1.Name = "label1";
            label1.Size = new Size(109, 17);
            label1.TabIndex = 56;
            label1.Text = "Datum Izdavanja";
            // 
            // textBoxNapomena
            // 
            textBoxNapomena.Font = new Font("Century Gothic", 9F);
            textBoxNapomena.Location = new Point(319, 295);
            textBoxNapomena.Name = "textBoxNapomena";
            textBoxNapomena.Size = new Size(469, 22);
            textBoxNapomena.TabIndex = 55;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.Location = new Point(319, 225);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 67;
            label2.Text = "Vreme Trajanja";
            // 
            // textBoxVremeTrajanja
            // 
            textBoxVremeTrajanja.Enabled = false;
            textBoxVremeTrajanja.Font = new Font("Century Gothic", 9F);
            textBoxVremeTrajanja.Location = new Point(319, 246);
            textBoxVremeTrajanja.Name = "textBoxVremeTrajanja";
            textBoxVremeTrajanja.Size = new Size(469, 22);
            textBoxVremeTrajanja.TabIndex = 66;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F);
            label7.Location = new Point(319, 62);
            label7.Name = "label7";
            label7.Size = new Size(57, 17);
            label7.TabIndex = 69;
            label7.Text = "Pacijent";
            // 
            // comboBoxLekar
            // 
            comboBoxLekar.FormattingEnabled = true;
            comboBoxLekar.Location = new Point(319, 34);
            comboBoxLekar.Name = "comboBoxLekar";
            comboBoxLekar.Size = new Size(469, 23);
            comboBoxLekar.TabIndex = 70;
            // 
            // FrmIzmeniRecept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(837, 712);
            Controls.Add(comboBoxLekar);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(textBoxVremeTrajanja);
            Controls.Add(buttonSacuvaj);
            Controls.Add(dateTimePickerDatumIsteka);
            Controls.Add(dateTimePickerDatumIzdavanja);
            Controls.Add(label11);
            Controls.Add(comboBoxPacijent);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxNapomena);
            Controls.Add(pictureBox1);
            Name = "FrmIzmeniRecept";
            Text = "Izmeni Recept";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStavke).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button buttonSacuvaj;
        public DataGridView dataGridViewStavke;
        public DateTimePicker dateTimePickerDatumIsteka;
        public DateTimePicker dateTimePickerDatumIzdavanja;
        private Label label11;
        public ComboBox comboBoxPacijent;
        private Panel panel1;
        public Button buttonIzbrisiStavku;
        public TextBox textBoxUputstvo;
        public Button buttonDodajStavku;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label9;
        public ComboBox comboBoxLek;
        private Label label4;
        private Label label3;
        private Label label1;
        public TextBox textBoxNapomena;
        private PictureBox pictureBox1;
        private Label label2;
        public TextBox textBoxVremeTrajanja;
        public ComboBox comboBoxDoza;
        private Label label7;
        public ComboBox comboBoxLekar;
    }
}