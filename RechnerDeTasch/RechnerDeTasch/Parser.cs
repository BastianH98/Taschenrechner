using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Parser
    {
        static void Main(string[] args)
        {
            List<char> Zeichenkette = new List<char>();
            Zeichenkette.Add('+');
            Zeichenkette.Add('-');
            Zeichenkette.Add('*');
            Zeichenkette.Add('/');

            Console.WriteLine("Herzlich Willkommen!:");
            while (true)
            {
                try
                {
                    Console.WriteLine("Geben Sie eine Zahl ein");
                    string Eingabe = Console.ReadLine();
                    char[] teile = Eingabe.ToArray();

                    double zahl1 = Convert.ToDouble(teile[0].ToString());
                    string zeichen = teile[1].ToString();
                    double zahl2 = Convert.ToDouble(teile[2].ToString());

                    var (ergebnis, text) = Rechnen2(zahl1, zahl2, zeichen);

                    Console.WriteLine(text);
                    Console.WriteLine(ergebnis);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Das war keine gültige Aufgabe");
                }          

            }



        }

        static (double, string) Rechnen2(double zahl1, double zahl2, string zeichen)
        {
            double erg = 0;
            string text = null;

            if (zeichen == "+")
            {
                erg = zahl1 + zahl2;
                text = "Die Summe ist";
            }

            if (zeichen == "-")
            {
                erg = zahl1 - zahl2;
                text = "Die Differenz ist";
            }

            if (zeichen == "*")
            {
                erg = zahl1 * zahl2;
                text = "Das Produkt ist";
            }

            if (zeichen == "/")
            {
                erg = zahl1 / zahl2;
                text = "Der Quotient ist";
            }

            return (erg, text);
        }

    }
}
