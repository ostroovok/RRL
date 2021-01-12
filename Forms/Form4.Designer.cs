namespace Forms
{
    partial class Form4
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.FrequencyBox = new System.Windows.Forms.TextBox();
            this.RAMBox = new System.Windows.Forms.TextBox();
            this.OutPanel = new System.Windows.Forms.TextBox();
            this.QHBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QBut = new System.Windows.Forms.Button();
            this.PBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(6, 31);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(153, 29);
            this.NameBox.TabIndex = 0;
            this.NameBox.Text = "Название";
            // 
            // FrequencyBox
            // 
            this.FrequencyBox.Location = new System.Drawing.Point(6, 66);
            this.FrequencyBox.Multiline = true;
            this.FrequencyBox.Name = "FrequencyBox";
            this.FrequencyBox.Size = new System.Drawing.Size(120, 29);
            this.FrequencyBox.TabIndex = 1;
            this.FrequencyBox.Text = "Частота ";
            // 
            // RAMBox
            // 
            this.RAMBox.Location = new System.Drawing.Point(6, 101);
            this.RAMBox.Multiline = true;
            this.RAMBox.Name = "RAMBox";
            this.RAMBox.Size = new System.Drawing.Size(120, 29);
            this.RAMBox.TabIndex = 2;
            this.RAMBox.Text = "RAM";
            // 
            // OutPanel
            // 
            this.OutPanel.Location = new System.Drawing.Point(6, 21);
            this.OutPanel.Multiline = true;
            this.OutPanel.Name = "OutPanel";
            this.OutPanel.Size = new System.Drawing.Size(339, 242);
            this.OutPanel.TabIndex = 3;
            // 
            // QHBut
            // 
            this.QHBut.Location = new System.Drawing.Point(6, 171);
            this.QHBut.Name = "QHBut";
            this.QHBut.Size = new System.Drawing.Size(181, 43);
            this.QHBut.TabIndex = 4;
            this.QHBut.Text = "С учетом Hdd";
            this.QHBut.UseVisualStyleBackColor = true;
            this.QHBut.Click += new System.EventHandler(this.QHBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QBut);
            this.groupBox1.Controls.Add(this.PBox);
            this.groupBox1.Controls.Add(this.QHBut);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.FrequencyBox);
            this.groupBox1.Controls.Add(this.RAMBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 270);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод";
            // 
            // QBut
            // 
            this.QBut.Location = new System.Drawing.Point(7, 221);
            this.QBut.Name = "QBut";
            this.QBut.Size = new System.Drawing.Size(180, 43);
            this.QBut.TabIndex = 6;
            this.QBut.Text = "Без учета Hdd";
            this.QBut.UseVisualStyleBackColor = true;
            this.QBut.Click += new System.EventHandler(this.QBut_Click);
            // 
            // PBox
            // 
            this.PBox.Location = new System.Drawing.Point(6, 136);
            this.PBox.Multiline = true;
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(120, 29);
            this.PBox.TabIndex = 5;
            this.PBox.Text = "P";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OutPanel);
            this.groupBox2.Location = new System.Drawing.Point(212, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 269);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 294);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox FrequencyBox;
        private System.Windows.Forms.TextBox RAMBox;
        private System.Windows.Forms.TextBox OutPanel;
        private System.Windows.Forms.Button QHBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button QBut;
    }
}