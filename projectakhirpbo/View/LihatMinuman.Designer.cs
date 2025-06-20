namespace projectakhirpbo.View
{
    partial class LihatMinuman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatMinuman));
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            BTN_Cemilan = new PictureBox();
            BTN_Semua = new PictureBox();
            BTN_Makanan = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Cemilan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Semua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Makanan).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Location = new Point(97, 946);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 43);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(97, 406);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1068, 485);
            dataGridView1.TabIndex = 9;
            // 
            // BTN_Cemilan
            // 
            BTN_Cemilan.BackColor = Color.Gray;
            BTN_Cemilan.Location = new Point(748, 275);
            BTN_Cemilan.Name = "BTN_Cemilan";
            BTN_Cemilan.Size = new Size(139, 57);
            BTN_Cemilan.TabIndex = 13;
            BTN_Cemilan.TabStop = false;
            BTN_Cemilan.Click += BTN_Cemilan_Click;
            // 
            // BTN_Semua
            // 
            BTN_Semua.BackColor = Color.Gray;
            BTN_Semua.Location = new Point(110, 275);
            BTN_Semua.Name = "BTN_Semua";
            BTN_Semua.Size = new Size(120, 57);
            BTN_Semua.TabIndex = 12;
            BTN_Semua.TabStop = false;
            BTN_Semua.Click += BTN_Semua_Click;
            // 
            // BTN_Makanan
            // 
            BTN_Makanan.BackColor = Color.Gray;
            BTN_Makanan.Location = new Point(338, 275);
            BTN_Makanan.Name = "BTN_Makanan";
            BTN_Makanan.Size = new Size(128, 57);
            BTN_Makanan.TabIndex = 11;
            BTN_Makanan.TabStop = false;
            BTN_Makanan.Click += BTN_Makanan_Click;
            // 
            // LihatMinuman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(BTN_Cemilan);
            Controls.Add(BTN_Semua);
            Controls.Add(BTN_Makanan);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "LihatMinuman";
            Text = "LihatMinuman";
            Load += LihatMinuman_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Cemilan).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Semua).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Makanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private PictureBox BTN_Cemilan;
        private PictureBox BTN_Semua;
        private PictureBox BTN_Makanan;
    }
}