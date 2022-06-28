namespace HW8
{
    partial class GameForm
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
            this.NewGameBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleLBL = new System.Windows.Forms.Label();
            this.DescLBL = new System.Windows.Forms.Label();
            this.Sel_0 = new System.Windows.Forms.Button();
            this.Sel_1 = new System.Windows.Forms.Button();
            this.Sel_2 = new System.Windows.Forms.Button();
            this.Sel_3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewGameBTN
            // 
            this.NewGameBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.NewGameBTN.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGameBTN.Location = new System.Drawing.Point(11, 10);
            this.NewGameBTN.Name = "NewGameBTN";
            this.NewGameBTN.Size = new System.Drawing.Size(348, 40);
            this.NewGameBTN.TabIndex = 0;
            this.NewGameBTN.Text = "Начать новую игру";
            this.NewGameBTN.UseVisualStyleBackColor = false;
            this.NewGameBTN.Click += new System.EventHandler(this.NewGameBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBTN.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBTN.Location = new System.Drawing.Point(672, 10);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(348, 40);
            this.ExitBTN.TabIndex = 0;
            this.ExitBTN.Text = "Выход";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(365, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество очков: 00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Sel_3);
            this.panel1.Controls.Add(this.Sel_2);
            this.panel1.Controls.Add(this.Sel_1);
            this.panel1.Controls.Add(this.Sel_0);
            this.panel1.Controls.Add(this.DescLBL);
            this.panel1.Controls.Add(this.TitleLBL);
            this.panel1.Location = new System.Drawing.Point(11, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 481);
            this.panel1.TabIndex = 2;
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLBL.Location = new System.Drawing.Point(4, 4);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(73, 25);
            this.TitleLBL.TabIndex = 0;
            this.TitleLBL.Text = "Тема:";
            // 
            // DescLBL
            // 
            this.DescLBL.AutoSize = true;
            this.DescLBL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescLBL.Location = new System.Drawing.Point(5, 39);
            this.DescLBL.Name = "DescLBL";
            this.DescLBL.Size = new System.Drawing.Size(81, 23);
            this.DescLBL.TabIndex = 0;
            this.DescLBL.Text = "Вопрос:";
            // 
            // Sel_0
            // 
            this.Sel_0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Sel_0.Enabled = false;
            this.Sel_0.Location = new System.Drawing.Point(9, 285);
            this.Sel_0.Name = "Sel_0";
            this.Sel_0.Size = new System.Drawing.Size(500, 80);
            this.Sel_0.TabIndex = 1;
            this.Sel_0.Text = "A";
            this.Sel_0.UseVisualStyleBackColor = false;
            this.Sel_0.Click += new System.EventHandler(this.Sel_0_Click);
            // 
            // Sel_1
            // 
            this.Sel_1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Sel_1.Enabled = false;
            this.Sel_1.Location = new System.Drawing.Point(509, 285);
            this.Sel_1.Name = "Sel_1";
            this.Sel_1.Size = new System.Drawing.Size(500, 80);
            this.Sel_1.TabIndex = 1;
            this.Sel_1.Text = "B";
            this.Sel_1.UseVisualStyleBackColor = false;
            this.Sel_1.Click += new System.EventHandler(this.Sel_1_Click);
            // 
            // Sel_2
            // 
            this.Sel_2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Sel_2.Enabled = false;
            this.Sel_2.Location = new System.Drawing.Point(9, 380);
            this.Sel_2.Name = "Sel_2";
            this.Sel_2.Size = new System.Drawing.Size(500, 80);
            this.Sel_2.TabIndex = 1;
            this.Sel_2.Text = "C";
            this.Sel_2.UseVisualStyleBackColor = false;
            this.Sel_2.Click += new System.EventHandler(this.Sel_2_Click);
            // 
            // Sel_3
            // 
            this.Sel_3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Sel_3.Enabled = false;
            this.Sel_3.Location = new System.Drawing.Point(509, 380);
            this.Sel_3.Name = "Sel_3";
            this.Sel_3.Size = new System.Drawing.Size(500, 80);
            this.Sel_3.TabIndex = 1;
            this.Sel_3.Text = "D";
            this.Sel_3.UseVisualStyleBackColor = false;
            this.Sel_3.Click += new System.EventHandler(this.Sel_3_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.NewGameBTN);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "GameForm";
            this.Text = "\"Кто хочет стать миллионером?\"";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Sel_3;
        private System.Windows.Forms.Button Sel_2;
        private System.Windows.Forms.Button Sel_1;
        private System.Windows.Forms.Button Sel_0;
        private System.Windows.Forms.Label DescLBL;
        private System.Windows.Forms.Label TitleLBL;
    }
}