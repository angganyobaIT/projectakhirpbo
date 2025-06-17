namespace projectakhirpbo.View
{
    partial class historireservasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historireservasi));
            homepagebtn = new Button();
            button2 = new Button();
            logoutbtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // homepagebtn
            // 
            homepagebtn.BackgroundImage = (Image)resources.GetObject("homepagebtn.BackgroundImage");
            homepagebtn.BackgroundImageLayout = ImageLayout.Stretch;
            homepagebtn.Location = new Point(101, 270);
            homepagebtn.Name = "homepagebtn";
            homepagebtn.Size = new Size(39, 39);
            homepagebtn.TabIndex = 0;
            homepagebtn.UseVisualStyleBackColor = true;
            homepagebtn.Click += homepagebtn_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(105, 419);
            button2.Name = "button2";
            button2.Size = new Size(34, 37);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // logoutbtn
            // 
            logoutbtn.BackgroundImage = (Image)resources.GetObject("logoutbtn.BackgroundImage");
            logoutbtn.BackgroundImageLayout = ImageLayout.Stretch;
            logoutbtn.Location = new Point(105, 898);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(42, 43);
            logoutbtn.TabIndex = 2;
            logoutbtn.UseVisualStyleBackColor = true;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(392, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1354, 611);
            dataGridView1.TabIndex = 3;
            // 
            // historireservasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dataGridView1);
            Controls.Add(logoutbtn);
            Controls.Add(button2);
            Controls.Add(homepagebtn);
            DoubleBuffered = true;
            Name = "historireservasi";
            Text = "historireservasi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button homepagebtn;
        private Button button2;
        private Button logoutbtn;
        private DataGridView dataGridView1;
    }
}