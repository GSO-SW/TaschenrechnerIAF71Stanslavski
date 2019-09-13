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
            string antwort;

            do
            {
                Console.Clear();

                Console.WriteLine("Wilkommen zu dem besten Taschenrechner!");
                Console.WriteLine("Geben sie ihre Zahlen jetzt ein :");


                int zahl1;
                int zahl2;

                Console.WriteLine("Erste Zahl: ");
                zahl1 = Convert.ToInt32(Console.ReadLine());
                zahl2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Das Ergebnis ist : {0}" , zahl1 + zahl2);

                Console.WriteLine("Nochmal rechnen? Ja/Nein");

                antwort = Console.ReadLine();

            } while (antwort == "Ja" || antwort == "J" || antwort == "j" || antwort == "ja");




        }
    }
}
