namespace _05_cine
{
    public static class Reservation
    {
        public static string MovieName { get; set; } = "";
        public static string RoomType { get; set; } = "";
        public static string Date { get; set; } = "";
        public static string Hour { get; set; } = "";
        public static int TotalSeats { get; set; } = 0;
        public static List<string> SelectedSeats { get; set; } = new List<string>();
        public static string Name { get; set; } = "";
        public static string Surname { get; set; } = "";
        public static string DNI { get; set; } = "";
        public static string Email { get; set; } = "";
        public static string Phone { get; set; } = "";
        public static string PaymentMethod { get; set; } = "";
        public static string CardNumber { get; set; } = "";
        public static string CardExpirationMonth { get; set; } = "";
        public static string CardExpirationYear { get; set; } = "";
        public static string CardCVV { get; set; } = "";
        public static string CardHolder { get; set; } = "";
        public static bool ToSAccepted { get; set; } = false;

        public static void ClearReservation()
        {
            MovieName = "";
            RoomType = "";
            Date = "";
            Hour = "";
            TotalSeats = 0;
            SelectedSeats.Clear();
            Name = "";
            Surname = "";
            DNI = "";
            Email = "";
            Phone = "";
            PaymentMethod = "";
            CardNumber = "";
            CardExpirationMonth = "";
            CardExpirationYear = "";
            CardCVV = "";
            CardHolder = "";
            ToSAccepted = false;
        }
    }
}
