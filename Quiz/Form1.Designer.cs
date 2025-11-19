namespace Quiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnSubmit;

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

        private void InitializeComponent()
        {
            lblQuestion = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            lblTimer = new Label();
            btnSubmit = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQuestion.Location = new Point(26, 28);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(375, 44);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question Text";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(31, 75);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(71, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Option 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(31, 103);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Option 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(31, 131);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(71, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Option 3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(31, 159);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(71, 19);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Option 4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 10F);
            lblTimer.Location = new Point(26, 197);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(94, 19);
            lblTimer.TabIndex = 5;
            lblTimer.Text = "Time Left: 10s";
            lblTimer.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(31, 234);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(88, 28);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(31, 75);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(110, 103);
            lblResult.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 300);
            Controls.Add(btnSubmit);
            Controls.Add(lblTimer);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(lblQuestion);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Quiz Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
    }
}
