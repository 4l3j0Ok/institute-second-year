using System.Diagnostics;


namespace _01_explorando_properties
{
    public partial class CalcularVuelto : Form
    {
        public CalcularVuelto()
        {
            InitializeComponent();
        }

        private void TextboxHandler(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Calculate(object sender, EventArgs e)
        {
            double result = 0;
            if (tbFirstValue.Text == "") return;
            if (tbSecondValue.Text == "") return;
            result = int.Parse(tbFirstValue.Text) - int.Parse(tbSecondValue.Text);
            if (result < 0) result = result;
            tbResult.Text = result.ToString();
        }

        private void x(object sender, EventArgs e)
        {

        }
    }
}
