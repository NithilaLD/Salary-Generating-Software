namespace Salary_Genarating_Software
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
            label2 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(234, 20);
            label2.TabIndex = 4;
            label2.Text = "Please Select Your Payment Plan";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(276, 12);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(51, 19);
            radioButton3.TabIndex = 5;
            radioButton3.Text = "Daily";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Click += radioButton3_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(346, 12);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(63, 19);
            radioButton4.TabIndex = 6;
            radioButton4.Text = "Weekly";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.Click += radioButton4_Click;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(432, 12);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(70, 19);
            radioButton5.TabIndex = 7;
            radioButton5.Text = "Monthly";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.Click += radioButton5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 533);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
    }
}