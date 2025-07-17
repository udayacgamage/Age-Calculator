namespace AgeCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dtpBirthdate = new DateTimePicker();
            dtpCurrentdate = new DateTimePicker();
            btnCalculate = new Button();
            lblYears = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            lblWeeks = new Label();
            lblDayss = new Label();
            lblHours = new Label();
            lblMinutes = new Label();
            lblSeconds = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 0;
            label1.Text = "Age Calculator";
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Location = new Point(240, 69);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(250, 27);
            dtpBirthdate.TabIndex = 1;
            // 
            // dtpCurrentdate
            // 
            dtpCurrentdate.Location = new Point(240, 127);
            dtpCurrentdate.Name = "dtpCurrentdate";
            dtpCurrentdate.Size = new Size(250, 27);
            dtpCurrentdate.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Coral;
            btnCalculate.Location = new Point(320, 171);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 30);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblYears
            // 
            lblYears.AutoSize = true;
            lblYears.Location = new Point(238, 259);
            lblYears.Name = "lblYears";
            lblYears.Size = new Size(0, 20);
            lblYears.TabIndex = 5;
            lblYears.Click += label3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(193, 295);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 10;
            label8.Text = "Weeks :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(193, 326);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 11;
            label9.Text = "Days :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(193, 359);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 12;
            label10.Text = "Hours :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(193, 390);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 13;
            label11.Text = "Minutes :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(193, 419);
            label12.Name = "label12";
            label12.Size = new Size(71, 20);
            label12.TabIndex = 14;
            label12.Text = "Seconds :";
            // 
            // lblWeeks
            // 
            lblWeeks.AutoSize = true;
            lblWeeks.Location = new Point(252, 295);
            lblWeeks.Name = "lblWeeks";
            lblWeeks.Size = new Size(0, 20);
            lblWeeks.TabIndex = 15;
            // 
            // lblDayss
            // 
            lblDayss.AutoSize = true;
            lblDayss.Location = new Point(247, 326);
            lblDayss.Name = "lblDayss";
            lblDayss.Size = new Size(0, 20);
            lblDayss.TabIndex = 16;
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(247, 359);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(0, 20);
            lblHours.TabIndex = 17;
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Location = new Point(267, 390);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(0, 20);
            lblMinutes.TabIndex = 18;
            // 
            // lblSeconds
            // 
            lblSeconds.AutoSize = true;
            lblSeconds.Location = new Point(267, 419);
            lblSeconds.Name = "lblSeconds";
            lblSeconds.Size = new Size(0, 20);
            lblSeconds.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 259);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 20;
            label2.Text = "Years :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 485);
            Controls.Add(label2);
            Controls.Add(lblSeconds);
            Controls.Add(lblMinutes);
            Controls.Add(lblHours);
            Controls.Add(lblDayss);
            Controls.Add(lblWeeks);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lblYears);
            Controls.Add(btnCalculate);
            Controls.Add(dtpCurrentdate);
            Controls.Add(dtpBirthdate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpBirthdate;
        private DateTimePicker dtpCurrentdate;
        private Button btnCalculate;
        private Label lblYears;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblWeeks;
        private Label lblDayss;
        private Label lblHours;
        private Label lblMinutes;
        private Label lblSeconds;
        private Label label2;
    }
}
