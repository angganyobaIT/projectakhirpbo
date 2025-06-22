namespace projectakhirpbo.View
{
    partial class LihatMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatMenu));
            BTN_Cemilan = new PictureBox();
            BTN_Minuman = new PictureBox();
            BTN_Makanan = new PictureBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BTN_Cemilan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Minuman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Makanan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTN_Cemilan
            // 
            BTN_Cemilan.BackColor = Color.White;
            BTN_Cemilan.BackgroundImage = (Image)resources.GetObject("BTN_Cemilan.BackgroundImage");
            BTN_Cemilan.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_Cemilan.Location = new Point(736, 98);
            BTN_Cemilan.Name = "BTN_Cemilan";
            BTN_Cemilan.Size = new Size(165, 181);
            BTN_Cemilan.TabIndex = 7;
            BTN_Cemilan.TabStop = false;
            BTN_Cemilan.Click += BTN_Cemilan_Click;
            // 
            // BTN_Minuman
            // 
            BTN_Minuman.BackColor = Color.White;
            BTN_Minuman.BackgroundImage = (Image)resources.GetObject("BTN_Minuman.BackgroundImage");
            BTN_Minuman.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_Minuman.Location = new Point(553, 96);
            BTN_Minuman.Name = "BTN_Minuman";
            BTN_Minuman.Size = new Size(124, 183);
            BTN_Minuman.TabIndex = 6;
            BTN_Minuman.TabStop = false;
            BTN_Minuman.Click += BTN_Minuman_Click;
            // 
            // BTN_Makanan
            // 
            BTN_Makanan.BackColor = Color.White;
            BTN_Makanan.BackgroundImage = (Image)resources.GetObject("BTN_Makanan.BackgroundImage");
            BTN_Makanan.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_Makanan.Location = new Point(309, 125);
            BTN_Makanan.Name = "BTN_Makanan";
            BTN_Makanan.Size = new Size(179, 154);
            BTN_Makanan.TabIndex = 5;
            BTN_Makanan.TabStop = false;
            BTN_Makanan.Click += BTN_Makanan_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 408);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1068, 485);
            dataGridView1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(56, 944);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 43);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LihatMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(BTN_Cemilan);
            Controls.Add(BTN_Minuman);
            Controls.Add(BTN_Makanan);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "LihatMenu";
            Text = "LihatMenu";
            Load += LihatMenu_Load;
            ((System.ComponentModel.ISupportInitialize)BTN_Cemilan).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Minuman).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Makanan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BTN_Cemilan;
        private PictureBox BTN_Minuman;
        private PictureBox BTN_Makanan;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}