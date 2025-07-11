using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_tp_analisis_matematico
{
    internal class Polynomial
    {
        public List<double> Coeficientes { get; private set; }
        public Polynomial(List<double> coeficientes)
        {
            Coeficientes = coeficientes;
        }
        public Polynomial Derivate()
        {
            List<double> derivados = new List<double>();
            int grado = Coeficientes.Count - 1;
            for (int i = 0; i < grado; i++)
            {
                derivados.Add(Coeficientes[i] * (grado - i));
            }
            return new Polynomial(derivados);
        }
        public override string ToString()
        {
            string resultado = "";
            int grado = Coeficientes.Count - 1;
            for (int i = 0; i <= grado; i++)
            {
                int exponente = grado - i;
                if (Coeficientes[i] != 0)
                {
                    int natural = (int)Math.Abs(Coeficientes[i]);
                    if (resultado.Length > 0 && Coeficientes[i] > 0)
                        resultado += " + ";
                    else if (resultado.Length > 0 && Coeficientes[i] < 0)
                        resultado += " - ";
                    else if (Coeficientes[i] < 0)
                        resultado += " - ";
                    if (exponente == 0)
                        resultado += natural;
                    else if (exponente == 1)
                        resultado += $"{natural}x";
                    else
                        resultado += $"{natural}x{ToSuperscript(exponente)}"; // El ^ es para indicar el exponente
                }
            }
            return resultado.Length > 0 ? resultado : "0";
        }
        private string ToSuperscript(int number)
        {
            string result = "";
            Dictionary<int, string> superscriptDigits = new Dictionary<int, string>
                {
                    { 0, "⁰" },
                    { 1, "¹" },
                    { 2, "²" },
                    { 3, "³" },
                    { 4, "⁴" },
                    { 5, "⁵" },
                    { 6, "⁶" },
                    { 7, "⁷" },
                    { 8, "⁸" },
                    { 9, "⁹" }
                };
            foreach (char digit in number.ToString())
            {
                result += superscriptDigits[int.Parse(digit.ToString())];
            }
            return result;
        }
    }
}
