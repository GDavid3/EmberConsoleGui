using System;
using System.Collections.Generic;

namespace Ember
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ember> list = new List<Ember>();
            list.Add(new Ember("János", 19, "Rigó utca", 120000));
            list.Add(new Ember("János", 19, "Rigó utca", 160000));
            list.Add(new Ember("Petra", 32, "Rigó utca", 260000));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            HashSet<Ember> hs = new HashSet<Ember>(list);
            Console.WriteLine("\n halmaz után:");
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
