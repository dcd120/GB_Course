namespace HW7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newGame = new System.Windows.Forms.Button();
            this.Plus1 = new System.Windows.Forms.Button();
            this.CrntNumber = new System.Windows.Forms.Label();
            this.usersNumber = new System.Windows.Forms.Label();
            this.Multi2 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.mySteps = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ng = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelStep = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.newGame, "newGame");
            this.newGame.Name = "newGame";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // Plus1
            // 
            resources.ApplyResources(this.Plus1, "Plus1");
            this.Plus1.Name = "Plus1";
            this.Plus1.UseVisualStyleBackColor = true;
            this.Plus1.Click += new System.EventHandler(this.Plus1_Click);
            // 
            // CrntNumber
            // 
            resources.ApplyResources(this.CrntNumber, "CrntNumber");
            this.CrntNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CrntNumber.Name = "CrntNumber";
            // 
            // usersNumber
            // 
            resources.ApplyResources(this.usersNumber, "usersNumber");
            this.usersNumber.Name = "usersNumber";
            // 
            // Multi2
            // 
            resources.ApplyResources(this.Multi2, "Multi2");
            this.Multi2.Name = "Multi2";
            this.Multi2.UseVisualStyleBackColor = true;
            this.Multi2.Click += new System.EventHandler(this.Multi2_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.GrayText;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.exit, "exit");
            this.exit.Name = "exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mySteps
            // 
            resources.ApplyResources(this.mySteps, "mySteps");
            this.mySteps.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mySteps.Name = "mySteps";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myMenu});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // myMenu
            // 
            this.myMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ng});
            this.myMenu.Name = "myMenu";
            resources.ApplyResources(this.myMenu, "myMenu");
            // 
            // ng
            // 
            this.ng.Name = "ng";
            resources.ApplyResources(this.ng, "ng");
            this.ng.Click += new System.EventHandler(this.ng_Click);
            // 
            // cancelStep
            // 
            this.cancelStep.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cancelStep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.cancelStep, "cancelStep");
            this.cancelStep.Name = "cancelStep";
            this.cancelStep.UseVisualStyleBackColor = false;
            this.cancelStep.Click += new System.EventHandler(this.cancelStep_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usersNumber);
            this.Controls.Add(this.mySteps);
            this.Controls.Add(this.CrntNumber);
            this.Controls.Add(this.Multi2);
            this.Controls.Add(this.Plus1);
            this.Controls.Add(this.cancelStep);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button Plus1;
        private System.Windows.Forms.Label CrntNumber;
        private System.Windows.Forms.Label usersNumber;
        private System.Windows.Forms.Button Multi2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label mySteps;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myMenu;
        private System.Windows.Forms.ToolStripMenuItem ng;
        private System.Windows.Forms.Button cancelStep;
    }
}

