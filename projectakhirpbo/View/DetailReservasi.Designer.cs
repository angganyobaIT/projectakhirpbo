namespace projectakhirpbo.View
{
    partial class DetailReservasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailReservasi));
            dataGridView1 = new DataGridView();
            LB_total = new Label();
            btnkembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 110);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(355, 234);
            dataGridView1.TabIndex = 0;
            // 
            // LB_total
            // 
            LB_total.AutoSize = true;
            LB_total.BackColor = Color.White;
            LB_total.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LB_total.ForeColor = Color.FromArgb(64, 64, 64);
            LB_total.Location = new Point(34, 400);
            LB_total.Name = "LB_total";
            LB_total.Size = new Size(59, 19);
            LB_total.TabIndex = 1;
            LB_total.Text = "label1";
            // 
            // btnkembali
            // 
            btnkembali.BackColor = Color.White;
            btnkembali.BackgroundImage = (Image)resources.GetObject("btnkembali.BackgroundImage");
            btnkembali.BackgroundImageLayout = ImageLayout.Stretch;
            btnkembali.FlatAppearance.BorderSize = 0;
            btnkembali.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnkembali.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnkembali.FlatStyle = FlatStyle.Flat;
            btnkembali.Location = new Point(20, 475);
            btnkembali.Margin = new Padding(3, 2, 3, 2);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(29, 26);
            btnkembali.TabIndex = 2;
            btnkembali.UseVisualStyleBackColor = false;
            btnkembali.Click += btnkembali_Click;
            // 
            // DetailReservasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(440, 518);
            Controls.Add(btnkembali);
            Controls.Add(LB_total);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DetailReservasi";
            Text = "DetailReservasi";
            Load += DetailReservasi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label LB_total;
        private Button btnkembali;
    }
}