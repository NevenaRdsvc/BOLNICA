namespace Klijent
{
    partial class FrmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavna));
            menuStrip1 = new MenuStrip();
            pacijentToolStripMenuItem = new ToolStripMenuItem();
            ubaciPacijentaToolStripMenuItem = new ToolStripMenuItem();
            pretraziPacijentaToolStripMenuItem = new ToolStripMenuItem();
            receptToolStripMenuItem = new ToolStripMenuItem();
            ubaciReceptToolStripMenuItem = new ToolStripMenuItem();
            pretraziReceptToolStripMenuItem = new ToolStripMenuItem();
            lekToolStripMenuItem = new ToolStripMenuItem();
            ubaciLekToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            bolnicaToolStripMenuItem = new ToolStripMenuItem();
            ubaciToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Azure;
            menuStrip1.Items.AddRange(new ToolStripItem[] { pacijentToolStripMenuItem, receptToolStripMenuItem, lekToolStripMenuItem, bolnicaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(862, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pacijentToolStripMenuItem
            // 
            pacijentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ubaciPacijentaToolStripMenuItem, pretraziPacijentaToolStripMenuItem });
            pacijentToolStripMenuItem.Name = "pacijentToolStripMenuItem";
            pacijentToolStripMenuItem.Size = new Size(61, 20);
            pacijentToolStripMenuItem.Text = "Pacijent";
            // 
            // ubaciPacijentaToolStripMenuItem
            // 
            ubaciPacijentaToolStripMenuItem.Name = "ubaciPacijentaToolStripMenuItem";
            ubaciPacijentaToolStripMenuItem.Size = new Size(164, 22);
            ubaciPacijentaToolStripMenuItem.Text = "Ubaci Pacijenta";
            ubaciPacijentaToolStripMenuItem.Click += ubaciPacijentaToolStripMenuItem_Click;
            // 
            // pretraziPacijentaToolStripMenuItem
            // 
            pretraziPacijentaToolStripMenuItem.Name = "pretraziPacijentaToolStripMenuItem";
            pretraziPacijentaToolStripMenuItem.Size = new Size(164, 22);
            pretraziPacijentaToolStripMenuItem.Text = "Pretrazi Pacijenta";
            pretraziPacijentaToolStripMenuItem.Click += pretraziPacijentaToolStripMenuItem_Click;
            // 
            // receptToolStripMenuItem
            // 
            receptToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ubaciReceptToolStripMenuItem, pretraziReceptToolStripMenuItem });
            receptToolStripMenuItem.Name = "receptToolStripMenuItem";
            receptToolStripMenuItem.Size = new Size(55, 20);
            receptToolStripMenuItem.Text = "Recept";
            // 
            // ubaciReceptToolStripMenuItem
            // 
            ubaciReceptToolStripMenuItem.Name = "ubaciReceptToolStripMenuItem";
            ubaciReceptToolStripMenuItem.Size = new Size(152, 22);
            ubaciReceptToolStripMenuItem.Text = "Ubaci Recept";
            ubaciReceptToolStripMenuItem.Click += ubaciReceptToolStripMenuItem_Click;
            // 
            // pretraziReceptToolStripMenuItem
            // 
            pretraziReceptToolStripMenuItem.Name = "pretraziReceptToolStripMenuItem";
            pretraziReceptToolStripMenuItem.Size = new Size(152, 22);
            pretraziReceptToolStripMenuItem.Text = "Pretrazi Recept";
            pretraziReceptToolStripMenuItem.Click += pretraziReceptToolStripMenuItem_Click;
            // 
            // lekToolStripMenuItem
            // 
            lekToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ubaciLekToolStripMenuItem });
            lekToolStripMenuItem.Name = "lekToolStripMenuItem";
            lekToolStripMenuItem.Size = new Size(37, 20);
            lekToolStripMenuItem.Text = "Lek";
            // 
            // ubaciLekToolStripMenuItem
            // 
            ubaciLekToolStripMenuItem.Name = "ubaciLekToolStripMenuItem";
            ubaciLekToolStripMenuItem.Size = new Size(180, 22);
            ubaciLekToolStripMenuItem.Text = "Ubaci Lek";
            ubaciLekToolStripMenuItem.Click += ubaciLekToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(850, 470);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // bolnicaToolStripMenuItem
            // 
            bolnicaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ubaciToolStripMenuItem });
            bolnicaToolStripMenuItem.Name = "bolnicaToolStripMenuItem";
            bolnicaToolStripMenuItem.Size = new Size(58, 20);
            bolnicaToolStripMenuItem.Text = "Bolnica";
            // 
            // ubaciToolStripMenuItem
            // 
            ubaciToolStripMenuItem.Name = "ubaciToolStripMenuItem";
            ubaciToolStripMenuItem.Size = new Size(180, 22);
            ubaciToolStripMenuItem.Text = "Ubaci Bolnicu";
            ubaciToolStripMenuItem.Click += ubaciToolStripMenuItem_Click;
            // 
            // FrmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(862, 522);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmGlavna";
            Text = "Glavna";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pacijentToolStripMenuItem;
        private ToolStripMenuItem ubaciPacijentaToolStripMenuItem;
        private ToolStripMenuItem pretraziPacijentaToolStripMenuItem;
        private ToolStripMenuItem receptToolStripMenuItem;
        private ToolStripMenuItem ubaciReceptToolStripMenuItem;
        private ToolStripMenuItem pretraziReceptToolStripMenuItem;
        private ToolStripMenuItem lekToolStripMenuItem;
        private ToolStripMenuItem ubaciLekToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem bolnicaToolStripMenuItem;
        private ToolStripMenuItem ubaciToolStripMenuItem;
    }
}