using System;

namespace Programowanie3
{
    class Program
    {
        static int produktPierwszy = 0, produktDrugi = 0, produktTrzeci = 0;
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
        static void UnikalnaNazwa(string nazwaProduktu) //28.09
        {
            switch (nazwaProduktu)
            {
                case "1":
                    Console.WriteLine("Produkt [" + nazwaProduktu + "] " + produktPierwszy++);
                    break;
                case "2":
                    Console.WriteLine("Produkt [" + nazwaProduktu + "] " + produktDrugi++);
                    break;
                case "3":
                    Console.WriteLine("Produkt [" + nazwaProduktu + "] " + produktTrzeci++);
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            //wozek();
            string escape = "exit";
            string wybor = "";

            while (!wybor.Equals(escape))
            {
                wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        UnikalnaNazwa("1");
                        break;
                    case "2":
                        UnikalnaNazwa("2");
                        break;
                    case "3":
                        UnikalnaNazwa("3");
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
