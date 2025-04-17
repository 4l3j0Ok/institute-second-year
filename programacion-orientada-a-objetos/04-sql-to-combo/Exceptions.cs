using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_sql_to_combo
{
    internal class MessageException : Exception
    {
        public MessageException(string message = "")
        {
            MessageBox.Show(message);
        }
    }
}
