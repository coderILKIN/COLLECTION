using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_2
{
    class ICollection<T,U>
    {
        public T[] Programminglanguage;
        public U[] Originhistory;


        public ICollection()
        {
            Programminglanguage = new T[0];
            Originhistory = new U[0];

        }



        public void Add(U originhistory, T programminglanguage)
        {
            Array.Resize(ref Originhistory, Originhistory.Length + 1);
            Originhistory[Originhistory.Length - 1] = originhistory;
            Array.Resize(ref Programminglanguage, Programminglanguage.Length + 1);
            Programminglanguage[Programminglanguage.Length - 1] = programminglanguage;
        }

        public U[] getOriginhistory()
        {
            return Originhistory;
        }

        public T[] getProgramminglanguage()
        {
            return Programminglanguage;
        }


    }
}
