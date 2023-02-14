using System;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Teschenrechner
{
    class Program
    {
        private static int i;

        static void Rechner(string[] args)
        {
            Console.WriteLine("Herzlich Willkommen!  ");
           

             while (true)
            {
                double zahl1 = 0, zahl2 = 1, addition = 0, subtraktion = 0, multiplikation = 0, division = 0;
                char Rechenzeichen1 = '+';

                List<char> Zeichenkette = new List<char>();
                Zeichenkette.Add('+');
                Zeichenkette.Add('-');
                Zeichenkette.Add('*');
                Zeichenkette.Add('/');


                bool valid = true;
                while (valid)
                {
                    try
                    {
                        Console.WriteLine("Geben sie bitte eine Zahl ein:  ");
                        zahl1 = Convert.ToDouble(Console.ReadLine());
                        valid = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Das war leider keine gültige Zahl!");
                    }
                }
               
                bool valid3 = true;
                while (valid3)
                {
                    try
                    {

                        Console.WriteLine("Geben sie nun ein Rechenzeichen eim:   ");
                        Rechenzeichen1 = Convert.ToChar(Console.ReadLine());

                        if(Zeichenkette.Contains(Rechenzeichen1))
                        {
                            valid3 = false;
                        }
                        else
                        {
                            Console.WriteLine("Das ist kein gültiges Rechenzeichen");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Das ist kein gültiges Rechenzeichen");
                    }
                }

                bool valid2 = true;
                while (valid2)
                {
                    try
                    {
                        Console.WriteLine("Geben sie jetzt bitte die zweite Zahl ein:  ");
                        zahl2 = Convert.ToDouble(Console.ReadLine());
                        valid2 = false;

                        var (ergebnis, text) = Rechnen(zahl1, zahl2, Rechenzeichen1);

                        Console.WriteLine(text + " " + ergebnis);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Das war keine gültige Zahl!");
                    }
                }
            }
        }

        static (double, string) Rechnen(double zahl1, double zahl2, char Rechenzeichen)
        {
            double erg = 0;
            string text = null;

            if (Rechenzeichen == '+')
            {
                erg = zahl1 + zahl2;
                text = "Die Summe ist";
            }

            if (Rechenzeichen == '-')
            {
                erg = zahl1 - zahl2;
                text = "Die Differenz ist";
            }

            if (Rechenzeichen == '*')
            {
                erg = zahl1 * zahl2;
                text = "Das Produkt ist";
            }

            if (Rechenzeichen == '/')
            {
                erg = zahl1 / zahl2;
                text = "Der Quotient ist";
            }

            return (erg,text);
        }
    }
}

     

