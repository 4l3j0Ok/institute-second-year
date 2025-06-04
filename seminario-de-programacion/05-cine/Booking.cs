using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
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

namespace _05_cine
{
    public partial class Booking : MaterialForm
    {
        private MainForm mainForm;
        public Booking(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void linkLabel_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string tosPlain = File.ReadAllText("tos.md");
            MessageBox.Show(
                tosPlain, 
                "Términos y condiciones", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MaterialButton selectedButton = (MaterialButton)sender;
            bool isSelected = selectedButton.Tag != null && selectedButton.Tag.ToString() == "selected";
            if (isSelected)
            {
                deselectButton(selectedButton);
                return;
            }
            selectButton(selectedButton);
            deselectAllButtons(excludedButton: selectedButton);
        }

        private void selectButton(MaterialButton button)
        {
            button.Text = "Seleccionado";
            button.Type = MaterialButton.MaterialButtonType.Outlined;
            button.Tag = "selected";
        }
        private void deselectButton(MaterialButton button)
        {
            button.Text = "Seleccionar";
            button.Type = MaterialButton.MaterialButtonType.Contained;
            button.Tag = null;
        }
        private void deselectAllButtons(MaterialButton excludedButton = null)
        {
            foreach (Control ctrl in flpMovies.Controls)
            {
                foreach (Control chCtrl in ctrl.Controls)
                {
                    if (chCtrl is MaterialButton && chCtrl != excludedButton)
                        deselectButton((MaterialButton)chCtrl);
                }
            }
        }
    }
}
