namespace HW8
{
    partial class EditorForm
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
            this.ToolStripMenuItemEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.ToolStripMenuItemEM = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПоследнююЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripMenuItemEditor
            // 
            this.ToolStripMenuItemEditor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadMI,
            this.SaveMI,
            this.ExitMI});
            this.ToolStripMenuItemEditor.Name = "ToolStripMenuItemEditor";
            this.ToolStripMenuItemEditor.Size = new System.Drawing.Size(86, 24);
            this.ToolStripMenuItemEditor.Text = "Редактор";
            // 
            // LoadMI
            // 
            this.LoadMI.Name = "LoadMI";
            this.LoadMI.Size = new System.Drawing.Size(229, 26);
            this.LoadMI.Text = "Загрузить сборник";
            this.LoadMI.Click += new System.EventHandler(this.Load_Click);
            // 
            // SaveMI
            // 
            this.SaveMI.Name = "SaveMI";
            this.SaveMI.Size = new System.Drawing.Size(229, 26);
            this.SaveMI.Text = "Сохранить сборник";
            this.SaveMI.Click += new System.EventHandler(this.Save_Click);
            // 
            // ExitMI
            // 
            this.ExitMI.Name = "ExitMI";
            this.ExitMI.Size = new System.Drawing.Size(229, 26);
            this.ExitMI.Text = "Выход";
            this.ExitMI.Click += new System.EventHandler(this.Exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemEditor,
            this.ToolStripMenuItemEM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dGV
            // 
            this.dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(13, 32);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(787, 406);
            this.dGV.TabIndex = 1;
            // 
            // ToolStripMenuItemEM
            // 
            this.ToolStripMenuItemEM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьПоследнююЗаписьToolStripMenuItem});
            this.ToolStripMenuItemEM.Name = "ToolStripMenuItemEM";
            this.ToolStripMenuItemEM.Size = new System.Drawing.Size(74, 24);
            this.ToolStripMenuItemEM.Text = "Правка";
            // 
            // удалитьПоследнююЗаписьToolStripMenuItem
            // 
            this.удалитьПоследнююЗаписьToolStripMenuItem.Name = "удалитьПоследнююЗаписьToolStripMenuItem";
            this.удалитьПоследнююЗаписьToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.удалитьПоследнююЗаписьToolStripMenuItem.Text = "Удалить последнюю запись";
            this.удалитьПоследнююЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьПоследнююЗаписьToolStripMenuItem_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EditorForm";
            this.Text = "Редактор вопросов для игры \"Умник\"";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditor;
        private System.Windows.Forms.ToolStripMenuItem LoadMI;
        private System.Windows.Forms.ToolStripMenuItem SaveMI;
        private System.Windows.Forms.ToolStripMenuItem ExitMI;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEM;
        private System.Windows.Forms.ToolStripMenuItem удалитьПоследнююЗаписьToolStripMenuItem;
    }
}