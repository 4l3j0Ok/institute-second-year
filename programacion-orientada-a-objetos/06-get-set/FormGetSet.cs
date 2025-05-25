using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_get_set
{
    public partial class FormGetSet : Form
    {
        public FormGetSet()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Variables.value1 = tbValue1.Text;
            Variables.value2 = tbValue2.Text;
            FormPrincipal.tbValue1.Text = Variables.value1;
            FormPrincipal.tbValue2.Text = Variables.value2;
        }

        private void btnTransfer_click(object sender, EventArgs e)
        {
            Pretty prettifier = new Pretty();
            prettifier.name = tbRaw.Text;
            tbPretty.Text = prettifier.name;
        }

    }
    public class Pretty {
        private string pname = "";
        public string name
        {
            get { return pname; }
            set { pname = $"Hola, {value}"; }
        }
    }
}
