using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _03_cine
{
    public partial class SuccessPurchase : UserControl
    {
        private MainForm mainForm;
        public SuccessPurchase(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnGetTickets_Click(object sender, EventArgs e)
        {
            string html = File.ReadAllText("ticket_template.html");
            string randomId = Guid.NewGuid().ToString().ToUpper();
            html = html.Replace("{{MovieName}}", Reservation.MovieName)
                    .Replace("{{RoomType}}", Reservation.RoomType)
                    .Replace("{{Date}}", Reservation.Date)
                    .Replace("{{Hour}}", Reservation.Hour)
                    .Replace("{{TotalSeats}}", Reservation.TotalSeats.ToString())
                    .Replace("{{SelectedSeats}}", string.Join(", ", Reservation.SelectedSeats))
                    .Replace("{{Name}}", Reservation.Name)
                    .Replace("{{Surname}}", Reservation.Surname)
                    .Replace("{{DNI}}", Reservation.DNI)
                    .Replace("{{Email}}", Reservation.Email)
                    .Replace("{{Phone}}", Reservation.Phone)
                    .Replace("{{PaymentMethod}}", Reservation.PaymentMethod)
                    .Replace("{{PurchaseId}}", randomId);
            File.WriteAllText("ticket.html", html);
            Process.Start(new ProcessStartInfo("ticket.html") { UseShellExecute = true });
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Reservation.ClearReservation();
            mainForm.MainPanel.Controls.Clear();
            Landing landing = new Landing(this.mainForm);
            landing.Dock = DockStyle.Fill;
            landing.AutoScroll = true;
            landing.Show();
            mainForm.MainPanel.Controls.Add(landing);
        }
    }
}
