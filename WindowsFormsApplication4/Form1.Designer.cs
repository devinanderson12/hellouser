namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.happy = new System.Windows.Forms.Button();
            this.lblClick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // happy
            // 
            this.happy.Location = new System.Drawing.Point(95, 78);
            this.happy.Name = "happy";
            this.happy.Size = new System.Drawing.Size(75, 23);
            this.happy.TabIndex = 1;
            this.happy.Text = "hello user";
            this.happy.UseVisualStyleBackColor = true;
            this.happy.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Location = new System.Drawing.Point(119, 62);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(0, 13);
            this.lblClick.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.happy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button happy;
        private System.Windows.Forms.Label lblClick;
    }
}

