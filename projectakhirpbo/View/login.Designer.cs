namespace projectakhirpbo
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            tbusernamelog = new TextBox();
            tbpasswordlog = new TextBox();
            btnmasuk = new Button();
            linkregister = new LinkLabel();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // tbusernamelog
            // 
            tbusernamelog.BorderStyle = BorderStyle.None;
            tbusernamelog.Location = new Point(501, 245);
            tbusernamelog.Name = "tbusernamelog";
            tbusernamelog.Size = new Size(467, 20);
            tbusernamelog.TabIndex = 21;
            // 
            // tbpasswordlog
            // 
            tbpasswordlog.BorderStyle = BorderStyle.None;
            tbpasswordlog.Location = new Point(489, 331);
            tbpasswordlog.Name = "tbpasswordlog";
            tbpasswordlog.Size = new Size(467, 20);
            tbpasswordlog.TabIndex = 22;
            // 
            // btnmasuk
            // 
            btnmasuk.BackColor = Color.Crimson;
            btnmasuk.FlatStyle = FlatStyle.Popup;
            btnmasuk.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmasuk.ForeColor = SystemColors.ButtonFace;
            btnmasuk.Image = (Image)resources.GetObject("btnmasuk.Image");
            btnmasuk.ImageAlign = ContentAlignment.TopLeft;
            btnmasuk.Location = new Point(467, 405);
            btnmasuk.Name = "btnmasuk";
            btnmasuk.Size = new Size(522, 42);
            btnmasuk.TabIndex = 23;
            btnmasuk.Text = "Masuk";
            btnmasuk.UseVisualStyleBackColor = false;
            btnmasuk.Click += btnmasuk_Click;
            // 
            // linkregister
            // 
            linkregister.AutoSize = true;
            linkregister.BackColor = Color.Transparent;
            linkregister.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkregister.LinkColor = Color.Black;
            linkregister.Location = new Point(757, 454);
            linkregister.Name = "linkregister";
            linkregister.Size = new Size(57, 17);
            linkregister.TabIndex = 25;
            linkregister.TabStop = true;
            linkregister.Text = "Register";
            linkregister.LinkClicked += linkregister_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(642, 454);
            label2.Name = "label2";
            label2.Size = new Size(120, 17);
            label2.TabIndex = 24;
            label2.Text = "Sudah punya akun?";
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(820, 454);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(58, 20);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "admin?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1053, 594);
            Controls.Add(linkLabel1);
            Controls.Add(linkregister);
            Controls.Add(label2);
            Controls.Add(btnmasuk);
            Controls.Add(tbpasswordlog);
            Controls.Add(tbusernamelog);
            DoubleBuffered = true;
            Name = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbusernamelog;
        private TextBox tbpasswordlog;
        private Button btnmasuk;
        private LinkLabel linkregister;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}