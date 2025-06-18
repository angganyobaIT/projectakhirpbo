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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(403, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1331, 610);
            dataGridView1.TabIndex = 10;
            // 
            // BTN_Home
            // 
            BTN_Home.BackColor = Color.White;
            BTN_Home.Location = new Point(152, 275);
            BTN_Home.Name = "BTN_Home";
            BTN_Home.Size = new Size(33, 36);
            BTN_Home.TabIndex = 11;
            BTN_Home.UseVisualStyleBackColor = false;
            BTN_Home.Click += BTN_Home_Click;
            // 
            // BTN_LihaResev
            // 
            BTN_LihaResev.BackColor = Color.White;
            BTN_LihaResev.Location = new Point(142, 425);
            BTN_LihaResev.Name = "BTN_LihaResev";
            BTN_LihaResev.Size = new Size(33, 36);
            BTN_LihaResev.TabIndex = 12;
            BTN_LihaResev.UseVisualStyleBackColor = false;
            BTN_LihaResev.Click += BTN_LihaResev_Click_1;
            // 
            // BTN_Profil
            // 
            BTN_Profil.BackColor = Color.White;
            BTN_Profil.Location = new Point(142, 571);
            BTN_Profil.Name = "BTN_Profil";
            BTN_Profil.Size = new Size(33, 36);
            BTN_Profil.TabIndex = 13;
            BTN_Profil.UseVisualStyleBackColor = false;
            BTN_Profil.Click += BTN_Profil_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Location = new Point(152, 901);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // BTN_History
            // 
            BTN_History.BackColor = SystemColors.ControlLightLight;
            BTN_History.CausesValidation = false;
            BTN_History.Location = new Point(403, 243);
            BTN_History.Name = "BTN_History";
            BTN_History.Size = new Size(142, 43);
            BTN_History.TabIndex = 15;
            BTN_History.Text = "History";
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