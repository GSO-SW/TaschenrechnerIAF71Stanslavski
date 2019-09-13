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
            bool schonmalgerechnet = false;
            char a = ' ';
            double vergebnis = 0;
            int zahl1 = 0;
            int zahl2 = 0;


            do
            {
            
                Console.Clear();

                if(schonmalgerechnet == true)
                {
                    Console.WriteLine("Um ihr voheriges Ergebnis nutzen wollen benutzen sie den kürzel: ANS");
                    Console.WriteLine("Wollen sie diese Funktion nutzen? [J] [N]");
                    a = Convert.ToChar(Console.ReadLine());
                }

                Console.WriteLine("Wilkommen zu dem besten Taschenrechner!");
                Console.WriteLine("Welchen Operrator wollen sie nutzen? [+] [-] [*] [/] [:]");
                char op =  Convert.ToChar(Console.ReadLine());

                if (a == 'n' || a == 'N')
                {
                    Console.WriteLine("Erste Zahl: ");
                    zahl1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Zweite Zahl: ");
                    zahl2 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {


                }

                double ergebnis = 0;

                if (a == 'n' || a == 'N')
                {
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
                }
                else
                {
                    switch (op)
                    {
                        case '+':
                            ergebnis = vergebnis + zahl2;
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
                }

                Console.WriteLine("Das Ergebnis ist : " + ergebnis); 

                Console.WriteLine("Nochmal rechnen? [J] [N]");

                antwort = Console.ReadLine();

                 vergebnis = ergebnis;
                schonmalgerechnet = true;
            } while (antwort == "Ja" || antwort == "J" || antwort == "j" || antwort == "ja");
        }
    }
}
