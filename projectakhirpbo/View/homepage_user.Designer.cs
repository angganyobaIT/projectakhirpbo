namespace projectakhirpbo.View
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            btnreservasi = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnallmenu = new Button();
            btnmakanan = new Button();
            btncemilan = new Button();
            btnminuman = new Button();
            SuspendLayout();
            // 
            // btnreservasi
            // 
            btnreservasi.BackColor = Color.Transparent;
            btnreservasi.BackgroundImage = (Image)resources.GetObject("btnreservasi.BackgroundImage");
            btnreservasi.BackgroundImageLayout = ImageLayout.Stretch;
            btnreservasi.FlatStyle = FlatStyle.Popup;
            btnreservasi.ForeColor = Color.Transparent;
            btnreservasi.ImageAlign = ContentAlignment.TopRight;
            btnreservasi.Location = new Point(495, 483);
            btnreservasi.Margin = new Padding(0);
            btnreservasi.Name = "btnreservasi";
            btnreservasi.Size = new Size(360, 87);
            btnreservasi.TabIndex = 0;
            btnreservasi.TextImageRelation = TextImageRelation.TextAboveImage;
            btnreservasi.UseVisualStyleBackColor = false;
            btnreservasi.Click += btnreservasi_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(131, 258);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(131, 370);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(131, 483);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(126, 904);
            button4.Name = "button4";
            button4.Size = new Size(45, 45);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnallmenu
            // 
            btnallmenu.BackgroundImage = (Image)resources.GetObject("btnallmenu.BackgroundImage");
            btnallmenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnallmenu.Location = new Point(376, 731);
            btnallmenu.Name = "btnallmenu";
            btnallmenu.Size = new Size(171, 187);
            btnallmenu.TabIndex = 5;
            btnallmenu.UseVisualStyleBackColor = true;
            // 
            // btnmakanan
            // 
            btnmakanan.BackgroundImage = (Image)resources.GetObject("btnmakanan.BackgroundImage");
            btnmakanan.BackgroundImageLayout = ImageLayout.Stretch;
            btnmakanan.Location = new Point(672, 731);
            btnmakanan.Name = "btnmakanan";
            btnmakanan.Size = new Size(171, 187);
            btnmakanan.TabIndex = 6;
            btnmakanan.UseVisualStyleBackColor = true;
            // 
            // btncemilan
            // 
            btncemilan.BackgroundImage = (Image)resources.GetObject("btncemilan.BackgroundImage");
            btncemilan.BackgroundImageLayout = ImageLayout.Stretch;
            btncemilan.Location = new Point(1255, 731);
            btncemilan.Name = "btncemilan";
            btncemilan.Size = new Size(171, 187);
            btncemilan.TabIndex = 7;
            btncemilan.UseVisualStyleBackColor = true;
            // 
            // btnminuman
            // 
            btnminuman.BackgroundImage = (Image)resources.GetObject("btnminuman.BackgroundImage");
            btnminuman.BackgroundImageLayout = ImageLayout.Stretch;
            btnminuman.Location = new Point(958, 731);
            btnminuman.Name = "btnminuman";
            btnminuman.Size = new Size(171, 187);
            btnminuman.TabIndex = 8;
            btnminuman.UseVisualStyleBackColor = true;
            btnminuman.Click += button8_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnminuman);
            Controls.Add(btncemilan);
            Controls.Add(btnmakanan);
            Controls.Add(btnallmenu);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnreservasi);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Homepage";
            Text = "Homepage";
            Load += Homepage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnreservasi;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnallmenu;
        private Button btnmakanan;
        private Button btncemilan;
        private Button btnminuman;
    }
}