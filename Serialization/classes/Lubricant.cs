using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.classes
{
    [Serializable]
    public class Lubricant : Product
    {
       // public List<string> contain;
        public string Effect { get; set; }

        public Lubricant(SexVariants sex, string name, int price, string effect) : base(sex, name, price)
        {
            //this.contain = contain;
            Effect = effect;
        }
    }
}
