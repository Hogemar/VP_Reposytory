namespace ImageEditor
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussKoef = new System.Windows.Forms.ToolStripTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.undo = new System.Windows.Forms.Button();
            this.redo = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.imageMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(646, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileMenuItem.Text = "Файл";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(192, 26);
            this.openMenuItem.Text = "Открыть";
            this.openMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(226, 26);
            this.saveMenuItem.Text = "Сохранить";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(192, 26);
            this.saveAsMenuItem.Text = "Сохранить как";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // imageMenuItem
            // 
            this.imageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterMenuItem,
            this.gaussMenuItem,
            this.gaussKoef});
            this.imageMenuItem.Name = "imageMenuItem";
            this.imageMenuItem.Size = new System.Drawing.Size(121, 26);
            this.imageMenuItem.Text = "Изображение";
            // 
            // filterMenuItem
            // 
            this.filterMenuItem.Name = "filterMenuItem";
            this.filterMenuItem.Size = new System.Drawing.Size(299, 26);
            this.filterMenuItem.Text = "Повысить чёткость (границы)";
            this.filterMenuItem.Click += new System.EventHandler(this.filterMenuItem_Click);
            // 
            // gaussMenuItem
            // 
            this.gaussMenuItem.Name = "gaussMenuItem";
            this.gaussMenuItem.Size = new System.Drawing.Size(299, 26);
            this.gaussMenuItem.Text = "Размытие по Гауссу";
            this.gaussMenuItem.Click += new System.EventHandler(this.GaussMenuItem_Click);
            // 
            // gaussKoef
            // 
            this.gaussKoef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gaussKoef.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gaussKoef.Name = "gaussKoef";
            this.gaussKoef.Size = new System.Drawing.Size(160, 27);
            this.gaussKoef.Text = "Значение коэф - та";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 65);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(622, 324);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(12, 29);
            this.undo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(89, 30);
            this.undo.TabIndex = 2;
            this.undo.Text = "Отменить";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // redo
            // 
            this.redo.Location = new System.Drawing.Point(107, 29);
            this.redo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(91, 30);
            this.redo.TabIndex = 3;
            this.redo.Text = "Вернуть";
            this.redo.UseVisualStyleBackColor = true;
            this.redo.Click += new System.EventHandler(this.redu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 401);
            this.Controls.Add(this.redo);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графический редактор";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem gaussMenuItem;
        private System.Windows.Forms.ToolStripTextBox gaussKoef;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Button redo;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
    }
}

