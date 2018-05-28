using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace Serialization.classes
{
    [Serializable]
    public class Dildo : SexToy
    {
        public override void Request()
        { }
        public int Size { get; set; }
        //public string Creatorcompany { get; set; }

        public Dildo(SexVariants sex, string name, int price, Color color, int size) : base(sex, name, price, color)
        {
            Size = size;
            //Creatorcompany = creatorcompany;
        }

        public Dildo() { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Size", Size);
        }

        protected Dildo(SerializationInfo info, StreamingContext context) : base(info,context)
        {
            Size = info.GetInt32("Size");
        }
    }
}
