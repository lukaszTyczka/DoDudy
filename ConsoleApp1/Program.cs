using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int numerKontenera = 1; to jest zbedne
            int[] container = new int[10];
            for (int i = 0; i < container.Length; i++)
            {
                Console.WriteLine("Wprowadź wagę [kg] {0}/10 kontenera: ", i + 1);
                container[i] = GetWeightFromUser();
                //Console.WriteLine(container[i]); przez to wyswietla 2 razy

            }
            // to trzeba za petle wywali
            Console.WriteLine("Dodane wagi kontenerów: ");
            
            for (int j = 0; j < container.Length; j++)
            {
                Console.WriteLine(container[j]);
            }
        }

        private static int GetWeightFromUser()
        {
            string input = Console.ReadLine();
            if(int.TryParse(input, out var result))
            {
                return result;
            }
            Console.WriteLine("Wprowadziłeś błędną wartość spróbuj jeszcze raz!");
            return GetWeightFromUser();
        }
    }
}
