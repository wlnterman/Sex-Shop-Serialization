using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Pattern
{
    class Singleton //used in lubricant
    {
        private static Singleton instance;

        string Effective;

        private Singleton(string effective)
        {
            Effective = effective;
        }

        public static Singleton getInstance(string effective)
        {
            if (instance == null)
                instance = new Singleton(effective);
            return instance;
        }

        public string Geteffective()
        {
            return Effective;
        }
    }
}
