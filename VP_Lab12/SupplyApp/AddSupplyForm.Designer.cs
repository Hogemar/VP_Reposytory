using SupplyApp.SupplyDataSet1TableAdapters;
using System.Windows.Forms;

namespace SupplyApp
{
    partial class AddSupplyForm
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblVolume = new System.Windows.Forms.Label();
            this.boxSupplier = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierDataSet = new SupplyApp.supplierDataSet();
            this.supplyDataSet = new SupplyApp.SupplyDataSet();
            this.supplierTableAdapter = new SupplyApp.SupplyDataSetTableAdapters.SupplierTableAdapter();
            this.boxItem = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemDataSet = new SupplyApp.ItemDataSet();
            this.supplyDataSet1 = new SupplyApp.SupplyDataSet1();
            this.itemTableAdapter = new SupplyApp.SupplyDataSet1TableAdapters.ItemTableAdapter();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.supplierTableAdapter1 = new SupplyApp.supplierDataSetTableAdapters.SupplierTableAdapter();
            this.itemTableAdapter1 = new SupplyApp.ItemDataSetTableAdapters.ItemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(275, 208);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(395, 208);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 11);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Дата поставки";
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate.Location = new System.Drawing.Point(20, 31);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(209, 22);
            this.txtDate.TabIndex = 3;
            this.txtDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtDate_Validating);
            this.txtDate.Validated += new System.EventHandler(this.txtDate_Validated);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(16, 73);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(79, 16);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Поставщик";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(16, 133);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(48, 16);
            this.lblItem.TabIndex = 6;
            this.lblItem.Text = "Товар";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(16, 191);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(51, 16);
            this.lblVolume.TabIndex = 8;
            this.lblVolume.Text = "Объём";
            // 
            // boxSupplier
            // 
            this.boxSupplier.DataSource = this.supplierBindingSource;
            this.boxSupplier.DisplayMember = "Name";
            this.boxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSupplier.FormattingEnabled = true;
            this.boxSupplier.Location = new System.Drawing.Point(20, 94);
            this.boxSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.boxSupplier.Name = "boxSupplier";
            this.boxSupplier.Size = new System.Drawing.Size(208, 24);
            this.boxSupplier.TabIndex = 10;
            this.boxSupplier.ValueMember = "Id";
            this.boxSupplier.Validating += new System.ComponentModel.CancelEventHandler(this.boxSupplier_Validating);
            this.boxSupplier.Validated += new System.EventHandler(this.boxSupplier_Validated);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.supplierDataSet;
            // 
            // supplierDataSet
            // 
            this.supplierDataSet.DataSetName = "supplierDataSet";
            this.supplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplyDataSet
            // 
            this.supplyDataSet.DataSetName = "SupplyDataSet";
            this.supplyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // boxItem
            // 
            this.boxItem.DataSource = this.itemBindingSource;
            this.boxItem.DisplayMember = "Name";
            this.boxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxItem.FormattingEnabled = true;
            this.boxItem.Location = new System.Drawing.Point(20, 154);
            this.boxItem.Margin = new System.Windows.Forms.Padding(4);
            this.boxItem.Name = "boxItem";
            this.boxItem.Size = new System.Drawing.Size(208, 24);
            this.boxItem.TabIndex = 11;
            this.boxItem.ValueMember = "Id";
            this.boxItem.Validating += new System.ComponentModel.CancelEventHandler(this.boxItem_Validating);
            this.boxItem.Validated += new System.EventHandler(this.boxItem_Validated);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.itemDataSet;
            // 
            // itemDataSet
            // 
            this.itemDataSet.DataSetName = "ItemDataSet";
            this.itemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplyDataSet1
            // 
            this.supplyDataSet1.DataSetName = "SupplyDataSet1";
            this.supplyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(20, 212);
            this.txtVolume.Margin = new System.Windows.Forms.Padding(4);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(208, 22);
            this.txtVolume.TabIndex = 12;
            this.txtVolume.Validating += new System.ComponentModel.CancelEventHandler(this.txtVolume_Validating);
            this.txtVolume.Validated += new System.EventHandler(this.txtVolume_Validated);
            // 
            // supplierTableAdapter1
            // 
            this.supplierTableAdapter1.ClearBeforeFill = true;
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // AddSupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(511, 251);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.boxItem);
            this.Controls.Add(this.boxSupplier);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSupplyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить поставку";
            this.Load += new System.EventHandler(this.AddSupplyForm_Load);
            this.Shown += new System.EventHandler(this.AddSupplyForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.ComboBox boxSupplier;
        private SupplyDataSet supplyDataSet;
        private SupplyDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private ComboBox boxItem;
        private SupplyDataSet1 supplyDataSet1;
        private ItemTableAdapter itemTableAdapter;
        private TextBox txtVolume;
        private supplierDataSet supplierDataSet;
        private BindingSource supplierBindingSource;
        private supplierDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter1;
        private ItemDataSet itemDataSet;
        private BindingSource itemBindingSource;
        private ItemDataSetTableAdapters.ItemTableAdapter itemTableAdapter1;
    }
}