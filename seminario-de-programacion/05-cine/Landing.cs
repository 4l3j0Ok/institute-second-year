using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;
namespace _05_cine
{
    public partial class Landing : MaterialForm
    {
        private MainForm mainForm;
        public Landing(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void btnViewBillboard_Click(object sender, EventArgs e)
        {
            //gets current instance of MainForm:
            mainForm.MainPanel.Controls.Clear();
            Booking booking = new Booking(mainForm);
            mainForm.materialSkinManager.AddFormToManage(booking);
            booking.Dock = DockStyle.Fill;
            booking.TopLevel = false;
            booking.Show();
            mainForm.MainPanel.Controls.Add(booking);
        }
    }
}
