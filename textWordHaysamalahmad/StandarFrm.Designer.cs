namespace textWordHaysamalahmad
{
    partial class StandarFrm
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
            this.devTextBox1 = new textWordHaysamalahmad.DevTextBox();
            this.SuspendLayout();
            // 
            // devTextBox1
            // 
            this.devTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.devTextBox1.IsSaved = false;
            this.devTextBox1.Location = new System.Drawing.Point(0, 0);
            this.devTextBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.devTextBox1.Multiline = true;
            this.devTextBox1.Name = "devTextBox1";
            this.devTextBox1.Size = new System.Drawing.Size(1824, 968);
            this.devTextBox1.TabIndex = 0;
            this.devTextBox1.Text = "document ";
            // 
            // StandarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 968);
            this.Controls.Add(this.devTextBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StandarFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "document ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevTextBox devTextBox1;
    }
}