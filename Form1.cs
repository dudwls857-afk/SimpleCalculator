namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int num1 = 0;
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
            string[] parts = txtExpression.Text.Split('+');

            int n1 = int.Parse(parts[0]);
            int n2 = int.Parse(parts[1]);

            int result = n1 + n2;

            txtExpression.Text = txtExpression.Text + "=" + result.ToString();
            txtResult.Text = result.ToString();
        }
    }
}
