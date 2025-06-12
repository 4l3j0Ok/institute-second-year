using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;

namespace _03_cine
{
    public partial class MainForm : MaterialForm
    {
        public MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public MainForm()
        {
            InitializeComponent();
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialColorScheme(
                primary: MaterialPrimary.Red800,
                darkPrimary: MaterialPrimary.Red800,
                lightPrimary: MaterialPrimary.Red800,
                accent: MaterialAccent.Red400,
                textShade: MaterialTextShade.LIGHT
            );
            this.MinimumSize = new Size(900, 600);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Landing landing = new Landing(this);
            landing.Dock = DockStyle.Fill;
            landing.AutoScroll = true;
            landing.Show();
            MainPanel.Controls.Add(landing);
        }
    }
}
