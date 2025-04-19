using _04_sql_to_combo.Controllers;
using System.Data;

namespace _04_sql_to_combo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Combo.CreateInitialTables();
            Combo.InsertInitialData();
        }

        private void btnLoadComboClick(object sender, EventArgs e)
        {
            if (cbData.Items.Count > 0) return;
            DataTable dt = Combo.GetData();
            foreach (DataRow row in dt.Rows)
                cbData.Items.Add(row["elemento"]);
        }

        private void btnUnloadComboClick(object sender, EventArgs e)
        {
            cbData.Items.Clear();
        }

        private void btnHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = ColorTranslator.FromHtml("#4654c0");
        }

        private void btnHoverLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = ColorTranslator.FromHtml("#121214");
        }
    }
}
