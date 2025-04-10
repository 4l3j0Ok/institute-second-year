using System.Diagnostics;
using System.Numerics;


namespace _01_calcular_vuelto
{
    public partial class CalculateRest : Form
    {
        public CalculateRest()
        {
            InitializeComponent();
        }

        private void TextboxHandler(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Calculate(object sender, EventArgs e)
        {
            int result;
            int rest;
            if (String.IsNullOrEmpty(tbFirstValue.Text) || String.IsNullOrEmpty(tbSecondValue.Text))
            {
                tbRest.Text = "0";
                tbRest2000.Text = "0";
                tbRest1000.Text = "0";
                tbRest500.Text = "0";
                tbRest200.Text = "0";
                tbRest100.Text = "0";
                tbRest50.Text = "0";
                return;
            }
            result = int.Parse(tbFirstValue.Text) - int.Parse(tbSecondValue.Text);
            if (result < 0) result = 0;
            tbRest.Text = result.ToString();
            tbRest2000.Text = GetBills(result, 2000).ToString();
            rest = GetRest(result, 2000);
            tbRest1000.Text = GetBills(rest, 1000).ToString();
            rest = GetRest(rest, 1000);
            tbRest500.Text = GetBills(rest, 500).ToString();
            rest = GetRest(rest, 500);
            tbRest200.Text = GetBills(rest, 200).ToString();
            rest = GetRest(rest, 200);
            tbRest100.Text = GetBills(rest, 100).ToString();
            rest = GetRest(rest, 100);
            tbRest50.Text = GetBills(rest, 50).ToString();
        }

        static private int GetBills(int initialValue, int billValue)
        {
            return initialValue / billValue;
        }
        static private int GetRest(int initialValue, int billValue)
        {
            return initialValue % billValue;
        }
    }
}
