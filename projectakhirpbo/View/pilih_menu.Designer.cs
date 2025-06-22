namespace projectakhirpbo.View
{
    partial class pilih_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pilih_menu));
            button1 = new Button();
            lblTotal = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            dgrid_viewmenu = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgrid_viewmenu).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(45, 706);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(39, 28);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.White;
            lblTotal.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(1181, 86);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 19);
            lblTotal.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1168, 207);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(438, 255);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(1146, 539);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(481, 52);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dgrid_viewmenu
            // 
            dgrid_viewmenu.AllowDrop = true;
            dgrid_viewmenu.AllowUserToAddRows = false;
            dgrid_viewmenu.AllowUserToDeleteRows = false;
            dgrid_viewmenu.AllowUserToResizeColumns = false;
            dgrid_viewmenu.AllowUserToResizeRows = false;
            dgrid_viewmenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrid_viewmenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgrid_viewmenu.BackgroundColor = Color.White;
            dgrid_viewmenu.BorderStyle = BorderStyle.Fixed3D;
            dgrid_viewmenu.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgrid_viewmenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrid_viewmenu.GridColor = Color.Black;
            dgrid_viewmenu.Location = new Point(45, 271);
            dgrid_viewmenu.Margin = new Padding(3, 2, 3, 2);
            dgrid_viewmenu.Name = "dgrid_viewmenu";
            dgrid_viewmenu.RowHeadersWidth = 51;
            dgrid_viewmenu.Size = new Size(993, 384);
            dgrid_viewmenu.TabIndex = 4;
            dgrid_viewmenu.CellContentClick += dgrid_viewmenu_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1173, 85);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // pilih_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1664, 775);
            Controls.Add(label1);
            Controls.Add(dgrid_viewmenu);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(lblTotal);
            Controls.Add(button1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "pilih_menu";
            Text = "pilih_menu";
            Load += pilih_menu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgrid_viewmenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblTotal;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridView dgrid_viewmenu;
        private Label label1;
    }
}