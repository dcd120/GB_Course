namespace HW7
{
    partial class Form2
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
            this.joke = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plTxt = new System.Windows.Forms.TextBox();
            this.myStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joke
            // 
            this.joke.AutoSize = true;
            this.joke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.joke.Location = new System.Drawing.Point(12, 9);
            this.joke.Name = "joke";
            this.joke.Size = new System.Drawing.Size(422, 23);
            this.joke.TabIndex = 0;
            this.joke.Text = "Я загадал число от 1 до 100, попробуй угадай!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введи число:";
            // 
            // plTxt
            // 
            this.plTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plTxt.Location = new System.Drawing.Point(152, 49);
            this.plTxt.Name = "plTxt";
            this.plTxt.Size = new System.Drawing.Size(100, 30);
            this.plTxt.TabIndex = 1;
            this.plTxt.Text = "0";
            this.plTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // myStatus
            // 
            this.myStatus.AutoSize = true;
            this.myStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myStatus.Location = new System.Drawing.Point(12, 93);
            this.myStatus.Name = "myStatus";
            this.myStatus.Size = new System.Drawing.Size(69, 23);
            this.myStatus.TabIndex = 0;
            this.myStatus.Text = "( жду )";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(271, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Мне повезет!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 133);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myStatus);
            this.Controls.Add(this.joke);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(580, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(580, 180);
            this.Name = "Form2";
            this.Text = "Игра \"Угадай число!\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox plTxt;
        private System.Windows.Forms.Label myStatus;
        private System.Windows.Forms.Button button1;
    }
}