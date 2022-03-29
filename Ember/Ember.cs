using System;
using System.Collections.Generic;
using System.Text;

namespace Ember
{
    class Ember
    {
        public string Nev { get; set; }

        public int Kor { get; set; }

        public string Cim { get; set; }

        public int Fizetes { get; set; }

        public Ember(string nev, int kor, string cim, int fizetes)
        {
            Nev = nev;
            Kor = kor;
            Cim = cim;
            Fizetes = fizetes;
        }

        public override string ToString()
        {
            return $"Neve: {Nev}, Kora: {Kor}, Címe: {Cim} Fizetése: {Fizetes}";
        }

        public override bool Equals(object obj)
        {
            return obj is Ember ember &&
                   Nev == ember.Nev &&
                   Kor == ember.Kor &&
                   Cim == ember.Cim;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nev, Kor, Cim);
        }
    }
}
