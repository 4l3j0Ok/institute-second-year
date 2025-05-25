namespace _06_get_set
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnGetSet_Click(object sender, EventArgs e)
        {
            FormGetSet formGetSet = new FormGetSet();
            if (pForms.Controls.Count > 0)
            {
                // Si es el form del mismo tipo no lo eliminamos
                if (pForms.Controls[0].GetType() == formGetSet.GetType())
                    return;
                pForms.Controls.RemoveAt(0);
            }
            formGetSet.TopLevel = false;
            formGetSet.FormBorderStyle = FormBorderStyle.None;
            formGetSet.Dock = DockStyle.Fill;
            pForms.Controls.Add(formGetSet);
            pForms.Tag = formGetSet;
            formGetSet.Show();
        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            FormCheckBox formCheckBox = new FormCheckBox();
            if (pForms.Controls.Count > 0)
            {
                // Si es el form del mismo tipo no lo eliminamos
                if (pForms.Controls[0].GetType() == formCheckBox.GetType())
                    return;
                pForms.Controls.RemoveAt(0);
            }
            formCheckBox.TopLevel = false;
            formCheckBox.FormBorderStyle = FormBorderStyle.None;
            formCheckBox.Dock = DockStyle.Fill;
            pForms.Controls.Add(formCheckBox);
            pForms.Tag = formCheckBox;
            formCheckBox.Show();
        }
    }
}
