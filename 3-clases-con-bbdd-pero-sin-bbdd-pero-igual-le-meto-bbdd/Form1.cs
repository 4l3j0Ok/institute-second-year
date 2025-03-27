

namespace _3_clases_con_bbdd_pero_sin_bbdd_pero_igual_le_meto_bbdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Funciones.CreateBaseTables();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
