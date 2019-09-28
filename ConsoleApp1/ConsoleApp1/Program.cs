using System;

namespace Programowanie3
{
    class Program
    {
        static int iloscProduktow = 0;
        static void wozek()
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
        } //28.09
        static string UnikalnaNazwa() //28.09
        {
            return "Produkt " + iloscProduktow++;
        }
        static void Main(string[] args)
        {
            //wozek();
            string escape = "exit";

            while(Console.ReadLine() != escape)
            {
                Console.WriteLine(UnikalnaNazwa());
            }

        }
    }
}
