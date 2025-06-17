namespace projectakhirpbo.View
{
    partial class UbahMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbahMenu));
            btnmasuk = new Button();
            TB_nama_makanan = new TextBox();
            TB_Harga = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnmasuk
            // 
            btnmasuk.BackgroundImage = (Image)resources.GetObject("btnmasuk.BackgroundImage");
            btnmasuk.BackgroundImageLayout = ImageLayout.Stretch;
            btnmasuk.Location = new Point(17, 394);
            btnmasuk.Name = "btnmasuk";
            btnmasuk.Size = new Size(340, 50);
            btnmasuk.TabIndex = 0;
            btnmasuk.UseVisualStyleBackColor = true;
            btnmasuk.Click += btnmasuk_Click;
            // 
            // TB_nama_makanan
            // 
            TB_nama_makanan.BorderStyle = BorderStyle.None;
            TB_nama_makanan.Location = new Point(41, 132);
            TB_nama_makanan.Name = "TB_nama_makanan";
            TB_nama_makanan.Size = new Size(298, 20);
            TB_nama_makanan.TabIndex = 1;
            // 
            // TB_Harga
            // 
            TB_Harga.BorderStyle = BorderStyle.None;
            TB_Harga.Location = new Point(41, 190);
            TB_Harga.Name = "TB_Harga";
            TB_Harga.Size = new Size(298, 20);
            TB_Harga.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(41, 244);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(298, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // UbahMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(375, 463);
            Controls.Add(comboBox1);
            Controls.Add(TB_Harga);
            Controls.Add(TB_nama_makanan);
            Controls.Add(btnmasuk);
            DoubleBuffered = true;
            Name = "UbahMenu";
            Text = "UbahMenu";
            Load += UbahMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnmasuk;
        private TextBox TB_nama_makanan;
        private TextBox TB_Harga;
        private ComboBox comboBox1;
    }
}