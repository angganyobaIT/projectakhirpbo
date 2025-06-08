namespace projectakhirpbo.View
{
    partial class reservasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservasi));
            btnback = new Button();
            dateTimePicker1 = new DateTimePicker();
            tb_namacustomer = new TextBox();
            no_telp_customer = new TextBox();
            jumlah_orang = new NumericUpDown();
            reserv_time = new ComboBox();
            lanjutkan = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)jumlah_orang).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.BackColor = Color.Transparent;
            btnback.BackgroundImage = (Image)resources.GetObject("btnback.BackgroundImage");
            btnback.BackgroundImageLayout = ImageLayout.Stretch;
            btnback.FlatStyle = FlatStyle.Popup;
            btnback.ForeColor = Color.Transparent;
            btnback.Location = new Point(36, 942);
            btnback.Name = "btnback";
            btnback.Size = new Size(41, 37);
            btnback.TabIndex = 10;
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(864, 191);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.Yes;
            dateTimePicker1.Size = new Size(881, 27);
            dateTimePicker1.TabIndex = 24;
            // 
            // tb_namacustomer
            // 
            tb_namacustomer.Location = new Point(864, 458);
            tb_namacustomer.Name = "tb_namacustomer";
            tb_namacustomer.Size = new Size(881, 27);
            tb_namacustomer.TabIndex = 26;
            // 
            // no_telp_customer
            // 
            no_telp_customer.Location = new Point(864, 588);
            no_telp_customer.Name = "no_telp_customer";
            no_telp_customer.Size = new Size(881, 27);
            no_telp_customer.TabIndex = 27;
            // 
            // jumlah_orang
            // 
            jumlah_orang.BorderStyle = BorderStyle.None;
            jumlah_orang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jumlah_orang.ForeColor = Color.Black;
            jumlah_orang.Location = new Point(864, 721);
            jumlah_orang.Name = "jumlah_orang";
            jumlah_orang.Size = new Size(881, 23);
            jumlah_orang.TabIndex = 28;
            jumlah_orang.TextAlign = HorizontalAlignment.Center;
            jumlah_orang.UpDownAlign = LeftRightAlignment.Left;
            // 
            // reserv_time
            // 
            reserv_time.BackColor = Color.White;
            reserv_time.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reserv_time.FormattingEnabled = true;
            reserv_time.Items.AddRange(new object[] { "08:00", "10:00", "12:00", "14:00", "16:00", "17:00", "19:00" });
            reserv_time.Location = new Point(864, 324);
            reserv_time.Name = "reserv_time";
            reserv_time.Size = new Size(881, 26);
            reserv_time.TabIndex = 29;
            // 
            // lanjutkan
            // 
            lanjutkan.BackColor = Color.White;
            lanjutkan.BackgroundImage = (Image)resources.GetObject("lanjutkan.BackgroundImage");
            lanjutkan.BackgroundImageLayout = ImageLayout.Stretch;
            lanjutkan.FlatStyle = FlatStyle.Popup;
            lanjutkan.Location = new Point(835, 850);
            lanjutkan.Name = "lanjutkan";
            lanjutkan.Size = new Size(947, 80);
            lanjutkan.TabIndex = 30;
            lanjutkan.UseVisualStyleBackColor = false;
            lanjutkan.Click += lanjutkan_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Indoor", "Outdoor" });
            comboBox1.Location = new Point(141, 942);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(463, 28);
            comboBox1.TabIndex = 32;
            // 
            // reservasi
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(comboBox1);
            Controls.Add(lanjutkan);
            Controls.Add(reserv_time);
            Controls.Add(jumlah_orang);
            Controls.Add(no_telp_customer);
            Controls.Add(tb_namacustomer);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnback);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "reservasi";
            Text = "reservasi";
            Load += reservasi_Load;
            ((System.ComponentModel.ISupportInitialize)jumlah_orang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnback;
        private DateTimePicker dateTimePicker1;
        private TextBox tb_namacustomer;
        private TextBox no_telp_customer;
        private NumericUpDown jumlah_orang;
        private ComboBox reserv_time;
        private Button lanjutkan;
        private ComboBox comboBox1;
    }
}