namespace Lab2OOP
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
            this.ChooseDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butEd = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ChooseDevice
            // 
            this.ChooseDevice.DropDownHeight = 120;
            this.ChooseDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseDevice.FormattingEnabled = true;
            this.ChooseDevice.IntegralHeight = false;
            this.ChooseDevice.Location = new System.Drawing.Point(214, 12);
            this.ChooseDevice.Name = "ChooseDevice";
            this.ChooseDevice.Size = new System.Drawing.Size(317, 30);
            this.ChooseDevice.TabIndex = 1;
            this.ChooseDevice.SelectedIndexChanged += new System.EventHandler(this.ChooceDevice_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(240)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose class of object to create:";
            // 
            // butEd
            // 
            this.butEd.Enabled = false;
            this.butEd.Location = new System.Drawing.Point(554, 6);
            this.butEd.Name = "butEd";
            this.butEd.Size = new System.Drawing.Size(279, 41);
            this.butEd.TabIndex = 5;
            this.butEd.Text = "Edit object";
            this.butEd.UseVisualStyleBackColor = true;
            this.butEd.Click += new System.EventHandler(this.butEd_Click);
            // 
            // butDel
            // 
            this.butDel.Enabled = false;
            this.butDel.Location = new System.Drawing.Point(854, 6);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(252, 41);
            this.butDel.TabIndex = 6;
            this.butDel.Text = "Delete object";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(2, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1126, 576);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1131, 664);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butEd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseDevice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(240)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ChooseDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butEd;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.ListBox listBox1;
    }
}

