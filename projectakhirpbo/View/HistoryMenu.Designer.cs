namespace projectakhirpbo.View
{
    partial class HistoryMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryMenu));
            dataGridView1 = new DataGridView();
            btnkembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(291, 207);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnkembali
            // 
            btnkembali.BackgroundImage = (Image)resources.GetObject("btnkembali.BackgroundImage");
            btnkembali.BackgroundImageLayout = ImageLayout.Stretch;
            btnkembali.Location = new Point(32, 411);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(31, 27);
            btnkembali.TabIndex = 1;
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // HistoryMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(375, 463);
            Controls.Add(btnkembali);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "HistoryMenu";
            Text = "HistoryMenu";
            Load += HistoryMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnkembali;
    }
}