namespace projectakhirpbo
{
    partial class Form1
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
            tbusername = new TextBox();
            tbpass = new TextBox();
            tbpassvalid = new TextBox();
            tbemail = new TextBox();
            tbtelepon = new TextBox();
            btregistrasi = new Button();
            btlogin = new Button();
            lblresto = new Label();
            lbusername = new Label();
            lbpassword = new Label();
            lbpassvalid = new Label();
            lbemail = new Label();
            lbtelepon = new Label();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            SuspendLayout();
            // 
            // tbusername
            // 
            tbusername.Location = new Point(249, 170);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(341, 27);
            tbusername.TabIndex = 0;
            // 
            // tbpass
            // 
            tbpass.Location = new Point(249, 249);
            tbpass.Name = "tbpass";
            tbpass.Size = new Size(341, 27);
            tbpass.TabIndex = 1;
            // 
            // tbpassvalid
            // 
            tbpassvalid.Location = new Point(249, 329);
            tbpassvalid.Name = "tbpassvalid";
            tbpassvalid.Size = new Size(341, 27);
            tbpassvalid.TabIndex = 2;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(695, 209);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(341, 27);
            tbemail.TabIndex = 3;
            // 
            // tbtelepon
            // 
            tbtelepon.Location = new Point(695, 295);
            tbtelepon.Name = "tbtelepon";
            tbtelepon.Size = new Size(341, 27);
            tbtelepon.TabIndex = 4;
            // 
            // btregistrasi
            // 
            btregistrasi.Location = new Point(547, 409);
            btregistrasi.Name = "btregistrasi";
            btregistrasi.Size = new Size(147, 29);
            btregistrasi.TabIndex = 5;
            btregistrasi.Text = "REGISTRASI";
            btregistrasi.UseVisualStyleBackColor = true;
            // 
            // btlogin
            // 
            btlogin.Location = new Point(1125, 463);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(108, 29);
            btlogin.TabIndex = 6;
            btlogin.Text = "LOGIN =>";
            btlogin.UseVisualStyleBackColor = true;
            // 
            // lblresto
            // 
            lblresto.AutoSize = true;
            lblresto.BackColor = Color.Transparent;
            lblresto.Font = new Font("SimSun-ExtB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblresto.ForeColor = SystemColors.ButtonHighlight;
            lblresto.Location = new Point(404, 61);
            lblresto.Name = "lblresto";
            lblresto.Size = new Size(497, 37);
            lblresto.TabIndex = 7;
            lblresto.Text = "Reservasi Restoran Kucay";
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.BackColor = Color.Transparent;
            lbusername.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbusername.ForeColor = Color.Cornsilk;
            lbusername.Location = new Point(489, 149);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(101, 18);
            lbusername.TabIndex = 8;
            lbusername.Text = "USERNAME";
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.BackColor = Color.Transparent;
            lbpassword.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbpassword.ForeColor = Color.Cornsilk;
            lbpassword.Location = new Point(414, 228);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(176, 18);
            lbpassword.TabIndex = 9;
            lbpassword.Text = "CREATE PASSWORD";
            // 
            // lbpassvalid
            // 
            lbpassvalid.AutoSize = true;
            lbpassvalid.Location = new Point(380, 301);
            lbpassvalid.Name = "lbpassvalid";
            lbpassvalid.Size = new Size(210, 20);
            lbpassvalid.TabIndex = 10;
            lbpassvalid.Text = "TYPE AGAIN SLUR PASSWORD";
            // 
            // lbemail
            // 
            lbemail.AutoSize = true;
            lbemail.Location = new Point(695, 173);
            lbemail.Name = "lbemail";
            lbemail.Size = new Size(51, 20);
            lbemail.TabIndex = 11;
            lbemail.Text = "EMAIL";
            // 
            // lbtelepon
            // 
            lbtelepon.AutoSize = true;
            lbtelepon.Location = new Point(695, 262);
            lbtelepon.Name = "lbtelepon";
            lbtelepon.Size = new Size(89, 20);
            lbtelepon.TabIndex = 12;
            lbtelepon.Text = "TELEPHONE";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "afif 10 pax", "afif 5 pax", "jaki", "mario" });
            checkedListBox1.Location = new Point(110, 79);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 13;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "afif 10 pax", "afif 5 pax", "jaki", "mario" });
            checkedListBox2.Location = new Point(380, 149);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(150, 114);
            checkedListBox2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Cuplikan_layar_2025_05_19_025439;
            ClientSize = new Size(1257, 517);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(lbtelepon);
            Controls.Add(lbemail);
            Controls.Add(lbpassvalid);
            Controls.Add(lbpassword);
            Controls.Add(lbusername);
            Controls.Add(lblresto);
            Controls.Add(btlogin);
            Controls.Add(btregistrasi);
            Controls.Add(tbtelepon);
            Controls.Add(tbemail);
            Controls.Add(tbpassvalid);
            Controls.Add(tbpass);
            Controls.Add(tbusername);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbusername;
        private TextBox tbpass;
        private TextBox tbpassvalid;
        private TextBox tbemail;
        private TextBox tbtelepon;
        private Button btregistrasi;
        private Button btlogin;
        private Label lblresto;
        private Label lbusername;
        private Label lbpassword;
        private Label lbpassvalid;
        private Label lbemail;
        private Label lbtelepon;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
    }
}
