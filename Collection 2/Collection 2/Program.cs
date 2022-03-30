using System;

namespace Collection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<string, int> collection = new ICollection<string, int>();
            collection.Add(1991,"PYTON");
            collection.Add(2010, "C#");
            collection.Add(1980, "C++");

            Console.WriteLine("YARANMA TARIXI");



            foreach (int item in collection.Originhistory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");


            Console.WriteLine("Proqramlasdirma dilleri");

            foreach (string item in collection.Programminglanguage)
            {
                Console.WriteLine(item);
            }
        }
    }
}
