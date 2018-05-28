using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using Serialization.Pattern;

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
            Effect = Singleton.getInstance(effect).Geteffective();
        }

        public Lubricant() { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Effect", Effect);
        }

        protected Lubricant(SerializationInfo info, StreamingContext context) : base(info,context)
        {
            Effect = info.GetString("Effect");
        }
    }
}
