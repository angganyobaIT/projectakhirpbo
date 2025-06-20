namespace projectakhirpbo.View
{
    partial class HomepageAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageAdmin));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            LB_Jumlah_resv = new Label();
            LB_admin_nama = new Label();
            LB_jumlah_Menu = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(93, 160);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(32, 28);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(91, 272);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(33, 32);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(91, 352);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(37, 31);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(93, 657);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(35, 29);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // LB_Jumlah_resv
            // 
            LB_Jumlah_resv.AutoSize = true;
            LB_Jumlah_resv.BackColor = Color.Transparent;
            LB_Jumlah_resv.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LB_Jumlah_resv.ForeColor = Color.White;
            LB_Jumlah_resv.Location = new Point(540, 149);
            LB_Jumlah_resv.Name = "LB_Jumlah_resv";
            LB_Jumlah_resv.Size = new Size(87, 58);
            LB_Jumlah_resv.TabIndex = 5;
            LB_Jumlah_resv.Text = "10";
            // 
            // LB_admin_nama
            // 
            LB_admin_nama.AutoSize = true;
            LB_admin_nama.BackColor = Color.Transparent;
            LB_admin_nama.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_admin_nama.Location = new Point(340, 342);
            LB_admin_nama.Name = "LB_admin_nama";
            LB_admin_nama.Size = new Size(51, 19);
            LB_admin_nama.TabIndex = 6;
            LB_admin_nama.Text = "label1";
            // 
            // LB_jumlah_Menu
            // 
            LB_jumlah_Menu.AutoSize = true;
            LB_jumlah_Menu.BackColor = Color.Transparent;
            LB_jumlah_Menu.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LB_jumlah_Menu.ForeColor = Color.White;
            LB_jumlah_Menu.Location = new Point(1259, 135);
            LB_jumlah_Menu.Name = "LB_jumlah_Menu";
            LB_jumlah_Menu.Size = new Size(87, 58);
            LB_jumlah_Menu.TabIndex = 7;
            LB_jumlah_Menu.Text = "10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1035, 340);
            label1.Name = "label1";
            label1.Size = new Size(265, 23);
            label1.TabIndex = 8;
            label1.Text = "Cabang Kabupaten Jember";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(299, 419);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1298, 331);
            dataGridView1.TabIndex = 9;
            // 
            // HomepageAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1664, 775);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(LB_jumlah_Menu);
            Controls.Add(LB_admin_nama);
            Controls.Add(LB_Jumlah_resv);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomepageAdmin";
            Text = "HomepageAdmin";
            Load += HomepageAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Label LB_Jumlah_resv;
        private Label LB_admin_nama;
        private Label LB_jumlah_Menu;
        private Label label1;
        private DataGridView dataGridView1;
    }
}