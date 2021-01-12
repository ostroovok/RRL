namespace Forms
{
    partial class Form7
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
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MethodBox = new System.Windows.Forms.ComboBox();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.PropertiesPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CreateExampleBut = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ParametersPanel = new System.Windows.Forms.Panel();
            this.LibGroupBox = new System.Windows.Forms.GroupBox();
            this.LibPanel = new System.Windows.Forms.Panel();
            this.LibMethodsBox = new System.Windows.Forms.ComboBox();
            this.RunLibraryBut = new System.Windows.Forms.Button();
            this.CheckerLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.LibGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassBox
            // 
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(6, 21);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(188, 24);
            this.ClassBox.TabIndex = 0;
            this.ClassBox.SelectedIndexChanged += new System.EventHandler(this.ClassBox_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClassBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Классы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MethodBox);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 260);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Методы";
            // 
            // MethodBox
            // 
            this.MethodBox.FormattingEnabled = true;
            this.MethodBox.Location = new System.Drawing.Point(7, 22);
            this.MethodBox.Name = "MethodBox";
            this.MethodBox.Size = new System.Drawing.Size(187, 24);
            this.MethodBox.TabIndex = 0;
            this.MethodBox.SelectedIndexChanged += new System.EventHandler(this.MethodBox_SelectedIndexChanged);
            // 
            // OutBox
            // 
            this.OutBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OutBox.Location = new System.Drawing.Point(12, 278);
            this.OutBox.Multiline = true;
            this.OutBox.Name = "OutBox";
            this.OutBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutBox.Size = new System.Drawing.Size(407, 457);
            this.OutBox.TabIndex = 3;
            // 
            // PropertiesPanel
            // 
            this.PropertiesPanel.AutoScroll = true;
            this.PropertiesPanel.AutoScrollMargin = new System.Drawing.Size(1, 0);
            this.PropertiesPanel.Location = new System.Drawing.Point(6, 24);
            this.PropertiesPanel.Name = "PropertiesPanel";
            this.PropertiesPanel.Size = new System.Drawing.Size(301, 461);
            this.PropertiesPanel.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PropertiesPanel);
            this.groupBox3.Controls.Add(this.CreateExampleBut);
            this.groupBox3.Location = new System.Drawing.Point(424, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 547);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Свойства классов";
            // 
            // CreateExampleBut
            // 
            this.CreateExampleBut.Location = new System.Drawing.Point(6, 488);
            this.CreateExampleBut.Name = "CreateExampleBut";
            this.CreateExampleBut.Size = new System.Drawing.Size(299, 52);
            this.CreateExampleBut.TabIndex = 9;
            this.CreateExampleBut.Text = "Создать экземпляр";
            this.CreateExampleBut.UseVisualStyleBackColor = true;
            this.CreateExampleBut.Click += new System.EventHandler(this.CreateExampleBut_Click);
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(0, 0);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ParametersPanel);
            this.groupBox4.Location = new System.Drawing.Point(744, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(508, 547);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры методов";
            // 
            // ParametersPanel
            // 
            this.ParametersPanel.AutoScroll = true;
            this.ParametersPanel.Location = new System.Drawing.Point(7, 21);
            this.ParametersPanel.Name = "ParametersPanel";
            this.ParametersPanel.Size = new System.Drawing.Size(495, 519);
            this.ParametersPanel.TabIndex = 0;
            // 
            // LibGroupBox
            // 
            this.LibGroupBox.Controls.Add(this.CheckerLabel);
            this.LibGroupBox.Controls.Add(this.LibPanel);
            this.LibGroupBox.Controls.Add(this.LibMethodsBox);
            this.LibGroupBox.Controls.Add(this.RunLibraryBut);
            this.LibGroupBox.Location = new System.Drawing.Point(426, 558);
            this.LibGroupBox.Name = "LibGroupBox";
            this.LibGroupBox.Size = new System.Drawing.Size(820, 177);
            this.LibGroupBox.TabIndex = 11;
            this.LibGroupBox.TabStop = false;
            this.LibGroupBox.Text = "Работа с библиотекой";
            // 
            // LibPanel
            // 
            this.LibPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LibPanel.Location = new System.Drawing.Point(201, 22);
            this.LibPanel.Name = "LibPanel";
            this.LibPanel.Size = new System.Drawing.Size(613, 148);
            this.LibPanel.TabIndex = 2;
            // 
            // LibMethodsBox
            // 
            this.LibMethodsBox.FormattingEnabled = true;
            this.LibMethodsBox.Location = new System.Drawing.Point(7, 94);
            this.LibMethodsBox.Name = "LibMethodsBox";
            this.LibMethodsBox.Size = new System.Drawing.Size(187, 24);
            this.LibMethodsBox.TabIndex = 1;
            this.LibMethodsBox.SelectedIndexChanged += new System.EventHandler(this.LibMethodsBox_SelectedIndexChanged);
            // 
            // RunLibraryBut
            // 
            this.RunLibraryBut.Location = new System.Drawing.Point(7, 22);
            this.RunLibraryBut.Name = "RunLibraryBut";
            this.RunLibraryBut.Size = new System.Drawing.Size(187, 42);
            this.RunLibraryBut.TabIndex = 0;
            this.RunLibraryBut.Text = "Начать / Закончить";
            this.RunLibraryBut.UseVisualStyleBackColor = true;
            this.RunLibraryBut.Click += new System.EventHandler(this.RunLibraryBut_Click);
            // 
            // CheckerLabel
            // 
            this.CheckerLabel.AutoSize = true;
            this.CheckerLabel.Location = new System.Drawing.Point(7, 71);
            this.CheckerLabel.Name = "CheckerLabel";
            this.CheckerLabel.Size = new System.Drawing.Size(38, 17);
            this.CheckerLabel.TabIndex = 3;
            this.CheckerLabel.Text = "false";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 747);
            this.Controls.Add(this.LibGroupBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.OutBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.LibGroupBox.ResumeLayout(false);
            this.LibGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox MethodBox;
        private System.Windows.Forms.TextBox OutBox;
        private System.Windows.Forms.Panel PropertiesPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CreateExampleBut;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel ParametersPanel;
        private System.Windows.Forms.GroupBox LibGroupBox;
        private System.Windows.Forms.Button RunLibraryBut;
        private System.Windows.Forms.ComboBox LibMethodsBox;
        private System.Windows.Forms.Panel LibPanel;
        private System.Windows.Forms.Label CheckerLabel;
    }
}