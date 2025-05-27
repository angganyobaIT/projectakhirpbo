namespace projectakhirpbo
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            btlogin = new Button();
            label1 = new Label();
            tbusername = new TextBox();
            btndaftar = new Button();
            label2 = new Label();
            linklogin = new LinkLabel();
            tbemail = new TextBox();
            tbpassword = new TextBox();
            tbconfirmpass = new TextBox();
            SuspendLayout();
            // 
            // btlogin
            // 
            btlogin.Location = new Point(1125, 463);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(108, 29);
            btlogin.TabIndex = 6;
            btlogin.Text = "LOGIN =>";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += btlogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(509, 172);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 7;
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Location = new Point(519, 166);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(467, 20);
            tbusername.TabIndex = 8;
            // 
            // btndaftar
            // 
            btndaftar.BackColor = Color.Crimson;
            btndaftar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndaftar.ForeColor = SystemColors.ButtonFace;
            btndaftar.Image = (Image)resources.GetObject("btndaftar.Image");
            btndaftar.ImageAlign = ContentAlignment.TopLeft;
            btndaftar.Location = new Point(480, 490);
            btndaftar.Name = "btndaftar";
            btndaftar.Size = new Size(546, 47);
            btndaftar.TabIndex = 15;
            btndaftar.Text = "Daftar";
            btndaftar.UseVisualStyleBackColor = false;
            btndaftar.Click += btndaftar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(671, 543);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 16;
            label2.Text = "Belum punya akun?";
            // 
            // linklogin
            // 
            linklogin.AutoSize = true;
            linklogin.BackColor = Color.Transparent;
            linklogin.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linklogin.LinkColor = Color.Black;
            linklogin.Location = new Point(786, 543);
            linklogin.Name = "linklogin";
            linklogin.Size = new Size(41, 17);
            linklogin.TabIndex = 17;
            linklogin.TabStop = true;
            linklogin.Text = "Login";
            linklogin.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tbemail
            // 
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Location = new Point(519, 256);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(467, 20);
            tbemail.TabIndex = 18;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(519, 345);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(467, 20);
            tbpassword.TabIndex = 19;
            // 
            // tbconfirmpass
            // 
            tbconfirmpass.BorderStyle = BorderStyle.None;
            tbconfirmpass.Location = new Point(519, 434);
            tbconfirmpass.Name = "tbconfirmpass";
            tbconfirmpass.Size = new Size(467, 20);
            tbconfirmpass.TabIndex = 20;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1095, 614);
            Controls.Add(tbconfirmpass);
            Controls.Add(tbpassword);
            Controls.Add(tbemail);
            Controls.Add(linklogin);
            Controls.Add(label2);
            Controls.Add(btndaftar);
            Controls.Add(tbusername);
            Controls.Add(label1);
            Controls.Add(btlogin);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btlogin;
        private Label label1;
        private TextBox tbusername;
        private Button btndaftar;
        private Label label2;
        private LinkLabel linklogin;
        private TextBox tbemail;
        private TextBox tbpassword;
        private TextBox tbconfirmpass;
    }
}
