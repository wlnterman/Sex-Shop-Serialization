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
    [Serializable] //номер по журналу 27
    public class Strapon : SexToy
    {
        public override void Request()
        { }
        public bool Selfstimul { get; set; }
        public Dildo Dildo;

        public Strapon(SexVariants sex, string name, int price, Color color, Dildo dildo, bool selfstimul) : base(sex, name, price, color)
        {
            Selfstimul = selfstimul;
            Dildo = dildo;
        }

        public Strapon() { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Selfstimul", Selfstimul);
            info.AddValue("Dildo", Dildo);
        }

        protected Strapon(SerializationInfo info, StreamingContext context) : base(info,context)
        {
            Selfstimul = info.GetBoolean("Selfstimul");
            Dildo = (Dildo)info.GetValue("Dildol", typeof(Dildo));
        }
    }
}
