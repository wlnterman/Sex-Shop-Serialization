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
    public abstract class SexToy : Product 
    {
        public abstract void Request();
        public Color Color { get; set; }
        public Byte[] Colortobytes
        {
            get
            {
                return new Byte[] { Color.R, Color.G, Color.B};
            }
            set
            {
                Color = Color.FromRgb(Color.R, Color.G, Color.B);
            }
        }
        //public string Material { get; set; }

        public SexToy(SexVariants sex, string name, int price, Color color) : base(sex, name, price)
        {
            Color = color;

            //Material = material;
        }

        public SexToy() { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info,context);
            info.AddValue("Color", Colortobytes);
        }

        protected SexToy(SerializationInfo info, StreamingContext context) : base(info,context)
        {
            Colortobytes = (Byte[])info.GetValue("Color",typeof(Byte[]));
        }
    }
}
