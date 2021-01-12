namespace Forms
{
    partial class Form6
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
            this.AuNameBox = new System.Windows.Forms.TextBox();
            this.BoNameBox = new System.Windows.Forms.TextBox();
            this.EdNameBox = new System.Windows.Forms.TextBox();
            this.BoCostBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PreOutBox = new System.Windows.Forms.TextBox();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.CreateBut = new System.Windows.Forms.Button();
            this.FindBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReEditionBut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.boNumber = new System.Windows.Forms.TextBox();
            this.CreateListBut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuNameBox
            // 
            this.AuNameBox.Location = new System.Drawing.Point(131, 31);
            this.AuNameBox.Name = "AuNameBox";
            this.AuNameBox.Size = new System.Drawing.Size(100, 22);
            this.AuNameBox.TabIndex = 0;
            // 
            // BoNameBox
            // 
            this.BoNameBox.Location = new System.Drawing.Point(131, 59);
            this.BoNameBox.Name = "BoNameBox";
            this.BoNameBox.Size = new System.Drawing.Size(100, 22);
            this.BoNameBox.TabIndex = 1;
            // 
            // EdNameBox
            // 
            this.EdNameBox.Location = new System.Drawing.Point(131, 87);
            this.EdNameBox.Name = "EdNameBox";
            this.EdNameBox.Size = new System.Drawing.Size(100, 22);
            this.EdNameBox.TabIndex = 2;
            // 
            // BoCostBox
            // 
            this.BoCostBox.Location = new System.Drawing.Point(131, 116);
            this.BoCostBox.Name = "BoCostBox";
            this.BoCostBox.Size = new System.Drawing.Size(100, 22);
            this.BoCostBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя Автора:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название Книги:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Издательство:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Стоимость:";
            // 
            // PreOutBox
            // 
            this.PreOutBox.Location = new System.Drawing.Point(12, 179);
            this.PreOutBox.Multiline = true;
            this.PreOutBox.Name = "PreOutBox";
            this.PreOutBox.Size = new System.Drawing.Size(245, 72);
            this.PreOutBox.TabIndex = 8;
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(16, 87);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(151, 32);
            this.DeleteBut.TabIndex = 9;
            this.DeleteBut.Text = "Убрать с пубикации";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // CreateBut
            // 
            this.CreateBut.Location = new System.Drawing.Point(16, 49);
            this.CreateBut.Name = "CreateBut";
            this.CreateBut.Size = new System.Drawing.Size(151, 32);
            this.CreateBut.TabIndex = 10;
            this.CreateBut.Text = "Создать";
            this.CreateBut.UseVisualStyleBackColor = true;
            this.CreateBut.Click += new System.EventHandler(this.CreateBut_Click);
            // 
            // FindBut
            // 
            this.FindBut.Location = new System.Drawing.Point(173, 50);
            this.FindBut.Name = "FindBut";
            this.FindBut.Size = new System.Drawing.Size(151, 32);
            this.FindBut.TabIndex = 12;
            this.FindBut.Text = "Найти по номеру";
            this.FindBut.UseVisualStyleBackColor = true;
            this.FindBut.Click += new System.EventHandler(this.FindBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReEditionBut);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.boNumber);
            this.groupBox1.Controls.Add(this.CreateBut);
            this.groupBox1.Controls.Add(this.CreateListBut);
            this.groupBox1.Controls.Add(this.FindBut);
            this.groupBox1.Controls.Add(this.DeleteBut);
            this.groupBox1.Location = new System.Drawing.Point(12, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 135);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // ReEditionBut
            // 
            this.ReEditionBut.Location = new System.Drawing.Point(173, 88);
            this.ReEditionBut.Name = "ReEditionBut";
            this.ReEditionBut.Size = new System.Drawing.Size(150, 31);
            this.ReEditionBut.TabIndex = 20;
            this.ReEditionBut.Text = "Переиздание";
            this.ReEditionBut.UseVisualStyleBackColor = true;
            this.ReEditionBut.Click += new System.EventHandler(this.ReEditionBut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Номер Книги: ";
            // 
            // boNumber
            // 
            this.boNumber.Location = new System.Drawing.Point(113, 21);
            this.boNumber.Name = "boNumber";
            this.boNumber.Size = new System.Drawing.Size(368, 22);
            this.boNumber.TabIndex = 16;
            // 
            // CreateListBut
            // 
            this.CreateListBut.Location = new System.Drawing.Point(330, 50);
            this.CreateListBut.Name = "CreateListBut";
            this.CreateListBut.Size = new System.Drawing.Size(151, 69);
            this.CreateListBut.TabIndex = 15;
            this.CreateListBut.Text = "Вывести список";
            this.CreateListBut.UseVisualStyleBackColor = true;
            this.CreateListBut.Click += new System.EventHandler(this.CreateListBut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AuNameBox);
            this.groupBox2.Controls.Add(this.BoNameBox);
            this.groupBox2.Controls.Add(this.EdNameBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BoCostBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 151);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные";
            // 
            // OutBox
            // 
            this.OutBox.Location = new System.Drawing.Point(263, 22);
            this.OutBox.Multiline = true;
            this.OutBox.Name = "OutBox";
            this.OutBox.Size = new System.Drawing.Size(241, 229);
            this.OutBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Предварительный просмотр:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Тираж Книг:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 389);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PreOutBox);
            this.Controls.Add(this.OutBox);
            this.Name = "Form6";
            this.Text = "Form6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AuNameBox;
        private System.Windows.Forms.TextBox BoNameBox;
        private System.Windows.Forms.TextBox EdNameBox;
        private System.Windows.Forms.TextBox BoCostBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PreOutBox;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button CreateBut;
        private System.Windows.Forms.Button FindBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateListBut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox OutBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boNumber;
        private System.Windows.Forms.Button ReEditionBut;
        private System.Windows.Forms.Label label7;
    }
}