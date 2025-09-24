namespace Klijent
{
    partial class FrmUbaciRecept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUbaciRecept));
            label9 = new Label();
            comboBoxLek = new ComboBox();
            panel1 = new Panel();
            comboBoxDoza = new ComboBox();
            buttonIzbrisiStavku = new Button();
            textBoxUputstvo = new TextBox();
            dataGridViewStavke = new DataGridView();
            buttonIzbrisi = new Button();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBoxNapomena = new TextBox();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            comboBoxPacijent = new ComboBox();
            dateTimePickerDatumIzdavanja = new DateTimePicker();
            dateTimePickerDatumIsteka = new DateTimePicker();
            buttonSacuvaj = new Button();
            label10 = new Label();
            comboBoxLekari = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStavke).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(25, 22);
            label9.Name = "label9";
            label9.Size = new Size(28, 17);
            label9.TabIndex = 47;
            label9.Text = "Lek";
            // 
            // comboBoxLek
            // 
            comboBoxLek.Font = new Font("Century Gothic", 9F);
            comboBoxLek.FormattingEnabled = true;
            comboBoxLek.Location = new Point(25, 42);
            comboBoxLek.Name = "comboBoxLek";
            comboBoxLek.Size = new Size(331, 25);
            comboBoxLek.TabIndex = 45;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(comboBoxDoza);
            panel1.Controls.Add(buttonIzbrisiStavku);
            panel1.Controls.Add(textBoxUputstvo);
            panel1.Controls.Add(dataGridViewStavke);
            panel1.Controls.Add(buttonIzbrisi);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(comboBoxLek);
            panel1.Location = new Point(27, 309);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 281);
            panel1.TabIndex = 44;
            // 
            // comboBoxDoza
            // 
            comboBoxDoza.Font = new Font("Century Gothic", 9F);
            comboBoxDoza.FormattingEnabled = true;
            comboBoxDoza.Location = new Point(25, 99);
            comboBoxDoza.Name = "comboBoxDoza";
            comboBoxDoza.Size = new Size(331, 25);
            comboBoxDoza.TabIndex = 50;
            // 
            // buttonIzbrisiStavku
            // 
            buttonIzbrisiStavku.BackColor = Color.Crimson;
            buttonIzbrisiStavku.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzbrisiStavku.ForeColor = SystemColors.ButtonHighlight;
            buttonIzbrisiStavku.Location = new Point(200, 196);
            buttonIzbrisiStavku.Name = "buttonIzbrisiStavku";
            buttonIzbrisiStavku.Size = new Size(156, 56);
            buttonIzbrisiStavku.TabIndex = 49;
            buttonIzbrisiStavku.Text = "Izbrisi Stavku";
            buttonIzbrisiStavku.UseVisualStyleBackColor = false;
            buttonIzbrisiStavku.Click += buttonIzbrisiStavku_Click;
            // 
            // textBoxUputstvo
            // 
            textBoxUputstvo.Location = new Point(25, 158);
            textBoxUputstvo.Name = "textBoxUputstvo";
            textBoxUputstvo.Size = new Size(331, 23);
            textBoxUputstvo.TabIndex = 48;
            // 
            // dataGridViewStavke
            // 
            dataGridViewStavke.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStavke.Location = new Point(387, 33);
            dataGridViewStavke.Name = "dataGridViewStavke";
            dataGridViewStavke.Size = new Size(343, 219);
            dataGridViewStavke.TabIndex = 53;
            // 
            // buttonIzbrisi
            // 
            buttonIzbrisi.BackColor = Color.Crimson;
            buttonIzbrisi.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzbrisi.ForeColor = SystemColors.ButtonHighlight;
            buttonIzbrisi.Location = new Point(25, 196);
            buttonIzbrisi.Name = "buttonIzbrisi";
            buttonIzbrisi.Size = new Size(156, 56);
            buttonIzbrisi.TabIndex = 21;
            buttonIzbrisi.Text = "Dodaj Stavku";
            buttonIzbrisi.UseVisualStyleBackColor = false;
            buttonIzbrisi.Click += buttonDodaj_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F);
            label8.Location = new Point(331, 138);
            label8.Name = "label8";
            label8.Size = new Size(0, 17);
            label8.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(25, 138);
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
            label6.Location = new Point(25, 79);
            label6.Name = "label6";
            label6.Size = new Size(38, 17);
            label6.TabIndex = 20;
            label6.Text = "Doza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F);
            label4.Location = new Point(316, 179);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 43;
            label4.Text = "Datum Isteka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.Location = new Point(316, 237);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 42;
            label3.Text = "Napomena";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F);
            label1.Location = new Point(316, 120);
            label1.Name = "label1";
            label1.Size = new Size(109, 17);
            label1.TabIndex = 40;
            label1.Text = "Datum Izdavanja";
            // 
            // textBoxNapomena
            // 
            textBoxNapomena.Font = new Font("Century Gothic", 9F);
            textBoxNapomena.Location = new Point(316, 255);
            textBoxNapomena.Name = "textBoxNapomena";
            textBoxNapomena.Size = new Size(469, 22);
            textBoxNapomena.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-16, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F);
            label11.Location = new Point(316, 71);
            label11.Name = "label11";
            label11.Size = new Size(57, 17);
            label11.TabIndex = 50;
            label11.Text = "Pacijent";
            // 
            // comboBoxPacijent
            // 
            comboBoxPacijent.Font = new Font("Century Gothic", 9F);
            comboBoxPacijent.FormattingEnabled = true;
            comboBoxPacijent.Location = new Point(316, 91);
            comboBoxPacijent.Name = "comboBoxPacijent";
            comboBoxPacijent.Size = new Size(469, 25);
            comboBoxPacijent.TabIndex = 49;
            // 
            // dateTimePickerDatumIzdavanja
            // 
            dateTimePickerDatumIzdavanja.Location = new Point(316, 143);
            dateTimePickerDatumIzdavanja.Name = "dateTimePickerDatumIzdavanja";
            dateTimePickerDatumIzdavanja.Size = new Size(469, 23);
            dateTimePickerDatumIzdavanja.TabIndex = 51;
            // 
            // dateTimePickerDatumIsteka
            // 
            dateTimePickerDatumIsteka.Location = new Point(316, 199);
            dateTimePickerDatumIsteka.Name = "dateTimePickerDatumIsteka";
            dateTimePickerDatumIsteka.Size = new Size(469, 23);
            dateTimePickerDatumIsteka.TabIndex = 52;
            // 
            // buttonSacuvaj
            // 
            buttonSacuvaj.BackColor = Color.Crimson;
            buttonSacuvaj.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSacuvaj.ForeColor = SystemColors.ButtonHighlight;
            buttonSacuvaj.Location = new Point(629, 610);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new Size(156, 56);
            buttonSacuvaj.TabIndex = 49;
            buttonSacuvaj.Text = "Sacuvaj";
            buttonSacuvaj.UseVisualStyleBackColor = false;
            buttonSacuvaj.Click += buttonUbaciRecept_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F);
            label10.Location = new Point(316, 23);
            label10.Name = "label10";
            label10.Size = new Size(43, 17);
            label10.TabIndex = 56;
            label10.Text = "Lekari";
            // 
            // comboBoxLekari
            // 
            comboBoxLekari.Font = new Font("Century Gothic", 9F);
            comboBoxLekari.FormattingEnabled = true;
            comboBoxLekari.Location = new Point(316, 43);
            comboBoxLekari.Name = "comboBoxLekari";
            comboBoxLekari.Size = new Size(469, 25);
            comboBoxLekari.TabIndex = 55;
            // 
            // FrmUbaciRecept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(821, 681);
            Controls.Add(label10);
            Controls.Add(comboBoxLekari);
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
            Name = "FrmUbaciRecept";
            Text = "Ubaci Recept";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStavke).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewStavke;
        private Label label9;
        public ComboBox comboBoxLek;
        public Button buttonSacuvaj;
        private Panel panel1;
        public Button buttonIzbrisi;
        private Label label8;
        public TextBox textBox5;
        private Label label5;
        private Label label6;
        public TextBox textBox7;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox textBoxNapomena;
        public TextBox textBoxVremeTrajanja;
        private PictureBox pictureBox1;
        private Label label11;
        public ComboBox comboBoxPacijent;
        public DateTimePicker dateTimePickerDatumIzdavanja;
        public DateTimePicker dateTimePicker2;
        public TextBox textBoxUputstvo;
        public DateTimePicker dateTimePickerDatumIsteka;
        public Button buttonIzbrisiStavku;
        private Label label10;
        public ComboBox comboBoxLekari;
        public ComboBox comboBoxDoza;
    }
}