using MaterialSkin.Controls;
using System.Data;

//import debug
using System.Diagnostics;

namespace _1_primeros_pasos
{
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void onBtnClick(object sender, EventArgs e)
        {
            if (IsNumeric((Button)sender) || IsOperator((Button)sender))
            {
                tbCalc.Text += ((Button)sender).Text;
            }
            else if (IsEqual((Button)sender))
            {
                try
                {
                    var result = Calculate(tbCalc.Text);
                    tbCalc.Text = result.ToString();
                }
                catch (DivideByZeroException ex)
                {
                    tbCalc.Text = "Error: No se puede dividir por cero";
                }
            }
            else if (IsClearAll((Button)sender))
            {
                ClearAll();
            }
        }
        public bool IsNumeric(Button btn)
        {
            return int.TryParse(btn.Text, out _);
        }

        public bool IsOperator(Button btn)
        {
            return btn.Equals(btnPlus) || btn.Equals(btnMinus) || btn.Equals(btnMultiplcation) || btn.Equals(btnDivision) || btn.Equals(btnPercent) || btn.Equals(btnComma);

        }

        public bool IsEqual(Button btn)
        {
            return btn.Equals(btnEqual);
        }

        public bool IsClearAll(Button btn)
        {
            return btn.Equals(btnClearAll);
        }

        public bool IsRem(Button btn)
        {
            return btn.Equals(btnRem);
        }

        public bool IsClearCurrent(Button btn)
        {
            return btn.Equals(btnClearCurrent);
        }

        public dynamic Calculate(string expression)
        {
            expression = expression.Replace(",", ".");
            var result = new DataTable().Compute(expression, null);
            return result;
        }


        public void ClearAll()
        {
            tbCalc.Text = "";
        }
    }
}
