using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;

namespace _05_cine
{
    public partial class MainForm : MaterialForm
    {
        public MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public MainForm()
        {
            InitializeComponent();
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialColorScheme(
                primary: MaterialPrimary.Red400,
                darkPrimary: MaterialPrimary.Red400,
                lightPrimary: MaterialPrimary.Red400,
                accent: MaterialAccent.Red400,
                textShade: MaterialTextShade.LIGHT
            );
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Landing landing = new Landing(this);
            materialSkinManager.AddFormToManage(landing);
            landing.Dock = DockStyle.Fill;
            landing.TopLevel = false;
            landing.FormBorderStyle = FormBorderStyle.None;
            landing.Show();
            MainPanel.Controls.Add(landing);
        }
    }
}
