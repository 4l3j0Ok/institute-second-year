namespace _05_clases_abstractas_herencia_polimorfismo_override
{
    public partial class Form1 : Form
    {
        private List<Saludo> greeters = new List<Saludo>() {
            new Robot(),
            new Perro(),
            new Gato(),
            new Alien(),
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupCombo();
        }

        private void SetupCombo()
        {
            foreach (Saludo greeter in greeters) {
                cbGreetingsType.Items.Add(greeter.GetType().Name);
            }
            cbGreetingsType.SelectedIndex = 0;
        }

        private void cbGreetingsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = greeters[cbGreetingsType.SelectedIndex].Saludar();
            //MessageBox.Show(greeters[cbGreetingsType.SelectedIndex].Saludar());
        }
    }

    // Clase abstracta. Sirven para definir una interfaz común para las clases derivadas.
    public abstract class Saludo
    {
        // Método abstracto. No tiene implementación en la clase base.
        // Las clases derivadas deben implementar este método.
        public abstract string Saludar();
    }
    public class Robot : Saludo
    {
        public override string Saludar() => "🤖: Hola, humano.";
    }

    public class Perro: Saludo
    {
        public override string Saludar() => "🐶: Guau guau.";
    }
    public class Gato : Saludo
    {
        public override string Saludar() => "🐱: Miau miau.";
    }
    public class Alien : Saludo
    {
        public override string Saludar() => "👽: Hola, humanoide.";
    }
}

