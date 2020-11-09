namespace CG_lab2._0
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.pixelsButton = new System.Windows.Forms.Button();
            this.millimetersButton = new System.Windows.Forms.Button();
            this.inchesButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(45, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1000, 500);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // pixelsButton
            // 
            this.pixelsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pixelsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pixelsButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pixelsButton.Location = new System.Drawing.Point(45, 552);
            this.pixelsButton.Name = "pixelsButton";
            this.pixelsButton.Size = new System.Drawing.Size(167, 59);
            this.pixelsButton.TabIndex = 1;
            this.pixelsButton.Text = "Пиксели";
            this.pixelsButton.UseVisualStyleBackColor = false;
            this.pixelsButton.Click += new System.EventHandler(this.pixelsButton_Click);
            // 
            // millimetersButton
            // 
            this.millimetersButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.millimetersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.millimetersButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.millimetersButton.Location = new System.Drawing.Point(318, 552);
            this.millimetersButton.Name = "millimetersButton";
            this.millimetersButton.Size = new System.Drawing.Size(167, 59);
            this.millimetersButton.TabIndex = 2;
            this.millimetersButton.Text = "Миллиметры";
            this.millimetersButton.UseVisualStyleBackColor = false;
            this.millimetersButton.Click += new System.EventHandler(this.millimetersButton_Click);
            // 
            // inchesButton
            // 
            this.inchesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inchesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inchesButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesButton.Location = new System.Drawing.Point(601, 552);
            this.inchesButton.Name = "inchesButton";
            this.inchesButton.Size = new System.Drawing.Size(167, 59);
            this.inchesButton.TabIndex = 3;
            this.inchesButton.Text = "Дюймы";
            this.inchesButton.UseVisualStyleBackColor = false;
            this.inchesButton.Click += new System.EventHandler(this.inchesButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(878, 552);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(167, 59);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1084, 687);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.inchesButton);
            this.Controls.Add(this.millimetersButton);
            this.Controls.Add(this.pixelsButton);
            this.Controls.Add(this.pic);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 726);
            this.MinimumSize = new System.Drawing.Size(1100, 726);
            this.Name = "Form1";
            this.Text = " Графопостроитель";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button pixelsButton;
        private System.Windows.Forms.Button millimetersButton;
        private System.Windows.Forms.Button inchesButton;
        private System.Windows.Forms.Button clearButton;
    }
}

