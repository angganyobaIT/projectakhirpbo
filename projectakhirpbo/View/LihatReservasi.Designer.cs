namespace projectakhirpbo.View
{
    partial class LihatReservasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatReservasi));
            dataGridView1 = new DataGridView();
            BTN_Home = new Button();
            BTN_LihaResev = new Button();
            BTN_Profil = new Button();
            pictureBox1 = new PictureBox();
            BTN_History = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Location = new Point(403, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1331, 610);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // BTN_Home
            // 
            BTN_Home.BackColor = Color.White;
            BTN_Home.BackgroundImage = (Image)resources.GetObject("BTN_Home.BackgroundImage");
            BTN_Home.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_Home.FlatAppearance.BorderSize = 0;
            BTN_Home.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTN_Home.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BTN_Home.FlatStyle = FlatStyle.Flat;
            BTN_Home.Location = new Point(101, 265);
            BTN_Home.Name = "BTN_Home";
            BTN_Home.Size = new Size(33, 36);
            BTN_Home.TabIndex = 11;
            BTN_Home.UseVisualStyleBackColor = false;
            BTN_Home.Click += BTN_Home_Click;
            // 
            // BTN_LihaResev
            // 
            BTN_LihaResev.BackColor = Color.White;
            BTN_LihaResev.BackgroundImage = (Image)resources.GetObject("BTN_LihaResev.BackgroundImage");
            BTN_LihaResev.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_LihaResev.FlatAppearance.BorderSize = 0;
            BTN_LihaResev.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTN_LihaResev.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BTN_LihaResev.FlatStyle = FlatStyle.Flat;
            BTN_LihaResev.Location = new Point(101, 477);
            BTN_LihaResev.Name = "BTN_LihaResev";
            BTN_LihaResev.Size = new Size(33, 36);
            BTN_LihaResev.TabIndex = 12;
            BTN_LihaResev.UseVisualStyleBackColor = false;
            BTN_LihaResev.Click += BTN_LihaResev_Click_1;
            // 
            // BTN_Profil
            // 
            BTN_Profil.BackColor = Color.White;
            BTN_Profil.BackgroundImage = (Image)resources.GetObject("BTN_Profil.BackgroundImage");
            BTN_Profil.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_Profil.FlatAppearance.BorderSize = 0;
            BTN_Profil.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTN_Profil.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BTN_Profil.FlatStyle = FlatStyle.Flat;
            BTN_Profil.Location = new Point(101, 696);
            BTN_Profil.Name = "BTN_Profil";
            BTN_Profil.Size = new Size(33, 36);
            BTN_Profil.TabIndex = 13;
            BTN_Profil.UseVisualStyleBackColor = false;
            BTN_Profil.Click += BTN_Profil_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(101, 922);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // BTN_History
            // 
            BTN_History.BackColor = SystemColors.ControlLightLight;
            BTN_History.BackgroundImage = (Image)resources.GetObject("BTN_History.BackgroundImage");
            BTN_History.BackgroundImageLayout = ImageLayout.Zoom;
            BTN_History.CausesValidation = false;
            BTN_History.FlatAppearance.BorderSize = 0;
            BTN_History.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTN_History.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BTN_History.FlatStyle = FlatStyle.Flat;
            BTN_History.Location = new Point(1504, 140);
            BTN_History.Name = "BTN_History";
            BTN_History.Size = new Size(271, 95);
            BTN_History.TabIndex = 15;
            BTN_History.UseVisualStyleBackColor = false;
            BTN_History.Click += BTN_History_Click;
            // 
            // LihatReservasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(BTN_History);
            Controls.Add(pictureBox1);
            Controls.Add(BTN_Profil);
            Controls.Add(BTN_LihaResev);
            Controls.Add(BTN_Home);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "LihatReservasi";
            Text = "LihatReservasi";
            Load += LihatReservasi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BTN_Home;
        private Button BTN_LihaResev;
        private Button BTN_Profil;
        private PictureBox pictureBox1;
        private Button BTN_History;
    }
}