using System;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    class BasketList<T,U>
    {
        public U[] Vitamins;

        public T[] Fruits;

        
        public BasketList()
        {
            Fruits = new T[0];
            Vitamins = new U[0];

        }

        


        public void Add(T fruit,U vitamin)
        {
            Array.Resize(ref Fruits, Fruits.Length + 1);
            Fruits[Fruits.Length - 1] = fruit;
            Array.Resize(ref Vitamins, Vitamins.Length + 1);
            Vitamins[Vitamins.Length - 1] = vitamin;
        }

        public T[] getFruits()
        {
            return Fruits;
        }

        public U[] getVitamins()
        {
            return Vitamins;
        }

    }
}
