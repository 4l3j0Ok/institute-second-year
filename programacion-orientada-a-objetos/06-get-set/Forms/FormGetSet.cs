using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_get_set
{
    public partial class FormGetSet : Form
    {
        public FormPrincipal parentForm { get; set; }

        public FormGetSet(FormPrincipal parentform)
        {
            InitializeComponent();
            this.parentForm = parentform;
        }

        private void tbValues_TextChanged(object sender, EventArgs e)
        {
            Variables.value1 = tbValue1.Text;
            Variables.value2 = tbValue2.Text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.parentForm.tbValue1.Text = Variables.value1;
            this.parentForm.tbValue2.Text = Variables.value2;
        }

        private void btnTransfer_click(object sender, EventArgs e)
        {
            Greeter greeter = new Greeter();
            greeter.Name = tbRaw.Text;
            tbGreeting.Text = greeter.Name;
        }

    }
    public class Greeter {
        // Creamos un campo PRIVADO (solo accesible desde los métodos de esta clase) para almacenar el valor del nombre con el saludo.
        private string PName = "";
        // Creamos una propiedad PÚBLICA (se puede acceder desde cualquier instancia de esta clase)
        // para obtener y establecer el valor del saludo + nombre.
        public string Name
        {
            get { return PName; }
            set { PName = $"Hola, {value}"; }
        }
    }
}
