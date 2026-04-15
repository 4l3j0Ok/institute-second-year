namespace _06_get_set
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        // Variables para mostrar en el form principal, se pueden usar para mostrar los valores de los forms hijos.
        private void btnGetSet_Click(object sender, EventArgs e)
        {
            FormGetSet formGetSet = new FormGetSet(this);
            ShowForm(formGetSet);
        }
        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            FormCheckBox formCheckBox = new FormCheckBox();
            ShowForm(formCheckBox);
        }

        // Método para mostrar un form dentro del panel
        private void ShowForm(Form form)
        {
            // Si la cantidad de controles del panel es mayor a 0, es decir, si hay un form mostrado, lo eliminamos para mostrar el nuevo form.
            if (pForms.Controls.Count > 0)
            {
                // Pero si es el form del mismo tipo no lo eliminamos y retornamos para detener la ejecución del método.
                if (pForms.Controls[0].GetType() == form.GetType())
                    return;
                // Caso contrario, eliminamos el form.
                pForms.Controls.RemoveAt(0);
            }
            // Configuramos el form para mostrarlo dentro del panel.
            form.TopLevel = false; // Esto es necesario para mostrar un form dentro de otro form.
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pForms.Controls.Add(form);
            pForms.Tag = form;
            // Finalmente, mostramos el form.
            form.Show();
        }
    }
}
