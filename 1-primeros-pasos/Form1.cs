namespace _1_primeros_pasos
{
    public partial class FrmPrincipal : Form
    {
        decimal previousValue = 0;
        decimal currentValue = 0;
        string op = "";
        public FrmPrincipal()
        {
            InitializeComponent();
            this.previousValue = previousValue;
            this.currentValue = currentValue;
            this.op = op;
        }

        private void onBtnClick(object sender, EventArgs e)
        {
            if (IsNumeric(((Button)sender).Text))
            {
                tbCalc.Text += ((Button)sender).Text;
            }
            if (IsOperator(((Button)sender).Text))
            {
                this.op = ((Button)sender).Text;
                this.previousValue = decimal.Parse(tbCalc.Text);
                tbPreviousValue.Text = tbCalc.Text;
                tbCalc.Text = "";
            }
            if (((Button)sender).Text == "=")
            {
                tbPreviousValue.Text = "";
                this.currentValue = decimal.Parse(tbCalc.Text);
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
            switch (this.op)
            {
                case "+":
                    result = this.previousValue + this.currentValue;
                    break;
                case "-":
                    result = this.previousValue - this.currentValue;
                    break;
                case "*":
                    result = this.previousValue * this.currentValue;
                    break;
                case "/":
                    result = this.previousValue / this.currentValue;
                    break;
            }
            this.previousValue = result;
            tbCalc.Text = Convert.ToString(result);
        }

    }
}
