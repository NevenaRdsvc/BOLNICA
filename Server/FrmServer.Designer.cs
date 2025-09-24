namespace Server
{
    partial class FrmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            buttonStart = new Button();
            buttonStop = new Button();
            textBoxStanje = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Azure;
            buttonStart.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.ForeColor = SystemColors.ActiveCaptionText;
            buttonStart.Location = new Point(344, 38);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(309, 79);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.Crimson;
            buttonStop.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStop.ForeColor = SystemColors.ButtonHighlight;
            buttonStop.Location = new Point(347, 138);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(306, 79);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // textBoxStanje
            // 
            textBoxStanje.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxStanje.Location = new Point(347, 269);
            textBoxStanje.Name = "textBoxStanje";
            textBoxStanje.Size = new Size(306, 22);
            textBoxStanje.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(691, 326);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxStanje);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Name = "FrmServer";
            Text = "Server";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Button buttonStop;
        private TextBox textBoxStanje;
        private PictureBox pictureBox1;
    }
}
