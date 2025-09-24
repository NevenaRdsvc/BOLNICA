namespace Klijent
{
    partial class FrmPretraziPacijente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPretraziPacijente));
            textBoxPretragaPacijenta = new TextBox();
            buttonPretraga = new Button();
            dgvPacijenti = new DataGridView();
            buttonPrikazi = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxPretragaPacijenta
            // 
            textBoxPretragaPacijenta.Location = new Point(446, 78);
            textBoxPretragaPacijenta.Name = "textBoxPretragaPacijenta";
            textBoxPretragaPacijenta.Size = new Size(292, 23);
            textBoxPretragaPacijenta.TabIndex = 1;
            // 
            // buttonPretraga
            // 
            buttonPretraga.BackColor = Color.Crimson;
            buttonPretraga.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPretraga.ForeColor = SystemColors.ButtonHighlight;
            buttonPretraga.Location = new Point(758, 50);
            buttonPretraga.Name = "buttonPretraga";
            buttonPretraga.Size = new Size(128, 55);
            buttonPretraga.TabIndex = 2;
            buttonPretraga.Text = "Pretrazi";
            buttonPretraga.UseVisualStyleBackColor = false;
            buttonPretraga.Click += buttonPretraga_Click;
            // 
            // dgvPacijenti
            // 
            dgvPacijenti.BackgroundColor = Color.Azure;
            dgvPacijenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacijenti.Location = new Point(446, 147);
            dgvPacijenti.Name = "dgvPacijenti";
            dgvPacijenti.Size = new Size(440, 229);
            dgvPacijenti.TabIndex = 3;
            // 
            // buttonPrikazi
            // 
            buttonPrikazi.BackColor = Color.Crimson;
            buttonPrikazi.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrikazi.ForeColor = SystemColors.ButtonHighlight;
            buttonPrikazi.Location = new Point(758, 408);
            buttonPrikazi.Name = "buttonPrikazi";
            buttonPrikazi.Size = new Size(128, 55);
            buttonPrikazi.TabIndex = 4;
            buttonPrikazi.Text = "Prikazi";
            buttonPrikazi.UseVisualStyleBackColor = false;
            buttonPrikazi.Click += buttonPrikazi_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-15, -190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 909);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(446, 50);
            label1.Name = "label1";
            label1.Size = new Size(159, 16);
            label1.TabIndex = 6;
            label1.Text = "Unesite JMBG Pacijenta";
            // 
            // FrmPretraziPacijente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(926, 489);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonPrikazi);
            Controls.Add(dgvPacijenti);
            Controls.Add(buttonPretraga);
            Controls.Add(textBoxPretragaPacijenta);
            Name = "FrmPretraziPacijente";
            Text = "Pretrazi Pacijent";
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox textBoxPretragaPacijenta;
        public Button buttonPretraga;
        public DataGridView dgvPacijenti;
        public Button buttonPrikazi;
        private PictureBox pictureBox1;
        private Label label1;
    }
}