using OxyPlot;
using OxyPlot.Series;

namespace _07_tp_analisis_matematico
{
    public partial class FormPrincipal : Form
    {
        private PlotModel plotModel = new PlotModel { Title = "Polinomio y Derivada" };
        private LineSeries lineaFuncion = new LineSeries { Color = OxyColors.Blue };
        private LineSeries lineaDerivada = new LineSeries { Color = OxyColors.Red };
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            plotView.Model = plotModel;
            plotModel.Series.Add(lineaFuncion);
            plotModel.Series.Add(lineaDerivada);
        }
        private void btnDerivar_Click(object sender, EventArgs e)
        {
            List<double> coeficientes = new List<double>();
            foreach (string coef in tbCoeficientes.Text.Split(','))
            {
                if (double.TryParse(coef.Trim(), out double valor))
                    coeficientes.Add(valor);
                else
                {
                    MessageBox.Show("Por favor, ingrese coeficientes válidos separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Polynomial polinomio = new Polynomial(coeficientes);
            Polynomial derivada = polinomio.Derivate();
            lineaFuncion.Points.Clear();
            lineaDerivada.Points.Clear();
            lineaFuncion.Title = polinomio.ToString();
            lineaDerivada.Title = derivada.ToString();
            // Evaluamos los puntos de la función y su derivada
            for (double x = -10; x <= 10; x += 0.1) // 
            {
                double yFuncion = 0;
                double yDerivada = 0;
                for (int i = 0; i < coeficientes.Count; i++)
                {
                    yFuncion += coeficientes[i] * Math.Pow(x, coeficientes.Count - 1 - i);
                    if (i < coeficientes.Count - 1) // Evitamos el último coeficiente que es el término independiente
                        yDerivada += coeficientes[i] * (coeficientes.Count - 1 - i) * Math.Pow(x, coeficientes.Count - 2 - i);
                }
                lineaFuncion.Points.Add(new DataPoint(x, yFuncion));
                lineaDerivada.Points.Add(new DataPoint(x, yDerivada));
            }
            // El \n por alguna razón en el subtítulo no funciona. Si te daña la vista, podes cerrar los ojos.
            plotModel.Subtitle = @$"f(x): {polinomio}
f'(x): {derivada}";
            plotModel.InvalidatePlot(true);
        }
    }
}
