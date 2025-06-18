namespace projectakhirpbo.View
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            BTN_Profil = new Button();
            BTN_LihaResev = new Button();
            BTN_Home = new Button();
            tbUsername = new TextBox();
            tbEmail = new TextBox();
            tbCPassword = new TextBox();
            tbPassword = new TextBox();
            BTN_simpan = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTN_Profil
            // 
            BTN_Profil.BackColor = Color.White;
            BTN_Profil.Location = new Point(148, 571);
            BTN_Profil.Name = "BTN_Profil";
            BTN_Profil.Size = new Size(33, 36);
            BTN_Profil.TabIndex = 17;
            BTN_Profil.UseVisualStyleBackColor = false;
            // 
            // BTN_LihaResev
            // 
            BTN_LihaResev.BackColor = Color.White;
            BTN_LihaResev.Location = new Point(148, 425);
            BTN_LihaResev.Name = "BTN_LihaResev";
            BTN_LihaResev.Size = new Size(33, 36);
            BTN_LihaResev.TabIndex = 16;
            BTN_LihaResev.UseVisualStyleBackColor = false;
            BTN_LihaResev.Click += BTN_LihaResev_Click;
            // 
            // BTN_Home
            // 
            BTN_Home.BackColor = Color.White;
            BTN_Home.Location = new Point(148, 271);
            BTN_Home.Name = "BTN_Home";
            BTN_Home.Size = new Size(33, 36);
            BTN_Home.TabIndex = 15;
            BTN_Home.UseVisualStyleBackColor = false;
            BTN_Home.Click += BTN_Home_Click;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(992, 255);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(745, 29);
            tbUsername.TabIndex = 19;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(992, 408);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(745, 29);
            tbEmail.TabIndex = 20;
            // 
            // tbCPassword
            // 
            tbCPassword.BorderStyle = BorderStyle.None;
            tbCPassword.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCPassword.Location = new Point(992, 709);
            tbCPassword.Name = "tbCPassword";
            tbCPassword.Size = new Size(745, 29);
            tbCPassword.TabIndex = 22;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(992, 559);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(745, 29);
            tbPassword.TabIndex = 21;
            // 
            // BTN_simpan
            // 
            BTN_simpan.BackColor = Color.Transparent;
            BTN_simpan.BackgroundImage = (Image)resources.GetObject("BTN_simpan.BackgroundImage");
            BTN_simpan.BackgroundImageLayout = ImageLayout.Stretch;
            BTN_simpan.FlatAppearance.BorderSize = 0;
            BTN_simpan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTN_simpan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BTN_simpan.FlatStyle = FlatStyle.Flat;
            BTN_simpan.Location = new Point(962, 844);
            BTN_simpan.Name = "BTN_simpan";
            BTN_simpan.Size = new Size(801, 80);
            BTN_simpan.TabIndex = 23;
            BTN_simpan.UseVisualStyleBackColor = false;
            BTN_simpan.Click += BTN_simpan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Location = new Point(148, 907);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 50);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // Profil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(BTN_simpan);
            Controls.Add(tbCPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(tbUsername);
            Controls.Add(BTN_Profil);
            Controls.Add(BTN_LihaResev);
            Controls.Add(BTN_Home);
            DoubleBuffered = true;
            Name = "Profil";
            Text = "Profil";
            Load += Profil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BTN_Profil;
        private Button BTN_LihaResev;
        private Button BTN_Home;
        private TextBox tbUsername;
        private TextBox tbEmail;
        private TextBox tbCPassword;
        private TextBox tbPassword;
        private Button BTN_simpan;
        private PictureBox pictureBox1;
    }
}