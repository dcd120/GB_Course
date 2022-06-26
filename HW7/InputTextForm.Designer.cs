namespace HW7
{
    partial class InputTextForm
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
            this.myN = new System.Windows.Forms.TextBox();
            this.myOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myN
            // 
            this.myN.Location = new System.Drawing.Point(22, 19);
            this.myN.Margin = new System.Windows.Forms.Padding(5);
            this.myN.Name = "myN";
            this.myN.Size = new System.Drawing.Size(346, 34);
            this.myN.TabIndex = 0;
            // 
            // myOk
            // 
            this.myOk.Location = new System.Drawing.Point(377, 19);
            this.myOk.Name = "myOk";
            this.myOk.Size = new System.Drawing.Size(210, 34);
            this.myOk.TabIndex = 1;
            this.myOk.Text = "Мне повезет!";
            this.myOk.UseVisualStyleBackColor = true;
            this.myOk.Click += new System.EventHandler(this.myOk_Click);
            // 
            // InputTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 67);
            this.Controls.Add(this.myOk);
            this.Controls.Add(this.myN);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(617, 114);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(617, 114);
            this.Name = "InputTextForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введите число:";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox myN;
        private System.Windows.Forms.Button myOk;
    }
}