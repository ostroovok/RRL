namespace Forms
{
    partial class Form3
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
            this.AddWordBut = new System.Windows.Forms.Button();
            this.AddSentenceBut = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.addWordBox = new System.Windows.Forms.TextBox();
            this.sentenceBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HeaderBox = new System.Windows.Forms.TextBox();
            this.HeaderBut = new System.Windows.Forms.Button();
            this.OutTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddWordBut
            // 
            this.AddWordBut.Location = new System.Drawing.Point(9, 270);
            this.AddWordBut.Name = "AddWordBut";
            this.AddWordBut.Size = new System.Drawing.Size(164, 47);
            this.AddWordBut.TabIndex = 0;
            this.AddWordBut.Text = "Добавить слово";
            this.AddWordBut.UseVisualStyleBackColor = true;
            this.AddWordBut.Click += new System.EventHandler(this.AddWordBut_Click);
            // 
            // AddSentenceBut
            // 
            this.AddSentenceBut.Location = new System.Drawing.Point(181, 270);
            this.AddSentenceBut.Name = "AddSentenceBut";
            this.AddSentenceBut.Size = new System.Drawing.Size(164, 47);
            this.AddSentenceBut.TabIndex = 1;
            this.AddSentenceBut.Text = "Вывести предложение";
            this.AddSentenceBut.UseVisualStyleBackColor = true;
            this.AddSentenceBut.Click += new System.EventHandler(this.AddSentenceBut_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(6, 351);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(159, 46);
            this.Run.TabIndex = 2;
            this.Run.Text = "Вывести текст";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // addWordBox
            // 
            this.addWordBox.Location = new System.Drawing.Point(9, 21);
            this.addWordBox.Multiline = true;
            this.addWordBox.Name = "addWordBox";
            this.addWordBox.Size = new System.Drawing.Size(164, 243);
            this.addWordBox.TabIndex = 1;
            // 
            // sentenceBox
            // 
            this.sentenceBox.Location = new System.Drawing.Point(181, 38);
            this.sentenceBox.Multiline = true;
            this.sentenceBox.Name = "sentenceBox";
            this.sentenceBox.Size = new System.Drawing.Size(164, 226);
            this.sentenceBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.sentenceBox);
            this.groupBox1.Controls.Add(this.addWordBox);
            this.groupBox1.Controls.Add(this.AddWordBut);
            this.groupBox1.Controls.Add(this.AddSentenceBut);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 408);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HeaderBox);
            this.groupBox3.Controls.Add(this.HeaderBut);
            this.groupBox3.Location = new System.Drawing.Point(10, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 74);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Заголовок";
            // 
            // HeaderBox
            // 
            this.HeaderBox.Location = new System.Drawing.Point(107, 22);
            this.HeaderBox.Multiline = true;
            this.HeaderBox.Name = "HeaderBox";
            this.HeaderBox.Size = new System.Drawing.Size(222, 45);
            this.HeaderBox.TabIndex = 1;
            // 
            // HeaderBut
            // 
            this.HeaderBut.Location = new System.Drawing.Point(7, 22);
            this.HeaderBut.Name = "HeaderBut";
            this.HeaderBut.Size = new System.Drawing.Size(94, 45);
            this.HeaderBut.TabIndex = 0;
            this.HeaderBut.Text = "Добавить заголовок";
            this.HeaderBut.UseVisualStyleBackColor = true;
            this.HeaderBut.Click += new System.EventHandler(this.HeaderBut_Click);
            // 
            // OutTextBox
            // 
            this.OutTextBox.Location = new System.Drawing.Point(6, 21);
            this.OutTextBox.Multiline = true;
            this.OutTextBox.Name = "OutTextBox";
            this.OutTextBox.Size = new System.Drawing.Size(327, 324);
            this.OutTextBox.TabIndex = 9;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(171, 351);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(162, 46);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Run);
            this.groupBox2.Controls.Add(this.OutTextBox);
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Location = new System.Drawing.Point(354, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 408);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод текста";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Предпросмотр:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddWordBut;
        private System.Windows.Forms.Button AddSentenceBut;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.TextBox addWordBox;
        private System.Windows.Forms.TextBox sentenceBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OutTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox HeaderBox;
        private System.Windows.Forms.Button HeaderBut;
        private System.Windows.Forms.Label label1;
    }
}