﻿namespace projectakhirpbo
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
            checkshow1 = new CheckBox();
            checkshow2 = new CheckBox();
            SuspendLayout();
            // 
            // btlogin
            // 
            btlogin.Location = new Point(1334, 498);
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
            tbusername.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbusername.Location = new Point(874, 274);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(841, 40);
            tbusername.TabIndex = 8;
            tbusername.TextChanged += tbusername_TextChanged;
            // 
            // btndaftar
            // 
            btndaftar.BackColor = Color.Crimson;
            btndaftar.FlatStyle = FlatStyle.Popup;
            btndaftar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndaftar.ForeColor = SystemColors.ButtonFace;
            btndaftar.Image = (Image)resources.GetObject("btndaftar.Image");
            btndaftar.ImageAlign = ContentAlignment.TopLeft;
            btndaftar.Location = new Point(894, 898);
            btndaftar.Name = "btndaftar";
            btndaftar.Size = new Size(830, 60);
            btndaftar.TabIndex = 15;
            btndaftar.Text = "Daftar";
            btndaftar.UseVisualStyleBackColor = false;
            btndaftar.Click += btndaftar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1104, 800);
            label2.Name = "label2";
            label2.Size = new Size(230, 30);
            label2.TabIndex = 16;
            label2.Text = "Sudah punya akun?";
            label2.Click += label2_Click;
            // 
            // linklogin
            // 
            linklogin.AutoSize = true;
            linklogin.BackColor = Color.Transparent;
            linklogin.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linklogin.LinkColor = Color.Black;
            linklogin.Location = new Point(1340, 800);
            linklogin.Name = "linklogin";
            linklogin.Size = new Size(82, 30);
            linklogin.TabIndex = 17;
            linklogin.TabStop = true;
            linklogin.Text = "Login";
            linklogin.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tbemail
            // 
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbemail.Location = new Point(874, 425);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(841, 40);
            tbemail.TabIndex = 18;
            tbemail.TextChanged += tbemail_TextChanged;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpassword.Location = new Point(874, 575);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(797, 40);
            tbpassword.TabIndex = 19;
            tbpassword.TextChanged += tbpassword_TextChanged;
            // 
            // tbconfirmpass
            // 
            tbconfirmpass.BorderStyle = BorderStyle.None;
            tbconfirmpass.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbconfirmpass.Location = new Point(874, 724);
            tbconfirmpass.Name = "tbconfirmpass";
            tbconfirmpass.Size = new Size(797, 40);
            tbconfirmpass.TabIndex = 20;
            tbconfirmpass.TextChanged += tbconfirmpass_TextChanged;
            // 
            // checkshow1
            // 
            checkshow1.AutoSize = true;
            checkshow1.BackColor = Color.Transparent;
            checkshow1.Location = new Point(1699, 583);
            checkshow1.Name = "checkshow1";
            checkshow1.Size = new Size(67, 24);
            checkshow1.TabIndex = 24;
            checkshow1.Text = "Show";
            checkshow1.UseVisualStyleBackColor = false;
            checkshow1.CheckedChanged += checkshow1_CheckedChanged;
            // 
            // checkshow2
            // 
            checkshow2.AutoSize = true;
            checkshow2.BackColor = Color.Transparent;
            checkshow2.Location = new Point(1699, 733);
            checkshow2.Name = "checkshow2";
            checkshow2.Size = new Size(67, 24);
            checkshow2.TabIndex = 25;
            checkshow2.Text = "Show";
            checkshow2.UseVisualStyleBackColor = false;
            checkshow2.CheckedChanged += checkshow2_CheckedChanged;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1902, 1033);
            Controls.Add(checkshow2);
            Controls.Add(checkshow1);
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
            ForeColor = SystemColors.ControlLightLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "register";
            Text = "Register";
            Load += register_Load;
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
        private Button btnshow1;
        private Button btnshow2;
        private CheckBox checkshow1;
        private CheckBox checkshow2;
    }
}
