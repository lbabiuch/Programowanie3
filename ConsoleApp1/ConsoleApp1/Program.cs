using System;

namespace Programowanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int odleglosc = -1, licznik = 0, sumaOdleglosci = 0;
            float sredniaOdleglosc = 0;

            while (odleglosc != 0)
            {
                string odpowiedz = Console.ReadLine();
                odleglosc = Convert.ToInt32(odpowiedz);
                sumaOdleglosci += odleglosc;
                licznik++;
            }

            sredniaOdleglosc = (float)sumaOdleglosci / (licznik - 1);

            Console.WriteLine("Wynik to " + sredniaOdleglosc);

        }
    }
}
