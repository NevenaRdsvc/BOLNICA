namespace Klijent
{
    partial class FrmPretraziRecept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPretraziRecept));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBoxKriterijum = new TextBox();
            buttonPretrazi = new Button();
            dgvRecepti = new DataGridView();
            buttonPrikazi = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecepti).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 525);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(379, 34);
            label1.Name = "label1";
            label1.Size = new Size(251, 18);
            label1.TabIndex = 1;
            label1.Text = "Unesite datum Izdavanja recepta";
            // 
            // textBoxKriterijum
            // 
            textBoxKriterijum.Location = new Point(379, 66);
            textBoxKriterijum.Name = "textBoxKriterijum";
            textBoxKriterijum.Size = new Size(251, 23);
            textBoxKriterijum.TabIndex = 2;
            // 
            // buttonPretrazi
            // 
            buttonPretrazi.BackColor = Color.Crimson;
            buttonPretrazi.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            buttonPretrazi.ForeColor = SystemColors.ControlLightLight;
            buttonPretrazi.Location = new Point(661, 34);
            buttonPretrazi.Name = "buttonPretrazi";
            buttonPretrazi.Size = new Size(151, 60);
            buttonPretrazi.TabIndex = 3;
            buttonPretrazi.Text = "Pretrazi";
            buttonPretrazi.UseVisualStyleBackColor = false;
            buttonPretrazi.Click += buttonPretrazi_Click;
            // 
            // dgvRecepti
            // 
            dgvRecepti.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRecepti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecepti.Location = new Point(379, 115);
            dgvRecepti.Name = "dgvRecepti";
            dgvRecepti.Size = new Size(433, 216);
            dgvRecepti.TabIndex = 4;
            // 
            // buttonPrikazi
            // 
            buttonPrikazi.BackColor = Color.Crimson;
            buttonPrikazi.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            buttonPrikazi.ForeColor = SystemColors.ControlLightLight;
            buttonPrikazi.Location = new Point(661, 359);
            buttonPrikazi.Name = "buttonPrikazi";
            buttonPrikazi.Size = new Size(151, 67);
            buttonPrikazi.TabIndex = 5;
            buttonPrikazi.Text = "Prikazi";
            buttonPrikazi.UseVisualStyleBackColor = false;
            buttonPrikazi.Click += buttonPrikazi_Click;
            // 
            // FrmPretraziRecept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(845, 443);
            Controls.Add(buttonPrikazi);
            Controls.Add(dgvRecepti);
            Controls.Add(buttonPretrazi);
            Controls.Add(textBoxKriterijum);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmPretraziRecept";
            Text = "Pretrazi Recept";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecepti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        public TextBox textBoxKriterijum;
        public Button buttonPretrazi;
        public DataGridView dgvRecepti;
        public Button buttonPrikazi;
    }
}