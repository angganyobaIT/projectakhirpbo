namespace projectakhirpbo.View
{
    partial class historireservasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historireservasi));
            pictureBox1 = new PictureBox();
            BTN_Profil = new Button();
            BTN_LihaResev = new Button();
            BTN_Home = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Location = new Point(114, 669);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BTN_Profil
            // 
            BTN_Profil.BackColor = Color.White;
            BTN_Profil.Location = new Point(114, 414);
            BTN_Profil.Name = "BTN_Profil";
            BTN_Profil.Size = new Size(33, 36);
            BTN_Profil.TabIndex = 19;
            BTN_Profil.UseVisualStyleBackColor = false;
            BTN_Profil.Click += BTN_Profil_Click;
            // 
            // BTN_LihaResev
            // 
            BTN_LihaResev.BackColor = Color.White;
            BTN_LihaResev.Location = new Point(114, 311);
            BTN_LihaResev.Name = "BTN_LihaResev";
            BTN_LihaResev.Size = new Size(33, 36);
            BTN_LihaResev.TabIndex = 18;
            BTN_LihaResev.UseVisualStyleBackColor = false;
            BTN_LihaResev.Click += BTN_LihaResev_Click;
            // 
            // BTN_Home
            // 
            BTN_Home.BackColor = Color.White;
            BTN_Home.Location = new Point(114, 200);
            BTN_Home.Name = "BTN_Home";
            BTN_Home.Size = new Size(33, 36);
            BTN_Home.TabIndex = 17;
            BTN_Home.UseVisualStyleBackColor = false;
            BTN_Home.Click += BTN_Home_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(304, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1331, 610);
            dataGridView1.TabIndex = 16;
            // 
            // historireservasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1664, 775);
            Controls.Add(pictureBox1);
            Controls.Add(BTN_Profil);
            Controls.Add(BTN_LihaResev);
            Controls.Add(BTN_Home);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "historireservasi";
            Text = "historireservasi";
            Load += historireservasi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button homepagebtn;
        private Button button2;
        private Button logoutbtn;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button BTN_Profil;
        private Button BTN_LihaResev;
        private Button BTN_Home;
    }
}