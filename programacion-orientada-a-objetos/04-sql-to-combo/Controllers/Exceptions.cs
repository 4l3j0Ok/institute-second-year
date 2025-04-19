namespace _04_sql_to_combo.Controllers
{
    internal class MessageException : Exception
    {
        public MessageException(string message = "")
        {
            MessageBox.Show(message);
        }
    }
}
