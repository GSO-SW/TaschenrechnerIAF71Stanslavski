using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            string antwort = "";

            do
            {
                Console.Clear();

                Console.WriteLine("Wilkommen zu dem besten Taschenrechner!");
                Console.WriteLine("Welchen Operrator wollen sie nutzen? + - * / ? :");
                char op =  Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Erste Zahl: ");
                int zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zweite Zahl: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());

                double ergebnis = 0;

                switch (op)
                {
                    case '+':
                        ergebnis = zahl1 + zahl2;
                        break;
                    case '-':
                        ergebnis = zahl1 - zahl2;
                        break;
                    case '*':
                        ergebnis = zahl1 * zahl2;
                        break;
                    case '/':
                        ergebnis = zahl1 / zahl2;
                        break;
                }

                Console.WriteLine("Das Ergebnis ist : " + ergebnis); 

                Console.WriteLine("Nochmal rechnen? Ja/Nein");

                antwort = Console.ReadLine();

            } while (antwort == "Ja" || antwort == "J" || antwort == "j" || antwort == "ja");
        }
    }
}
