namespace Forms
{
    partial class Form2
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
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenBox = new System.Windows.Forms.TextBox();
            this.SaveBox = new System.Windows.Forms.TextBox();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NumBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChangeBox = new System.Windows.Forms.TextBox();
            this.CheangeBut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(17, 21);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(92, 39);
            this.Open.TabIndex = 1;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(17, 83);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(92, 39);
            this.Save.TabIndex = 2;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(17, 217);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(92, 39);
            this.Run.TabIndex = 3;
            this.Run.Text = "Выполнить";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenBox
            // 
            this.OpenBox.Location = new System.Drawing.Point(6, 21);
            this.OpenBox.Multiline = true;
            this.OpenBox.Name = "OpenBox";
            this.OpenBox.Size = new System.Drawing.Size(335, 39);
            this.OpenBox.TabIndex = 4;
            // 
            // SaveBox
            // 
            this.SaveBox.Location = new System.Drawing.Point(6, 83);
            this.SaveBox.Multiline = true;
            this.SaveBox.Name = "SaveBox";
            this.SaveBox.Size = new System.Drawing.Size(335, 39);
            this.SaveBox.TabIndex = 5;
            // 
            // OutBox
            // 
            this.OutBox.Location = new System.Drawing.Point(6, 217);
            this.OutBox.Multiline = true;
            this.OutBox.Name = "OutBox";
            this.OutBox.Size = new System.Drawing.Size(147, 39);
            this.OutBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChangeBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.OpenBox);
            this.groupBox1.Controls.Add(this.OutBox);
            this.groupBox1.Controls.Add(this.SaveBox);
            this.groupBox1.Location = new System.Drawing.Point(141, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 272);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NumBox);
            this.groupBox3.Location = new System.Drawing.Point(159, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 66);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кол-во слов";
            // 
            // NumBox
            // 
            this.NumBox.Location = new System.Drawing.Point(6, 28);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(170, 22);
            this.NumBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheangeBut);
            this.groupBox2.Controls.Add(this.Open);
            this.groupBox2.Controls.Add(this.Save);
            this.groupBox2.Controls.Add(this.Run);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 272);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // ChangeBox
            // 
            this.ChangeBox.Location = new System.Drawing.Point(6, 142);
            this.ChangeBox.Multiline = true;
            this.ChangeBox.Name = "ChangeBox";
            this.ChangeBox.Size = new System.Drawing.Size(335, 39);
            this.ChangeBox.TabIndex = 9;
            // 
            // CheangeBut
            // 
            this.CheangeBut.Location = new System.Drawing.Point(17, 142);
            this.CheangeBut.Name = "CheangeBut";
            this.CheangeBut.Size = new System.Drawing.Size(92, 39);
            this.CheangeBut.TabIndex = 4;
            this.CheangeBut.Text = "Изменить";
            this.CheangeBut.UseVisualStyleBackColor = true;
            this.CheangeBut.Click += new System.EventHandler(this.CheangeBut_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 288);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox OpenBox;
        private System.Windows.Forms.TextBox SaveBox;
        private System.Windows.Forms.TextBox OutBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.TextBox ChangeBox;
        private System.Windows.Forms.Button CheangeBut;
    }
}

