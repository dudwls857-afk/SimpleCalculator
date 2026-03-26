namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        Double num1 = 0;
        string op = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "+";
        }

        private void txtExpression_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "9";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                string expr = txtExpression.Text;

                expr = expr.Replace("×", "*").Replace("÷", "/");

                var result = new System.Data.DataTable().Compute(expr, "");

                txtExpression.Text = txtExpression.Text + "=" + result.ToString();
                txtResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("계산 오류");
            }
        }


        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "÷";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "×";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExpression.Text = "";
            txtResult.Text = "";
            num1 = 0;
            op = "";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            string expr = txtExpression.Text;

            if (string.IsNullOrEmpty(expr))
                return;

            int lastOpIndex = expr.LastIndexOfAny(new char[] { '+', '-', '×', '÷', '*', '/' });

            if (lastOpIndex == -1)
            {
                txtExpression.Text = "";
            }
            else
            {
                txtExpression.Text = expr.Substring(0, lastOpIndex + 1);
            }

            txtResult.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Length > 0)
            {
                txtExpression.Text = txtExpression.Text.Substring(0, txtExpression.Text.Length - 1);
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string expr = txtExpression.Text;

            if (string.IsNullOrEmpty(expr))
                return;

            // 마지막 연산자 위치 찾기
            int lastOpIndex = expr.LastIndexOfAny(new char[] { '+', '-', '×', '÷', '*', '/' });

            if (lastOpIndex == -1)
            {
                // 숫자 하나만 있을 때
                if (expr.StartsWith("-"))
                    txtExpression.Text = expr.Substring(1);
                else
                    txtExpression.Text = "-" + expr;
            }
            else
            {
                // 마지막 숫자 부분만 가져오기
                string left = expr.Substring(0, lastOpIndex + 1);
                string right = expr.Substring(lastOpIndex + 1);

                // 부호 변경
                if (right.StartsWith("-"))
                    right = right.Substring(1);
                else
                    right = "-" + right;

                txtExpression.Text = left + right;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtExpression.Text.Contains("."))
            {
                txtExpression.Text += ".";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            txtExpression.Text += "(";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtExpression.Text += ")";
        }
    }
}
