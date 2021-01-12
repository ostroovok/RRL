namespace Forms
{
    partial class Form8
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
            this.startButton = new System.Windows.Forms.Button();
            this.WeightPanel = new System.Windows.Forms.NumericUpDown();
            this.BusOverloadChance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BusStopsCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.WeightPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusOverloadChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusStopsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(24, 566);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(167, 94);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // WeightPanel
            // 
            this.WeightPanel.Location = new System.Drawing.Point(10, 59);
            this.WeightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.WeightPanel.Name = "WeightPanel";
            this.WeightPanel.Size = new System.Drawing.Size(119, 22);
            this.WeightPanel.TabIndex = 2;
            // 
            // BusOverloadChance
            // 
            this.BusOverloadChance.Location = new System.Drawing.Point(246, 59);
            this.BusOverloadChance.Margin = new System.Windows.Forms.Padding(4);
            this.BusOverloadChance.Name = "BusOverloadChance";
            this.BusOverloadChance.Size = new System.Drawing.Size(119, 22);
            this.BusOverloadChance.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Middle Weight of Passengers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(243, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bus Overload Chance %";
            // 
            // BusStopsCount
            // 
            this.BusStopsCount.Location = new System.Drawing.Point(448, 59);
            this.BusStopsCount.Margin = new System.Windows.Forms.Padding(4);
            this.BusStopsCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BusStopsCount.Name = "BusStopsCount";
            this.BusStopsCount.Size = new System.Drawing.Size(117, 22);
            this.BusStopsCount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(445, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Count of BusStops";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 543);
            this.panel1.TabIndex = 9;
            this.panel1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WeightPanel);
            this.groupBox1.Controls.Add(this.BusStopsCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BusOverloadChance);
            this.groupBox1.Location = new System.Drawing.Point(209, 560);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 671);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form8";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeightPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusOverloadChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusStopsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.NumericUpDown BusOverloadChance;
        private System.Windows.Forms.NumericUpDown BusStopsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown WeightPanel;
        private System.Windows.Forms.Button startButton;

        #endregion

        private System.Windows.Forms.PictureBox panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}