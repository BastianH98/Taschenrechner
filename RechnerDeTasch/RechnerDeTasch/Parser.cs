using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

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
                    Console.WriteLine("Geben Sie bitte eine Zahl ein");
                    string Eingabe = Console.ReadLine();
                    //Einbauen RegEx.

                    string pattern = @"\d{1,}(,\d{1,})?";
                    MatchCollection zahlen = Regex.Matches(Eingabe, pattern);

                    string patternzeichen = @"(\+|\-|\*|\/)";
                    MatchCollection zeichen = Regex.Matches(Eingabe, patternzeichen);

                    double zahl1 = Convert.ToDouble(zahlen[0].Value);
                    string zeichen1 = Convert.ToString(zeichen[0].Value);
                    double zahl2 = Convert.ToDouble(zahlen[1].Value);

                    //string zeichen = teile[1].ToString();
                    //double zahl2 = Convert.ToDouble(teile[2].ToString());
                    var (ergebnis, text) = Rechnen2(zahl1, zahl2, zeichen1);

                   
                    if (zeichen1 == "/" && zahl2 == 0)
                    {
                        Console.WriteLine("Dies ist leider nicht möglich");
                    }
                    else
                    {
                        Console.WriteLine(text);
                        Console.WriteLine(ergebnis);
                    }
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
                text = "Der Qutient ist";
            }

            return (erg, text);
        }

    }
}
