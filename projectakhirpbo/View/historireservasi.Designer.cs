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
            homepagebtn.Location = new Point(88, 202);
            homepagebtn.Margin = new Padding(3, 2, 3, 2);
            homepagebtn.Name = "homepagebtn";
            homepagebtn.Size = new Size(34, 29);
            homepagebtn.TabIndex = 0;
            homepagebtn.UseVisualStyleBackColor = true;
            homepagebtn.Click += homepagebtn_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(92, 314);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(30, 28);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // logoutbtn
            // 
            logoutbtn.BackgroundImage = (Image)resources.GetObject("logoutbtn.BackgroundImage");
            logoutbtn.BackgroundImageLayout = ImageLayout.Stretch;
            logoutbtn.Location = new Point(92, 674);
            logoutbtn.Margin = new Padding(3, 2, 3, 2);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(37, 32);
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
            dataGridView1.Location = new Point(343, 236);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1185, 458);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // historireservasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1664, 775);
            Controls.Add(dataGridView1);
            Controls.Add(logoutbtn);
            Controls.Add(button2);
            Controls.Add(homepagebtn);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
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