namespace projectakhirpbo.View
{
    partial class show_makanan
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
            dtgrid_showall = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgrid_showall).BeginInit();
            SuspendLayout();
            // 
            // dtgrid_showall
            // 
            dtgrid_showall.AllowUserToDeleteRows = false;
            dtgrid_showall.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgrid_showall.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgrid_showall.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrid_showall.Location = new Point(25, 21);
            dtgrid_showall.Name = "dtgrid_showall";
            dtgrid_showall.ReadOnly = true;
            dtgrid_showall.RowHeadersWidth = 51;
            dtgrid_showall.Size = new Size(1837, 541);
            dtgrid_showall.TabIndex = 1;
            // 
            // show_makanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dtgrid_showall);
            Name = "show_makanan";
            Text = "show_makanan";
            ((System.ComponentModel.ISupportInitialize)dtgrid_showall).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgrid_showall;
    }
}