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
    //    void Main()
    //    {
    //        SexToy sextoy = new Proxy();
    //        sextoy.Request();
    //    }
    //}

    class Proxy : SexToy
    {
        Dildo dildo;
        public override void Request()
        {
            if (dildo == null)
                dildo = new Dildo();
            dildo.Request();
        }
    }

}
