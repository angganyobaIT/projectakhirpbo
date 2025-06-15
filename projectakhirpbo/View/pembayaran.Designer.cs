namespace projectakhirpbo.View
{
    partial class pembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pembayaran));
            button1 = new Button();
            label1 = new Label();
            lblTotalPembayaran = new Label();
            totallbl = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(24, 364);
            button1.Name = "button1";
            button1.Size = new Size(324, 46);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 237);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // lblTotalPembayaran
            // 
            lblTotalPembayaran.AutoSize = true;
            lblTotalPembayaran.Location = new Point(158, 225);
            lblTotalPembayaran.Name = "lblTotalPembayaran";
            lblTotalPembayaran.Size = new Size(0, 20);
            lblTotalPembayaran.TabIndex = 2;
            // 
            // totallbl
            // 
            totallbl.AutoSize = true;
            totallbl.Location = new Point(147, 225);
            totallbl.Name = "totallbl";
            totallbl.Size = new Size(50, 20);
            totallbl.TabIndex = 3;
            totallbl.Text = "label2";
            totallbl.Click += totallbl_Click;
            // 
            // pembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(374, 469);
            Controls.Add(totallbl);
            Controls.Add(lblTotalPembayaran);
            Controls.Add(label1);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "pembayaran";
            Text = "pembayaran";
            Load += pembayaran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label lblTotalPembayaran;
        private Label totallbl;
    }
}