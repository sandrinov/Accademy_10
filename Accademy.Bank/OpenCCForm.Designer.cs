namespace Accademy.Bank
{
    partial class OpenCCForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_manageCC = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPEN CC";
            // 
            // btn_manageCC
            // 
            this.btn_manageCC.Location = new System.Drawing.Point(84, 176);
            this.btn_manageCC.Name = "btn_manageCC";
            this.btn_manageCC.Size = new System.Drawing.Size(75, 23);
            this.btn_manageCC.TabIndex = 1;
            this.btn_manageCC.Text = "Manage CC";
            this.btn_manageCC.UseVisualStyleBackColor = true;
            this.btn_manageCC.Click += new System.EventHandler(this.btn_manageCC_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(277, 253);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // OpenCCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 288);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_manageCC);
            this.Controls.Add(this.label1);
            this.Name = "OpenCCForm";
            this.Text = "OpenCCForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_manageCC;
        private System.Windows.Forms.Button btn_close;
    }
}