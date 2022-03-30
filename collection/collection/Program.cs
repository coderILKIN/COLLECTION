using System;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            BasketList<string, char> basketList = new BasketList<string, char>();

            basketList.Add("LEMON", 'C');
            basketList.Add("PINEAPLE", 'A');
            basketList.Add("APPLE", 'D');

            Console.WriteLine("Meyveler");
            
            foreach (string item in basketList.Fruits)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------");

            Console.WriteLine("Vitaminleri");
            

            foreach (char item in basketList.Vitamins)
            {
                Console.WriteLine(item);
            }
        }
    }
}
