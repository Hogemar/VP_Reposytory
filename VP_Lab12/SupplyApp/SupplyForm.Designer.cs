using System.Collections.Generic;

namespace SupplyApp
{

    partial class SupplyForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlSupply = new System.Windows.Forms.TabControl();
            this.supplyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageItem = new System.Windows.Forms.TabPage();
            this.itemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.tabPageSupplier = new System.Windows.Forms.TabPage();
            this.supplierContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierGrid = new System.Windows.Forms.DataGridView();
            this.tabPageSupply = new System.Windows.Forms.TabPage();
            this.supplyGrid = new System.Windows.Forms.DataGridView();
            this.tabControlSupply.SuspendLayout();
            this.supplyContextMenu.SuspendLayout();
            this.tabPageItem.SuspendLayout();
            this.itemContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.tabPageSupplier.SuspendLayout();
            this.supplierContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).BeginInit();
            this.tabPageSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSupply
            // 
            this.tabControlSupply.ContextMenuStrip = this.supplyContextMenu;
            this.tabControlSupply.Controls.Add(this.tabPageItem);
            this.tabControlSupply.Controls.Add(this.tabPageSupplier);
            this.tabControlSupply.Controls.Add(this.tabPageSupply);
            this.tabControlSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSupply.Location = new System.Drawing.Point(0, 0);
            this.tabControlSupply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlSupply.Name = "tabControlSupply";
            this.tabControlSupply.SelectedIndex = 0;
            this.tabControlSupply.Size = new System.Drawing.Size(1067, 554);
            this.tabControlSupply.TabIndex = 0;
            // 
            // supplyContextMenu
            // 
            this.supplyContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.supplyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshSupply,
            this.addSupply,
            this.updateSupply,
            this.removeSupply});
            this.supplyContextMenu.Name = "itemMenuStrip";
            this.supplyContextMenu.Size = new System.Drawing.Size(211, 128);
            // 
            // refreshSupply
            // 
            this.refreshSupply.Name = "refreshSupply";
            this.refreshSupply.Size = new System.Drawing.Size(210, 24);
            this.refreshSupply.Text = "Обновить";
            this.refreshSupply.Click += new System.EventHandler(this.refreshSupply_Click);
            // 
            // addSupply
            // 
            this.addSupply.Name = "addSupply";
            this.addSupply.Size = new System.Drawing.Size(210, 24);
            this.addSupply.Text = "Добавить";
            this.addSupply.Click += new System.EventHandler(this.addSupply_Click);
            // 
            // updateSupply
            // 
            this.updateSupply.Name = "updateSupply";
            this.updateSupply.Size = new System.Drawing.Size(210, 24);
            this.updateSupply.Text = "Изменить";
            this.updateSupply.Click += new System.EventHandler(this.updateSupply_Click);
            // 
            // removeSupply
            // 
            this.removeSupply.Name = "removeSupply";
            this.removeSupply.Size = new System.Drawing.Size(210, 24);
            this.removeSupply.Text = "Удалить";
            this.removeSupply.Click += new System.EventHandler(this.removeSupply_Click);
            // 
            // tabPageItem
            // 
            this.tabPageItem.ContextMenuStrip = this.itemContextMenu;
            this.tabPageItem.Controls.Add(this.itemGrid);
            this.tabPageItem.Location = new System.Drawing.Point(4, 25);
            this.tabPageItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageItem.Name = "tabPageItem";
            this.tabPageItem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageItem.Size = new System.Drawing.Size(1059, 525);
            this.tabPageItem.TabIndex = 0;
            this.tabPageItem.Text = "Товары";
            this.tabPageItem.UseVisualStyleBackColor = true;
            // 
            // itemContextMenu
            // 
            this.itemContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.itemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshItem,
            this.addItem,
            this.updateItem,
            this.removeItem});
            this.itemContextMenu.Name = "itemMenuStrip";
            this.itemContextMenu.Size = new System.Drawing.Size(148, 100);
            // 
            // refreshItem
            // 
            this.refreshItem.Name = "refreshItem";
            this.refreshItem.Size = new System.Drawing.Size(147, 24);
            this.refreshItem.Text = "Обновить";
            this.refreshItem.Click += new System.EventHandler(this.refreshItem_Click);
            // 
            // addItem
            // 
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(147, 24);
            this.addItem.Text = "Добавить";
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // updateItem
            // 
            this.updateItem.Name = "updateItem";
            this.updateItem.Size = new System.Drawing.Size(147, 24);
            this.updateItem.Text = "Изменить";
            this.updateItem.Click += new System.EventHandler(this.updateItem_Click);
            // 
            // removeItem
            // 
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(147, 24);
            this.removeItem.Text = "Удалить";
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // itemGrid
            // 
            this.itemGrid.AllowUserToAddRows = false;
            this.itemGrid.AllowUserToDeleteRows = false;
            this.itemGrid.AllowUserToResizeColumns = false;
            this.itemGrid.AllowUserToResizeRows = false;
            this.itemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.itemGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.itemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.ContextMenuStrip = this.itemContextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemGrid.Location = new System.Drawing.Point(4, 4);
            this.itemGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemGrid.MultiSelect = false;
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ReadOnly = true;
            this.itemGrid.RowHeadersWidth = 51;
            this.itemGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemGrid.RowTemplate.Height = 24;
            this.itemGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGrid.Size = new System.Drawing.Size(1051, 517);
            this.itemGrid.TabIndex = 0;
            // 
            // tabPageSupplier
            // 
            this.tabPageSupplier.ContextMenuStrip = this.supplierContextMenu;
            this.tabPageSupplier.Controls.Add(this.supplierGrid);
            this.tabPageSupplier.Location = new System.Drawing.Point(4, 25);
            this.tabPageSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageSupplier.Name = "tabPageSupplier";
            this.tabPageSupplier.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageSupplier.Size = new System.Drawing.Size(1059, 525);
            this.tabPageSupplier.TabIndex = 1;
            this.tabPageSupplier.Text = "Поставщики";
            this.tabPageSupplier.UseVisualStyleBackColor = true;
            // 
            // supplierContextMenu
            // 
            this.supplierContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.supplierContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshSupplier,
            this.addSupplier,
            this.updateSupplier,
            this.removeSupplier});
            this.supplierContextMenu.Name = "itemMenuStrip";
            this.supplierContextMenu.Size = new System.Drawing.Size(148, 100);
            // 
            // refreshSupplier
            // 
            this.refreshSupplier.Name = "refreshSupplier";
            this.refreshSupplier.Size = new System.Drawing.Size(147, 24);
            this.refreshSupplier.Text = "Обновить";
            this.refreshSupplier.Click += new System.EventHandler(this.refreshSupplier_Click);
            // 
            // addSupplier
            // 
            this.addSupplier.Name = "addSupplier";
            this.addSupplier.Size = new System.Drawing.Size(147, 24);
            this.addSupplier.Text = "Добавить";
            this.addSupplier.Click += new System.EventHandler(this.addSupplier_Click);
            // 
            // updateSupplier
            // 
            this.updateSupplier.Name = "updateSupplier";
            this.updateSupplier.Size = new System.Drawing.Size(147, 24);
            this.updateSupplier.Text = "Изменить";
            this.updateSupplier.Click += new System.EventHandler(this.updateSupplier_Click);
            // 
            // removeSupplier
            // 
            this.removeSupplier.Name = "removeSupplier";
            this.removeSupplier.Size = new System.Drawing.Size(147, 24);
            this.removeSupplier.Text = "Удалить";
            this.removeSupplier.Click += new System.EventHandler(this.removeSupplier_Click);
            // 
            // supplierGrid
            // 
            this.supplierGrid.AllowUserToAddRows = false;
            this.supplierGrid.AllowUserToDeleteRows = false;
            this.supplierGrid.AllowUserToResizeColumns = false;
            this.supplierGrid.AllowUserToResizeRows = false;
            this.supplierGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.supplierGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.supplierGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplierGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.supplierGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGrid.ContextMenuStrip = this.supplierContextMenu;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.supplierGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.supplierGrid.Location = new System.Drawing.Point(4, 4);
            this.supplierGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplierGrid.MultiSelect = false;
            this.supplierGrid.Name = "supplierGrid";
            this.supplierGrid.ReadOnly = true;
            this.supplierGrid.RowHeadersWidth = 51;
            this.supplierGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.supplierGrid.RowTemplate.Height = 24;
            this.supplierGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.supplierGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplierGrid.Size = new System.Drawing.Size(1051, 517);
            this.supplierGrid.TabIndex = 1;
            // 
            // tabPageSupply
            // 
            this.tabPageSupply.ContextMenuStrip = this.supplyContextMenu;
            this.tabPageSupply.Controls.Add(this.supplyGrid);
            this.tabPageSupply.Location = new System.Drawing.Point(4, 25);
            this.tabPageSupply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageSupply.Name = "tabPageSupply";
            this.tabPageSupply.Size = new System.Drawing.Size(1059, 525);
            this.tabPageSupply.TabIndex = 2;
            this.tabPageSupply.Text = "Поставки";
            this.tabPageSupply.UseVisualStyleBackColor = true;
            // 
            // supplyGrid
            // 
            this.supplyGrid.AllowUserToAddRows = false;
            this.supplyGrid.AllowUserToDeleteRows = false;
            this.supplyGrid.AllowUserToResizeColumns = false;
            this.supplyGrid.AllowUserToResizeRows = false;
            this.supplyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.supplyGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.supplyGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplyGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplyGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.supplyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyGrid.ContextMenuStrip = this.supplyContextMenu;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supplyGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.supplyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplyGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.supplyGrid.Location = new System.Drawing.Point(0, 0);
            this.supplyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplyGrid.MultiSelect = false;
            this.supplyGrid.Name = "supplyGrid";
            this.supplyGrid.ReadOnly = true;
            this.supplyGrid.RowHeadersWidth = 51;
            this.supplyGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.supplyGrid.RowTemplate.Height = 24;
            this.supplyGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.supplyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplyGrid.Size = new System.Drawing.Size(1059, 525);
            this.supplyGrid.TabIndex = 1;
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlSupply);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SupplyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставки";
            this.Load += new System.EventHandler(this.SupplyForm_Load);
            this.tabControlSupply.ResumeLayout(false);
            this.supplyContextMenu.ResumeLayout(false);
            this.tabPageItem.ResumeLayout(false);
            this.itemContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.tabPageSupplier.ResumeLayout(false);
            this.supplierContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).EndInit();
            this.tabPageSupply.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSupply;
        private System.Windows.Forms.TabPage tabPageItem;
        private System.Windows.Forms.DataGridView itemGrid;
        private System.Windows.Forms.TabPage tabPageSupplier;
        private System.Windows.Forms.TabPage tabPageSupply;
        private System.Windows.Forms.ContextMenuStrip itemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshItem;
        private System.Windows.Forms.ToolStripMenuItem addItem;
        private System.Windows.Forms.ToolStripMenuItem updateItem;
        private System.Windows.Forms.ToolStripMenuItem removeItem;
        private System.Windows.Forms.DataGridView supplierGrid;
        private System.Windows.Forms.DataGridView supplyGrid;
        private System.Windows.Forms.ContextMenuStrip supplierContextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshSupplier;
        private System.Windows.Forms.ToolStripMenuItem addSupplier;
        private System.Windows.Forms.ToolStripMenuItem updateSupplier;
        private System.Windows.Forms.ToolStripMenuItem removeSupplier;
        private System.Windows.Forms.ContextMenuStrip supplyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshSupply;
        private System.Windows.Forms.ToolStripMenuItem addSupply;
        private System.Windows.Forms.ToolStripMenuItem updateSupply;
        private System.Windows.Forms.ToolStripMenuItem removeSupply;
    }

}

