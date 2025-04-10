using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_clases_con_bbdd_pero_sin_bbdd_pero_igual_le_meto_bbdd
{
    internal class MessageException : Exception
    {
        public MessageException(string message = "") {
            MessageBox.Show(message);
        }
    }
}
