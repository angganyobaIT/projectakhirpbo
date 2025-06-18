namespace projectakhirpbo.View
{
    partial class LihatCemilan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatCemilan));
            pictureBox1 = new PictureBox();
            BTN_MAKAN = new PictureBox();
            BTN_Minuman = new PictureBox();
            BTN_semua = new PictureBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_MAKAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Minuman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_semua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(79, 946);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 43);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BTN_MAKAN
            // 
            BTN_MAKAN.BackColor = Color.White;
            BTN_MAKAN.Location = new Point(330, 239);
            BTN_MAKAN.Name = "BTN_MAKAN";
            BTN_MAKAN.Size = new Size(139, 149);
            BTN_MAKAN.TabIndex = 8;
            BTN_MAKAN.TabStop = false;
            BTN_MAKAN.Click += BTN_MAKAN_Click;
            // 
            // BTN_Minuman
            // 
            BTN_Minuman.BackColor = Color.White;
            BTN_Minuman.Location = new Point(551, 235);
            BTN_Minuman.Name = "BTN_Minuman";
            BTN_Minuman.Size = new Size(120, 153);
            BTN_Minuman.TabIndex = 7;
            BTN_Minuman.TabStop = false;
            BTN_Minuman.Click += BTN_Minuman_Click;
            // 
            // BTN_semua
            // 
            BTN_semua.BackColor = Color.White;
            BTN_semua.Location = new Point(79, 235);
            BTN_semua.Name = "BTN_semua";
            BTN_semua.Size = new Size(139, 149);
            BTN_semua.TabIndex = 6;
            BTN_semua.TabStop = false;
            BTN_semua.Click += BTN_semua_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(93, 419);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1068, 485);
            dataGridView1.TabIndex = 5;
            // 
            // LihatCemilan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(BTN_MAKAN);
            Controls.Add(BTN_Minuman);
            Controls.Add(BTN_semua);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "LihatCemilan";
            Text = "LihatCemilan";
            Load += LihatCemilan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_MAKAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Minuman).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_semua).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox BTN_MAKAN;
        private PictureBox BTN_Minuman;
        private PictureBox BTN_semua;
        private DataGridView dataGridView1;
    }
}