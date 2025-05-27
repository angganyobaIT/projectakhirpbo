namespace projectakhirpbo
{
    partial class register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btlogin = new Button();
            SuspendLayout();
            // 
            // btlogin
            // 
            btlogin.Location = new Point(1125, 463);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(108, 29);
            btlogin.TabIndex = 6;
            btlogin.Text = "LOGIN =>";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += btlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Register;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1095, 618);
            Controls.Add(btlogin);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btlogin;
    }
}
