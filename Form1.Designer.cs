namespace assignment2_PavelGolovan
{
    partial class Form1
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
            this.tickets_groupBox = new System.Windows.Forms.GroupBox();
            this.description_label = new System.Windows.Forms.Label();
            this.revenue_groupBox = new System.Windows.Forms.GroupBox();
            this.classA_label0 = new System.Windows.Forms.Label();
            this.classB_label0 = new System.Windows.Forms.Label();
            this.classC_label0 = new System.Windows.Forms.Label();
            this.classA_textBox = new System.Windows.Forms.TextBox();
            this.classB_textBox = new System.Windows.Forms.TextBox();
            this.classC_textBox = new System.Windows.Forms.TextBox();
            this.classAtotal_label = new System.Windows.Forms.Label();
            this.classBtotal_label = new System.Windows.Forms.Label();
            this.classCtotal_label = new System.Windows.Forms.Label();
            this.total_label1 = new System.Windows.Forms.Label();
            this.classA_label1 = new System.Windows.Forms.Label();
            this.classB_label1 = new System.Windows.Forms.Label();
            this.classC_label1 = new System.Windows.Forms.Label();
            this.total_label0 = new System.Windows.Forms.Label();
            this.calculate_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.tickets_groupBox.SuspendLayout();
            this.revenue_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tickets_groupBox
            // 
            this.tickets_groupBox.Controls.Add(this.classC_textBox);
            this.tickets_groupBox.Controls.Add(this.classB_textBox);
            this.tickets_groupBox.Controls.Add(this.classC_label0);
            this.tickets_groupBox.Controls.Add(this.classA_label0);
            this.tickets_groupBox.Controls.Add(this.classB_label0);
            this.tickets_groupBox.Controls.Add(this.description_label);
            this.tickets_groupBox.Controls.Add(this.classA_textBox);
            this.tickets_groupBox.Location = new System.Drawing.Point(12, 12);
            this.tickets_groupBox.Name = "tickets_groupBox";
            this.tickets_groupBox.Size = new System.Drawing.Size(228, 161);
            this.tickets_groupBox.TabIndex = 0;
            this.tickets_groupBox.TabStop = false;
            this.tickets_groupBox.Text = "Tickets Sold";
            // 
            // description_label
            // 
            this.description_label.Location = new System.Drawing.Point(22, 16);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(168, 27);
            this.description_label.TabIndex = 0;
            this.description_label.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // revenue_groupBox
            // 
            this.revenue_groupBox.Controls.Add(this.total_label0);
            this.revenue_groupBox.Controls.Add(this.classC_label1);
            this.revenue_groupBox.Controls.Add(this.classB_label1);
            this.revenue_groupBox.Controls.Add(this.classA_label1);
            this.revenue_groupBox.Controls.Add(this.total_label1);
            this.revenue_groupBox.Controls.Add(this.classCtotal_label);
            this.revenue_groupBox.Controls.Add(this.classBtotal_label);
            this.revenue_groupBox.Controls.Add(this.classAtotal_label);
            this.revenue_groupBox.Location = new System.Drawing.Point(253, 12);
            this.revenue_groupBox.Name = "revenue_groupBox";
            this.revenue_groupBox.Size = new System.Drawing.Size(200, 161);
            this.revenue_groupBox.TabIndex = 1;
            this.revenue_groupBox.TabStop = false;
            this.revenue_groupBox.Text = "Revenue Generated";
            // 
            // classA_label0
            // 
            this.classA_label0.AutoSize = true;
            this.classA_label0.Location = new System.Drawing.Point(39, 66);
            this.classA_label0.Name = "classA_label0";
            this.classA_label0.Size = new System.Drawing.Size(45, 13);
            this.classA_label0.TabIndex = 2;
            this.classA_label0.Text = "Class A:";
            // 
            // classB_label0
            // 
            this.classB_label0.AutoSize = true;
            this.classB_label0.Location = new System.Drawing.Point(39, 93);
            this.classB_label0.Name = "classB_label0";
            this.classB_label0.Size = new System.Drawing.Size(45, 13);
            this.classB_label0.TabIndex = 3;
            this.classB_label0.Text = "Class B:";
            // 
            // classC_label0
            // 
            this.classC_label0.AutoSize = true;
            this.classC_label0.Location = new System.Drawing.Point(39, 120);
            this.classC_label0.Name = "classC_label0";
            this.classC_label0.Size = new System.Drawing.Size(45, 13);
            this.classC_label0.TabIndex = 4;
            this.classC_label0.Text = "Class C:";
            // 
            // classA_textBox
            // 
            this.classA_textBox.Location = new System.Drawing.Point(90, 63);
            this.classA_textBox.Name = "classA_textBox";
            this.classA_textBox.Size = new System.Drawing.Size(100, 20);
            this.classA_textBox.TabIndex = 2;
            // 
            // classB_textBox
            // 
            this.classB_textBox.Location = new System.Drawing.Point(90, 90);
            this.classB_textBox.Name = "classB_textBox";
            this.classB_textBox.Size = new System.Drawing.Size(100, 20);
            this.classB_textBox.TabIndex = 5;
            // 
            // classC_textBox
            // 
            this.classC_textBox.Location = new System.Drawing.Point(90, 117);
            this.classC_textBox.Name = "classC_textBox";
            this.classC_textBox.Size = new System.Drawing.Size(100, 20);
            this.classC_textBox.TabIndex = 6;
            // 
            // classAtotal_label
            // 
            this.classAtotal_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classAtotal_label.Location = new System.Drawing.Point(75, 22);
            this.classAtotal_label.Name = "classAtotal_label";
            this.classAtotal_label.Size = new System.Drawing.Size(100, 23);
            this.classAtotal_label.TabIndex = 0;
            this.classAtotal_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // classBtotal_label
            // 
            this.classBtotal_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBtotal_label.Location = new System.Drawing.Point(75, 53);
            this.classBtotal_label.Name = "classBtotal_label";
            this.classBtotal_label.Size = new System.Drawing.Size(100, 23);
            this.classBtotal_label.TabIndex = 1;
            this.classBtotal_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // classCtotal_label
            // 
            this.classCtotal_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCtotal_label.Location = new System.Drawing.Point(75, 83);
            this.classCtotal_label.Name = "classCtotal_label";
            this.classCtotal_label.Size = new System.Drawing.Size(100, 23);
            this.classCtotal_label.TabIndex = 2;
            this.classCtotal_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // total_label1
            // 
            this.total_label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_label1.Location = new System.Drawing.Point(75, 114);
            this.total_label1.Name = "total_label1";
            this.total_label1.Size = new System.Drawing.Size(100, 23);
            this.total_label1.TabIndex = 3;
            this.total_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // classA_label1
            // 
            this.classA_label1.AutoSize = true;
            this.classA_label1.Location = new System.Drawing.Point(24, 32);
            this.classA_label1.Name = "classA_label1";
            this.classA_label1.Size = new System.Drawing.Size(45, 13);
            this.classA_label1.TabIndex = 7;
            this.classA_label1.Text = "Class A:";
            // 
            // classB_label1
            // 
            this.classB_label1.AutoSize = true;
            this.classB_label1.Location = new System.Drawing.Point(24, 63);
            this.classB_label1.Name = "classB_label1";
            this.classB_label1.Size = new System.Drawing.Size(45, 13);
            this.classB_label1.TabIndex = 7;
            this.classB_label1.Text = "Class B:";
            // 
            // classC_label1
            // 
            this.classC_label1.AutoSize = true;
            this.classC_label1.Location = new System.Drawing.Point(24, 93);
            this.classC_label1.Name = "classC_label1";
            this.classC_label1.Size = new System.Drawing.Size(45, 13);
            this.classC_label1.TabIndex = 7;
            this.classC_label1.Text = "Class C:";
            // 
            // total_label0
            // 
            this.total_label0.AutoSize = true;
            this.total_label0.Location = new System.Drawing.Point(35, 124);
            this.total_label0.Name = "total_label0";
            this.total_label0.Size = new System.Drawing.Size(34, 13);
            this.total_label0.TabIndex = 8;
            this.total_label0.Text = "Total:";
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(105, 198);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(73, 40);
            this.calculate_button.TabIndex = 2;
            this.calculate_button.Text = "Calculate Revenue";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(186, 198);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(73, 40);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(268, 198);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(73, 40);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 253);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.revenue_groupBox);
            this.Controls.Add(this.tickets_groupBox);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.tickets_groupBox.ResumeLayout(false);
            this.tickets_groupBox.PerformLayout();
            this.revenue_groupBox.ResumeLayout(false);
            this.revenue_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tickets_groupBox;
        private System.Windows.Forms.TextBox classC_textBox;
        private System.Windows.Forms.TextBox classB_textBox;
        private System.Windows.Forms.Label classC_label0;
        private System.Windows.Forms.Label classA_label0;
        private System.Windows.Forms.Label classB_label0;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.TextBox classA_textBox;
        private System.Windows.Forms.GroupBox revenue_groupBox;
        private System.Windows.Forms.Label total_label0;
        private System.Windows.Forms.Label classC_label1;
        private System.Windows.Forms.Label classB_label1;
        private System.Windows.Forms.Label classA_label1;
        private System.Windows.Forms.Label total_label1;
        private System.Windows.Forms.Label classCtotal_label;
        private System.Windows.Forms.Label classBtotal_label;
        private System.Windows.Forms.Label classAtotal_label;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button exit_button;
    }
}

