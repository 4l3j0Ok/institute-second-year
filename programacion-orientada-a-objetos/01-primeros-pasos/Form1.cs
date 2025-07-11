using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;
using System.Diagnostics;

namespace _1_primeros_pasos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void onBtnClick(object sender, EventArgs e)
        {
            if (IsNumeric((Button)sender))
            {
                tbCalc.Text += ((Button)sender).Text;
            }
            else if (IsOperator((Button)sender))
            {
                PutOperator(((Button)sender).Text);
            }
            else if (IsEqual((Button)sender))
            {
                try
                {
                    if (IsStrOperator(tbCalc.Text.Substring(tbCalc.Text.Length - 1))) return;
                    var result = Calculate(tbCalc.Text);
                    tbCalc.Text = result.ToString();
                }
                catch (DivideByZeroException ex)
                {
                    Debug.WriteLine($"{ex.Message}");
                    tbCalc.Text = "Error: No se puede dividir por cero";
                }
            }
            else if (IsClearAll((Button)sender))
            {
                ClearAll();
            }
            else if (IsRem((Button)sender))
            {
                Rem();
            }
        }
        public bool IsNumeric(Button btn)
        {
            return int.TryParse(btn.Text, out _);
        }

        public bool IsOperator(Button btn)
        {
            return btn.Equals(btnPlus) || btn.Equals(btnMinus) || btn.Equals(btnMultiplcation) || btn.Equals(btnDivision) || btn.Equals(btnDot);
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

        public bool IsStrOperator(string value)
        {
            return value == "+" || value == "-" || value == "*" || value == "/" || value == ".";
        }

        public string Calculate(string expression)
        {
            expression = expression.Replace(",", ".").Replace("MOD", "%");
            var result = new DataTable().Compute(expression, null);
            return result.ToString().Replace(",", ".");
        }

        public void ClearAll()
        {
            tbCalc.Text = "";
        }

        public void Rem()
        {
            if (tbCalc.Text.Length > 0)
                tbCalc.Text = tbCalc.Text.Remove(tbCalc.Text.Length - 1);
        }

        public void PutOperator(string value)
        {
            if (string.IsNullOrEmpty(tbCalc.Text)) return;
            if (value == "." && tbCalc.Text.Contains(".")) return;
            if (IsStrOperator(tbCalc.Text.Substring(tbCalc.Text.Length - 1)))
                tbCalc.Text = tbCalc.Text.Remove(tbCalc.Text.Length - 1);
            tbCalc.Text += value;
        }
    }
}
