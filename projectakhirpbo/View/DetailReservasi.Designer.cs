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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(289, 197);
            dataGridView1.TabIndex = 0;
            // 
            // LB_total
            // 
            LB_total.AutoSize = true;
            LB_total.BackColor = Color.Transparent;
            LB_total.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_total.Location = new Point(34, 354);
            LB_total.Name = "LB_total";
            LB_total.Size = new Size(87, 34);
            LB_total.TabIndex = 1;
            LB_total.Text = "label1";
            // 
            // btnkembali
            // 
            btnkembali.BackgroundImage = (Image)resources.GetObject("btnkembali.BackgroundImage");
            btnkembali.BackgroundImageLayout = ImageLayout.Stretch;
            btnkembali.Location = new Point(12, 427);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(32, 24);
            btnkembali.TabIndex = 2;
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // DetailReservasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(375, 463);
            Controls.Add(btnkembali);
            Controls.Add(LB_total);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
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