namespace projectakhirpbo.View
{
    partial class TambahMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahMenu));
            TB_nama_makanan = new TextBox();
            TB_Harga = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // TB_nama_makanan
            // 
            TB_nama_makanan.BorderStyle = BorderStyle.None;
            TB_nama_makanan.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_nama_makanan.Location = new Point(40, 133);
            TB_nama_makanan.Name = "TB_nama_makanan";
            TB_nama_makanan.Size = new Size(301, 19);
            TB_nama_makanan.TabIndex = 0;
            // 
            // TB_Harga
            // 
            TB_Harga.BorderStyle = BorderStyle.None;
            TB_Harga.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Harga.Location = new Point(40, 190);
            TB_Harga.Name = "TB_Harga";
            TB_Harga.Size = new Size(301, 19);
            TB_Harga.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(40, 243);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(301, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(147, 410);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "SIMPAN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(269, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "KEMBALI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TambahMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(375, 463);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(TB_Harga);
            Controls.Add(TB_nama_makanan);
            DoubleBuffered = true;
            Name = "TambahMenu";
            Text = "TambahMenu";
            Load += TambahMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_nama_makanan;
        private TextBox TB_Harga;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}