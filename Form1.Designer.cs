namespace SimpleCalculator
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
            txtExpression = new TextBox();
            txtResult = new TextBox();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnEqual = new Button();
            btnPlus = new Button();
            SimpleCalculator = new Label();
            SuspendLayout();
            // 
            // txtExpression
            // 
            txtExpression.Location = new Point(147, 89);
            txtExpression.Name = "txtExpression";
            txtExpression.Size = new Size(338, 23);
            txtExpression.TabIndex = 0;
            txtExpression.TextChanged += txtExpression_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(147, 132);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(338, 23);
            txtResult.TabIndex = 1;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // btn0
            // 
            btn0.Location = new Point(233, 392);
            btn0.Name = "btn0";
            btn0.Size = new Size(80, 48);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(147, 338);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 48);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(233, 338);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 48);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(319, 338);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 48);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(147, 284);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 48);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(233, 284);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 48);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(319, 284);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 48);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(147, 230);
            button7.Name = "button7";
            button7.Size = new Size(80, 48);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(233, 230);
            button8.Name = "button8";
            button8.Size = new Size(80, 48);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(319, 230);
            button9.Name = "button9";
            button9.Size = new Size(80, 48);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(405, 392);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(80, 48);
            btnEqual.TabIndex = 12;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(405, 338);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(80, 48);
            btnPlus.TabIndex = 13;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // SimpleCalculator
            // 
            SimpleCalculator.AutoSize = true;
            SimpleCalculator.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            SimpleCalculator.ForeColor = Color.Green;
            SimpleCalculator.Location = new Point(112, 9);
            SimpleCalculator.Name = "SimpleCalculator";
            SimpleCalculator.Size = new Size(410, 65);
            SimpleCalculator.TabIndex = 14;
            SimpleCalculator.Text = "Simple Calculator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 470);
            Controls.Add(SimpleCalculator);
            Controls.Add(btnPlus);
            Controls.Add(btnEqual);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(txtResult);
            Controls.Add(txtExpression);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExpression;
        private TextBox txtResult;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnEqual;
        private Button btnPlus;
        private Label SimpleCalculator;
    }
}
