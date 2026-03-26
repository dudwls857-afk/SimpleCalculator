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
            num1 = int.Parse(txtExpression.Text);
            op = "+";
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
            string[] parts;

            if (op == "+") parts = txtExpression.Text.Split('+');
            else if (op == "-") parts = txtExpression.Text.Split('-');
            else if (op == "*") parts = txtExpression.Text.Split('*');
            else parts = txtExpression.Text.Split('/');

            Double n1 = Double.Parse(parts[0]);
            Double n2 = Double.Parse(parts[1]);

            Double result = 0;

            if (op == "+") result = n1 + n2;
            else if (op == "-") result = n1 - n2;
            else if (op == "*") result = n1 * n2;
            else if (op == "/") result = n1 / n2;

            txtExpression.Text = txtExpression.Text + "=" + result.ToString();
            txtResult.Text = result.ToString();
        }


        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(txtExpression.Text);
            op = "/";
            txtExpression.Text += "/";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(txtExpression.Text);
            op = "-";
            txtExpression.Text += "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(txtExpression.Text);
            op = "*";
            txtExpression.Text += "*";
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
            txtExpression.Text = "";
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
            if (txtExpression.Text != "")
            {
                if (txtExpression.Text.StartsWith("-"))
                {
                    txtExpression.Text = txtExpression.Text.Substring(1);
                }
                else
                {
                    txtExpression.Text = "-" + txtExpression.Text;
                }
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
    }
}
