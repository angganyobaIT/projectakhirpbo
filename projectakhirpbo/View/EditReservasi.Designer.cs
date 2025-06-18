namespace projectakhirpbo.View
{
    partial class EditReservasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReservasi));
            cb_pilihanruangan = new ComboBox();
            lanjutkan = new Button();
            reserv_time = new ComboBox();
            jumlah_orang = new NumericUpDown();
            tb_telp_customer = new TextBox();
            tb_namacustomer = new TextBox();
            reserv_date = new DateTimePicker();
            btnback = new Button();
            ((System.ComponentModel.ISupportInitialize)jumlah_orang).BeginInit();
            SuspendLayout();
            // 
            // cb_pilihanruangan
            // 
            cb_pilihanruangan.FormattingEnabled = true;
            cb_pilihanruangan.Items.AddRange(new object[] { "Indoor", "Outdoor" });
            cb_pilihanruangan.Location = new Point(144, 939);
            cb_pilihanruangan.Name = "cb_pilihanruangan";
            cb_pilihanruangan.Size = new Size(463, 23);
            cb_pilihanruangan.TabIndex = 40;
            // 
            // lanjutkan
            // 
            lanjutkan.BackColor = Color.White;
            lanjutkan.BackgroundImage = (Image)resources.GetObject("lanjutkan.BackgroundImage");
            lanjutkan.BackgroundImageLayout = ImageLayout.Stretch;
            lanjutkan.FlatStyle = FlatStyle.Popup;
            lanjutkan.Location = new Point(837, 857);
            lanjutkan.Name = "lanjutkan";
            lanjutkan.Size = new Size(947, 80);
            lanjutkan.TabIndex = 39;
            lanjutkan.UseVisualStyleBackColor = false;
            lanjutkan.Click += lanjutkan_Click;
            // 
            // reserv_time
            // 
            reserv_time.BackColor = Color.White;
            reserv_time.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reserv_time.FormattingEnabled = true;
            reserv_time.Items.AddRange(new object[] { "08:00", "10:00", "12:00", "14:00", "16:00", "17:00", "19:00" });
            reserv_time.Location = new Point(866, 324);
            reserv_time.Name = "reserv_time";
            reserv_time.Size = new Size(881, 35);
            reserv_time.TabIndex = 38;
            // 
            // jumlah_orang
            // 
            jumlah_orang.BorderStyle = BorderStyle.None;
            jumlah_orang.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jumlah_orang.ForeColor = Color.Black;
            jumlah_orang.Location = new Point(868, 730);
            jumlah_orang.Name = "jumlah_orang";
            jumlah_orang.Size = new Size(881, 18);
            jumlah_orang.TabIndex = 37;
            jumlah_orang.TextAlign = HorizontalAlignment.Center;
            jumlah_orang.UpDownAlign = LeftRightAlignment.Left;
            // 
            // tb_telp_customer
            // 
            tb_telp_customer.BorderStyle = BorderStyle.None;
            tb_telp_customer.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_telp_customer.Location = new Point(866, 587);
            tb_telp_customer.Name = "tb_telp_customer";
            tb_telp_customer.Size = new Size(881, 32);
            tb_telp_customer.TabIndex = 36;
            // 
            // tb_namacustomer
            // 
            tb_namacustomer.BorderStyle = BorderStyle.None;
            tb_namacustomer.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_namacustomer.Location = new Point(868, 456);
            tb_namacustomer.Name = "tb_namacustomer";
            tb_namacustomer.Size = new Size(881, 27);
            tb_namacustomer.TabIndex = 35;
            // 
            // reserv_date
            // 
            reserv_date.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            reserv_date.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reserv_date.Location = new Point(866, 198);
            reserv_date.Name = "reserv_date";
            reserv_date.RightToLeft = RightToLeft.Yes;
            reserv_date.Size = new Size(881, 22);
            reserv_date.TabIndex = 34;
            // 
            // btnback
            // 
            btnback.BackColor = Color.Transparent;
            btnback.BackgroundImage = (Image)resources.GetObject("btnback.BackgroundImage");
            btnback.BackgroundImageLayout = ImageLayout.Stretch;
            btnback.FlatStyle = FlatStyle.Popup;
            btnback.ForeColor = Color.Transparent;
            btnback.Location = new Point(38, 949);
            btnback.Name = "btnback";
            btnback.Size = new Size(41, 37);
            btnback.TabIndex = 33;
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // EditReservasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(cb_pilihanruangan);
            Controls.Add(lanjutkan);
            Controls.Add(reserv_time);
            Controls.Add(jumlah_orang);
            Controls.Add(tb_telp_customer);
            Controls.Add(tb_namacustomer);
            Controls.Add(reserv_date);
            Controls.Add(btnback);
            DoubleBuffered = true;
            Name = "EditReservasi";
            Text = "EditReservasi";
            Load += EditReservasi_Load;
            ((System.ComponentModel.ISupportInitialize)jumlah_orang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_pilihanruangan;
        private Button lanjutkan;
        private ComboBox reserv_time;
        private NumericUpDown jumlah_orang;
        private TextBox tb_telp_customer;
        private TextBox tb_namacustomer;
        private DateTimePicker reserv_date;
        private Button btnback;
    }
}