using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization.classes;

namespace Serialization.Pattern
{
    //class Client
    //{
    //    public void RequestAD(Analballs analballs)
    //    {
    //        analballs.RequestAD();
    //    }
    //}

    // Адаптер
    class Adapter : Analballs
    {
        private Analplug analplug = new Analplug();

        public override void RequestAD()
        {
            analplug.SpecificRequest();
        }
    }

    
}
