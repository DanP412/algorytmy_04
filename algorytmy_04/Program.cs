using System;

namespace algorytmy_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = { 52, 42, -4, 34, 9, 8, 32, 1, -1, 6 };
            int[] tab2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, -9, -8, -7, -6 };
            Console.WriteLine("\nTablica nr.1 początkowa: ");
            WyswietlanieTablicy(tab1);

            Console.WriteLine("\nPosortowana tablica: ");
            WyswietlanieTablicy(InsertionSort(tab1));
            Console.WriteLine("\n");

            Console.WriteLine("\nTablica nr.2 początkowa: ");
            WyswietlanieTablicy(tab2);

            Console.WriteLine("\nPosortowana tablica: ");
            WyswietlanieTablicy(InsertionSort(tab2));
            Console.WriteLine("\n");



        }

        static int[] InsertionSort(int[] tablica)
        {
            for (int i = 0; i < tablica.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (tablica[j - 1] > tablica[j])
                    {
                        int temp = tablica[j - 1];
                        tablica[j - 1] = tablica[j];
                        tablica[j] = temp;
                    }
                }
            }

            return tablica;

        }
        public static void WyswietlanieTablicy(int[] tab)
        {
            foreach (int i in tab)
            {
                Console.Write(i.ToString() + "  ");
            }
        }


        public static int[] InsertionSortBy(int[] tablica)
        {

            for (int i = 0; i < tablica.Length - 1; i++)
            {
                int j;
                var wartosc = tablica[i];
                for (j = i; j > 0; j--)
                {
                    if (tablica[j - 1] > wartosc)
                    {
                        tablica[j] = tablica[j - 1];
                    }
                }

                tablica[j] = wartosc;

            }

            return tablica;

        }

    }

}


    

