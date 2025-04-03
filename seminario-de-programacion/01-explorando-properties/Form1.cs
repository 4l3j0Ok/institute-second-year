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
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o un control, cancelamos el evento
                e.Handled = true;
            }
        }
        private void Calculate(object sender, EventArgs e)
        {
            int result = 0;
            int vuelto2000 = 0;
            int vuelto1000 = 0;
            int vuelto500 = 0;
            int vuelto200 = 0;
            int vuelto100 = 0;
            int vuelto50 = 0;

            if (tbFirstValue.Text == "") return;
            if (tbSecondValue.Text == "") return;
            result = int.Parse(tbFirstValue.Text) - int.Parse(tbSecondValue.Text);
            if (result < 0) result = 0;
            tbVuelto.Text = result.ToString();
        }
    }
}
