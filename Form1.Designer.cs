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
            btnMul = new Button();
            btnMinus = new Button();
            btnDiv = new Button();
            btnDel = new Button();
            btnClear = new Button();
            btnClearEntry = new Button();
            btnDot = new Button();
            btnSign = new Button();
            SuspendLayout();
            // 
            // txtExpression
            // 
            txtExpression.BackColor = Color.FromArgb(128, 255, 128);
            txtExpression.Location = new Point(107, 77);
            txtExpression.Multiline = true;
            txtExpression.Name = "txtExpression";
            txtExpression.Size = new Size(378, 40);
            txtExpression.TabIndex = 0;
            txtExpression.TextChanged += txtExpression_TextChanged;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(128, 255, 128);
            txtResult.Location = new Point(107, 123);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(378, 40);
            txtResult.TabIndex = 1;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(192, 255, 255);
            btn0.Location = new Point(203, 441);
            btn0.Name = "btn0";
            btn0.Size = new Size(90, 60);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(192, 255, 255);
            btn1.Location = new Point(107, 375);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 60);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(192, 255, 255);
            btn2.Location = new Point(203, 375);
            btn2.Name = "btn2";
            btn2.Size = new Size(90, 60);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(192, 255, 255);
            btn3.Location = new Point(299, 375);
            btn3.Name = "btn3";
            btn3.Size = new Size(90, 60);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(192, 255, 255);
            btn4.Location = new Point(108, 309);
            btn4.Name = "btn4";
            btn4.Size = new Size(90, 60);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(192, 255, 255);
            btn5.Location = new Point(203, 309);
            btn5.Name = "btn5";
            btn5.Size = new Size(90, 60);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(192, 255, 255);
            btn6.Location = new Point(299, 309);
            btn6.Name = "btn6";
            btn6.Size = new Size(90, 60);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 255, 255);
            button7.Location = new Point(108, 243);
            button7.Name = "button7";
            button7.Size = new Size(90, 60);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(192, 255, 255);
            button8.Location = new Point(203, 243);
            button8.Name = "button8";
            button8.Size = new Size(90, 60);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(192, 255, 255);
            button9.Location = new Point(299, 243);
            button9.Name = "button9";
            button9.Size = new Size(90, 60);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(255, 192, 255);
            btnEqual.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnEqual.ForeColor = Color.Blue;
            btnEqual.Location = new Point(395, 441);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(90, 60);
            btnEqual.TabIndex = 12;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 255, 192);
            btnPlus.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnPlus.ForeColor = Color.Red;
            btnPlus.Location = new Point(395, 375);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(90, 60);
            btnPlus.TabIndex = 13;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // SimpleCalculator
            // 
            SimpleCalculator.AutoSize = true;
            SimpleCalculator.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            SimpleCalculator.ForeColor = Color.Green;
            SimpleCalculator.Location = new Point(92, 9);
            SimpleCalculator.Name = "SimpleCalculator";
            SimpleCalculator.Size = new Size(410, 65);
            SimpleCalculator.TabIndex = 14;
            SimpleCalculator.Text = "Simple Calculator";
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.FromArgb(255, 255, 192);
            btnMul.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnMul.ForeColor = Color.Red;
            btnMul.Location = new Point(395, 243);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(90, 60);
            btnMul.TabIndex = 16;
            btnMul.Text = "×";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += btnMul_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 255, 192);
            btnMinus.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnMinus.ForeColor = Color.Red;
            btnMinus.Location = new Point(395, 309);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(90, 60);
            btnMinus.TabIndex = 17;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(255, 255, 192);
            btnDiv.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnDiv.ForeColor = Color.Red;
            btnDiv.Location = new Point(395, 178);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(90, 60);
            btnDiv.TabIndex = 18;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(192, 255, 255);
            btnDel.Location = new Point(299, 177);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(90, 60);
            btnDel.TabIndex = 19;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 255, 255);
            btnClear.Location = new Point(203, 177);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 60);
            btnClear.TabIndex = 20;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = Color.FromArgb(192, 255, 255);
            btnClearEntry.Location = new Point(107, 178);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(90, 60);
            btnClearEntry.TabIndex = 21;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(192, 255, 255);
            btnDot.Location = new Point(299, 441);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(90, 60);
            btnDot.TabIndex = 22;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.FromArgb(192, 255, 255);
            btnSign.Location = new Point(107, 441);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(90, 60);
            btnSign.TabIndex = 23;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = false;
            btnSign.Click += btnSign_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 513);
            Controls.Add(btnSign);
            Controls.Add(btnDot);
            Controls.Add(btnClearEntry);
            Controls.Add(btnClear);
            Controls.Add(btnDel);
            Controls.Add(btnDiv);
            Controls.Add(btnMinus);
            Controls.Add(btnMul);
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
            Text = "Calculator";
            Load += Form1_Load;
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
        private Button btnMul;
        private Button btnMinus;
        private Button btnDiv;
        private Button btnDel;
        private Button btnClear;
        private Button btnClearEntry;
        private Button btnDot;
        private Button btnSign;
    }
}
