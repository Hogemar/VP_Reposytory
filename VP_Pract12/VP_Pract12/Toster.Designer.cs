namespace VP_Pract12
{
    partial class Toster
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
            this.breadTypeComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.toastTimeTextBox = new System.Windows.Forms.TextBox();
            this.remainingTimeLabel = new System.Windows.Forms.Label();
            this.breadTypeLabel = new System.Windows.Forms.Label();
            this.slicesLabel = new System.Windows.Forms.Label();
            this.toastTimeLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.slicesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // breadTypeComboBox
            // 
            this.breadTypeComboBox.FormattingEnabled = true;
            this.breadTypeComboBox.Location = new System.Drawing.Point(11, 28);
            this.breadTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.breadTypeComboBox.Name = "breadTypeComboBox";
            this.breadTypeComboBox.Size = new System.Drawing.Size(108, 24);
            this.breadTypeComboBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(11, 156);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(108, 41);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // toastTimeTextBox
            // 
            this.toastTimeTextBox.Location = new System.Drawing.Point(11, 108);
            this.toastTimeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toastTimeTextBox.Name = "toastTimeTextBox";
            this.toastTimeTextBox.Size = new System.Drawing.Size(108, 22);
            this.toastTimeTextBox.TabIndex = 5;
            // 
            // remainingTimeLabel
            // 
            this.remainingTimeLabel.BackColor = System.Drawing.Color.Gray;
            this.remainingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remainingTimeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.remainingTimeLabel.Location = new System.Drawing.Point(140, 156);
            this.remainingTimeLabel.Name = "remainingTimeLabel";
            this.remainingTimeLabel.Size = new System.Drawing.Size(128, 39);
            this.remainingTimeLabel.TabIndex = 6;
            this.remainingTimeLabel.Text = "Таймер";
            // 
            // breadTypeLabel
            // 
            this.breadTypeLabel.AutoSize = true;
            this.breadTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.breadTypeLabel.Location = new System.Drawing.Point(132, 31);
            this.breadTypeLabel.Name = "breadTypeLabel";
            this.breadTypeLabel.Size = new System.Drawing.Size(211, 20);
            this.breadTypeLabel.TabIndex = 7;
            this.breadTypeLabel.Text = "🡄 Выбор вида хлебушка";
            // 
            // slicesLabel
            // 
            this.slicesLabel.AutoSize = true;
            this.slicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slicesLabel.Location = new System.Drawing.Point(132, 70);
            this.slicesLabel.Name = "slicesLabel";
            this.slicesLabel.Size = new System.Drawing.Size(212, 20);
            this.slicesLabel.TabIndex = 8;
            this.slicesLabel.Text = "🡄 Количество ломтиков";
            // 
            // toastTimeLabel
            // 
            this.toastTimeLabel.AutoSize = true;
            this.toastTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toastTimeLabel.Location = new System.Drawing.Point(132, 108);
            this.toastTimeLabel.Name = "toastTimeLabel";
            this.toastTimeLabel.Size = new System.Drawing.Size(185, 20);
            this.toastTimeLabel.TabIndex = 9;
            this.toastTimeLabel.Text = "🡄 Время жарки (сек.)";
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Red;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(11, 202);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(108, 41);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // slicesComboBox
            // 
            this.slicesComboBox.FormattingEnabled = true;
            this.slicesComboBox.Location = new System.Drawing.Point(11, 70);
            this.slicesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slicesComboBox.Name = "slicesComboBox";
            this.slicesComboBox.Size = new System.Drawing.Size(108, 24);
            this.slicesComboBox.TabIndex = 11;
            // 
            // Toster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.slicesComboBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.toastTimeLabel);
            this.Controls.Add(this.slicesLabel);
            this.Controls.Add(this.breadTypeLabel);
            this.Controls.Add(this.remainingTimeLabel);
            this.Controls.Add(this.toastTimeTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.breadTypeComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Toster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox breadTypeComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox toastTimeTextBox;
        private System.Windows.Forms.Label remainingTimeLabel;
        private System.Windows.Forms.Label breadTypeLabel;
        private System.Windows.Forms.Label slicesLabel;
        private System.Windows.Forms.Label toastTimeLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ComboBox slicesComboBox;
    }
}

