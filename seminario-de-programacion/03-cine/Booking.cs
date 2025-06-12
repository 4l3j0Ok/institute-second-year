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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_cine
{
    public partial class Booking : UserControl
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
            string movieName = string.Empty;
            foreach (Control ctrl in button.Parent.Controls)
            {
                if (ctrl is Label label)
                    movieName = label.Text;
            }
            Reservation.MovieName = movieName;
            LoadSummary();
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

        private void rbPaymentMethod_CheckedChanged(object sender, EventArgs e)
        {
            MaterialRadioButton radioButton = (MaterialRadioButton)sender;
            if (radioButton.Name == rbCreditCard.Name || radioButton.Name == rbDebitCard.Name)
            {
                pnlPayWithCard.Visible = true;
                pnlPayWithCommerce.Visible = false;
                pnlPayWithMP.Visible = false;
            }
            else if (radioButton.Name == rbMP.Name)
            {
                pnlPayWithCard.Visible = false;
                pnlPayWithCommerce.Visible = false;
                pnlPayWithMP.Visible = true;
            }
            else if (radioButton.Name == rbCommerce.Name)
            {
                pnlPayWithCard.Visible = false;
                pnlPayWithCommerce.Visible = true;
                pnlPayWithMP.Visible = false;
            }
            Reservation.PaymentMethod = radioButton.Text;
            LoadSummary();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            LoadCbRoomType();
            LoadCbHour();
            LoadExpiration();
            LoadCbTotalSeats();
            LoadSummary();
        }

        private void LoadCbHour()
        {
            for (int i = 07; i <= 23; i += 2)
            {
                for (int j = 0; j < 60; j += 30)
                {
                    string hour = i.ToString("D2") + ":" + j.ToString("D2");
                    cbHour.Items.Add(hour);
                }
            }
        }

        private void LoadCbRoomType()
        {
            for (int i = 2; i <= 4; i++)
            {
                cbRoomType.Items.Add("Sala " + i + "D");
            }
        }

        private void LoadExpiration()
        {
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear; year <= currentYear + 10; year++)
                cbCardExpirationYear.Items.Add(year);
            for (int month = 1; month <= 12; month++)
                cbCardExpirationMonth.Items.Add(month.ToString("D2"));
        }

        private void LoadCbTotalSeats()
        {
            for (int i = 1; i <= 10; i++)
            {
                cbTotalSeats.Items.Add(i);
            }
        }

        private void LoadSummary()
        {
            lblSummaryMovie.Text = $"Película: {Reservation.MovieName}";
            lblSummaryRoomType.Text = $"Tipo de sala: {Reservation.RoomType}";
            lblSummaryDate.Text = $"Fecha: {Reservation.Date}";
            lblSummaryHour.Text = $"Hora: {Reservation.Hour}";
            if (Reservation.TotalSeats > 0)
                lblSummaryTotalSeats.Text = $"Cantidad de asientos: {Reservation.TotalSeats}";
            if (Reservation.SelectedSeats.Count > 0)
                lblSummarySelectedSeats.Text = "Asientos seleccionados: " + string.Join(", ", Reservation.SelectedSeats);
            lblSummaryName.Text = $"Nombre: {Reservation.Name}";
            lblSummarySurname.Text = $"Apellido: {Reservation.Surname}";
            lblSummaryDNI.Text = $"DNI: {Reservation.DNI}";
            lblSummaryEmail.Text = $"Email: {Reservation.Email}";
            lblSummaryPhone.Text = $"Teléfono: {Reservation.Phone}";
            lblSummaryPaymentMethod.Text = $"Método de pago: {Reservation.PaymentMethod}";
            if (IsFormComplete()) btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }

        private bool IsFormComplete()
        {
            bool isComplete = false;
            if (!string.IsNullOrEmpty(Reservation.MovieName) &&
                !string.IsNullOrEmpty(Reservation.RoomType) &&
                !string.IsNullOrEmpty(Reservation.Date) &&
                !string.IsNullOrEmpty(Reservation.Hour) &&
                Reservation.TotalSeats > 0 &&
                Reservation.SelectedSeats.Count > 0 &&
                !string.IsNullOrEmpty(Reservation.Name) &&
                !string.IsNullOrEmpty(Reservation.Surname) &&
                !string.IsNullOrEmpty(Reservation.DNI) &&
                !string.IsNullOrEmpty(Reservation.Email) &&
                !string.IsNullOrEmpty(Reservation.Phone) &&
                !string.IsNullOrEmpty(Reservation.PaymentMethod) &&
                Reservation.ToSAccepted)
            {
                if (Reservation.PaymentMethod == "Tarjeta de crédito" || Reservation.PaymentMethod == "Tarjeta de débito")
                {
                    isComplete = !string.IsNullOrEmpty(Reservation.CardNumber) &&
                                !string.IsNullOrEmpty(Reservation.CardHolder) &&
                                !string.IsNullOrEmpty(Reservation.CardCVV) &&
                                !string.IsNullOrEmpty(Reservation.CardExpirationMonth) &&
                                !string.IsNullOrEmpty(Reservation.CardExpirationYear);
                }
                else
                {
                    isComplete = true;
                }
            }
            return isComplete;
        }
        private void btnSeat_Click(object sender, EventArgs e)
        {
            if (Reservation.TotalSeats == 0)
            {
                MessageBox.Show(
                    "Por favor, selecciona en la sección \"Películas\" selecciona la cantidad de asientos.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            MaterialButton button = (MaterialButton)sender;
            if (button.Tag != null && button.Tag.ToString() == "selected")
            {
                button.Type = MaterialButton.MaterialButtonType.Contained;
                button.Tag = null;
                Reservation.SelectedSeats.Remove(button.Text);
                LoadSummary();
                return;
            }
            if (Reservation.SelectedSeats.Count == Reservation.TotalSeats)
            {
                MessageBox.Show("Ya has seleccionado el número máximo de asientos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            button.Type = MaterialButton.MaterialButtonType.Outlined;
            button.Tag = "selected";
            Reservation.SelectedSeats.Add(button.Text);
            LoadSummary();
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reservation.RoomType = cbRoomType.SelectedItem?.ToString() ?? string.Empty;
            LoadSummary();
        }

        private void cbTotalSeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reservation.TotalSeats = cbTotalSeats.SelectedItem != null ? Convert.ToInt32(cbTotalSeats.SelectedItem) : 0;
            Reservation.SelectedSeats.Clear();
            foreach (Control ctrl in tlpSeats.Controls)
            {
                if (ctrl is MaterialButton button && button.Tag != null && button.Tag.ToString() == "selected")
                {
                    button.Type = MaterialButton.MaterialButtonType.Contained;
                    button.Tag = null;
                    Reservation.SelectedSeats.Remove(button.Text);
                }
            }
            LoadSummary();
        }

        private void cbHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reservation.Hour = cbHour.SelectedItem?.ToString() ?? string.Empty;
            LoadSummary();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            Reservation.Date = dtpDate.Value.ToString("yyyy-MM-dd");
            LoadSummary();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            Reservation.Name = tbName.Text.Trim();
            LoadSummary();
        }

        private void tbSurname_TextChanged(object sender, EventArgs e)
        {
            Reservation.Surname = tbSurname.Text.Trim();
            LoadSummary();
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            Reservation.DNI = tbDNI.Text.Trim();
            LoadSummary();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            Reservation.Email = tbEmail.Text.Trim();
            LoadSummary();
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            Reservation.Phone = tbPhone.Text.Trim();
            LoadSummary();
        }

        private void tbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^\d{0,8}$");
            if (!regex.IsMatch(tbDNI.Text + e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^\d{0,13}$");
            if (!regex.IsMatch(tbPhone.Text + e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbCardNumber_TextChanged(object sender, EventArgs e)
        {
            Reservation.CardNumber = tbCardNumber.Text.Trim();
            LoadSummary();
        }

        private void tbCardHolder_TextChanged(object sender, EventArgs e)
        {
            Reservation.CardHolder = tbCardHolder.Text.Trim();
            LoadSummary();
        }

        private void tbCardCVV_TextChanged(object sender, EventArgs e)
        {
            Reservation.CardCVV = tbCardCVV.Text.Trim();
            LoadSummary();
        }

        private void cbCardExpirationMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reservation.CardExpirationMonth = cbCardExpirationMonth.SelectedItem?.ToString() ?? string.Empty;
            LoadSummary();
        }

        private void cbCardExpirationYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reservation.CardExpirationYear = cbCardExpirationYear.SelectedItem?.ToString() ?? string.Empty;
            LoadSummary();
        }
        private void cbToS_CheckedChanged(object sender, EventArgs e)
        {
            Reservation.ToSAccepted = cbToS.Checked;
            LoadSummary();
        }
        private void btnCopyCommerceCode_Click(object sender, EventArgs e)
        {
            string textToCopy = lblCommerceCode.Text;
            Clipboard.SetText(textToCopy);
            MessageBox.Show(
                "Código de comercio copiado al portapapeles.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void linkLblToS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string tosPlain = File.ReadAllText("tos.md");
            MessageBox.Show(
                tosPlain,
                "Términos y condiciones",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            mainForm.MainPanel.Controls.Clear();
            SuccessPurchase successPurchase = new SuccessPurchase(mainForm);
            successPurchase.Dock = DockStyle.Fill;
            successPurchase.Show();

            mainForm.MainPanel.Controls.Add(successPurchase);
        }
    }
}
