namespace projectakhirpbo.View
{
    partial class LihatMakananSaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatMakananSaja));
            dataGridView1 = new DataGridView();
            BTN_semua = new PictureBox();
            BTN_Minuman = new PictureBox();
            BTN_Cemilan = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_semua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Minuman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Cemilan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 419);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1068, 485);
            dataGridView1.TabIndex = 0;
            // 
            // BTN_semua
            // 
            BTN_semua.BackColor = Color.White;
            BTN_semua.Location = new Point(61, 226);
            BTN_semua.Name = "BTN_semua";
            BTN_semua.Size = new Size(139, 149);
            BTN_semua.TabIndex = 1;
            BTN_semua.TabStop = false;
            BTN_semua.Click += BTN_semua_Click;
            // 
            // BTN_Minuman
            // 
            BTN_Minuman.BackColor = Color.White;
            BTN_Minuman.Location = new Point(549, 235);
            BTN_Minuman.Name = "BTN_Minuman";
            BTN_Minuman.Size = new Size(120, 153);
            BTN_Minuman.TabIndex = 2;
            BTN_Minuman.TabStop = false;
            BTN_Minuman.Click += BTN_Minuman_Click;
            // 
            // BTN_Cemilan
            // 
            BTN_Cemilan.BackColor = Color.White;
            BTN_Cemilan.Location = new Point(740, 235);
            BTN_Cemilan.Name = "BTN_Cemilan";
            BTN_Cemilan.Size = new Size(139, 149);
            BTN_Cemilan.TabIndex = 3;
            BTN_Cemilan.TabStop = false;
            BTN_Cemilan.Click += BTN_Cemilan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(77, 946);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 43);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LihatMakananSaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(BTN_Cemilan);
            Controls.Add(BTN_Minuman);
            Controls.Add(BTN_semua);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "LihatMakananSaja";
            Text = "LihatMakananSaja";
            Load += LihatMakananSaja_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_semua).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Minuman).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTN_Cemilan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox BTN_semua;
        private PictureBox BTN_Minuman;
        private PictureBox BTN_Cemilan;
        private PictureBox pictureBox1;
    }
}