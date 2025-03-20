namespace _1_primeros_pasos
{
    public partial class FrmPrincipal : Form
    {
        decimal previousValue = 0;
        decimal currentValue = 0;
        string op = "+";
        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void onBtnClick(object sender, EventArgs e)
        {
            if (IsNumeric(((Button)sender).Text))
            {
                tbCalc.Text += ((Button)sender).Text;
            }
            if (IsOperator(((Button)sender).Text))
            {
                tbPreviousValue.Text = tbCalc.Text;
                previousValue = decimal.Parse(tbCalc.Text);
                op = ((Button)sender).Text;
                tbCalc.Text = "";
            }
            if (((Button)sender).Text == "=")
            {
                tbPreviousValue.Text = "";
                currentValue = decimal.Parse(tbCalc.Text);
                Calculate();
            }
                
        }
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public bool IsOperator(string value)
        {
            return value == "+" || value == "-" || value == "*" || value == "/";
        }

        public void Calculate() {
            decimal result = 0;
            switch (op)
            {
                case "+":
                    result = previousValue + currentValue;
                    break;
                case "-":
                    result = previousValue - currentValue;
                    break;
                case "*":
                    result = previousValue * currentValue;
                    break;
                case "/":
                    result = previousValue / currentValue;
                    break;
            }
            previousValue = result;
            tbCalc.Text = Convert.ToString(result);
        }

    }
}
