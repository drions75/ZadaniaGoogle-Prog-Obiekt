using System;
using System.Collections.Generic;
using System.Linq;

namespace ZadanieProgObiekt
{


    class Program
    {
        /*
            Zadanie 2. “Licznik częstotliwości”
            Na wejściu otrzymujemy listę liczb całkowitych. Oblicz częstotliwość występowania każdego elementu.

            Przykład:
            wejście {1, 2, 2,5, 6, 1,  2, 5},
            wyjście: 1:2, 2:3, 5:2, 6:1
        */

        /*
             Zadanie 3. “społeczności”
            Mamy N osob identyfikowanych liczbami calkowitymi. Na wejsciu otrzymujemy listę par,
            które oznaczją, że dwie osoby były ze sobą w interakcji. Społeczność to lista
            osób które weszły ze sobą kiedykolwiek w interakcje. Dla każdej osoby wypisz
            numer społeczności do której należy
          */
        public static List<int> DrawNumbers(int amount)
        {
            List<int> listNumber = new List<int>();
            Random generator = new Random();

            for (int i = 0; i < amount; i++)
            {
                listNumber.Add(generator.Next(10));
            }

            return listNumber;
        }
        public static List<(int element, int amount)> CountFreq(List<int> listOfNumbers)
        {
            var x = listOfNumbers.GroupBy(x => x).Select(x => (x.Key, x.Count())).ToList();

            return x;
        }
        
        public static List<(int element1, int element2)> DrawPairs(int amount)
        {
            Random generator = new Random();
            List<(int element, int amount)> listPair = new List<(int element, int amount)>();

            for (int i = 0; i < amount; i++)
            {
                int x = generator.Next(10), y = generator.Next(10);

                if (x != y)
                {
                    listPair.Add((x, y));
                }
                else amount--;
            }
            return listPair;
        }

        public static List<(int element, int amount)> Communities(List<(int element, int amount)> listOfPairs)
        {
            List<(int element, int amount)> listCommunities = new List<(int element, int amount)>();

            //var x = listOfPairs.GroupBy(x => x).Select(x => (x.Key, x.Count())).ToList(); // ilosc takich samych par

            
            
            
             
           

            return listCommunities;
        }
        static void Main(string[] args)
        {
            int amount = 15;
            //List<int> listOfNumbers = DrawNumbers(amount);
            //var x = CountFreq(listOfNumbers);

            List <(int element, int amount)> listOfPairs = DrawPairs(amount);

            var x = Communities(listOfPairs);

            Console.WriteLine("Hello World!");
        }
    }
}
