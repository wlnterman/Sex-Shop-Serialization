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
    public class Vibrator : SexToy
    {
        public override void Request()
        { }
        //public int Acumpower { get; set; }
        public int Frequency { get; set; }

        public Vibrator(SexVariants sex, string name, int price, Color color, int frequency) : base(sex, name, price, color)
        {
            //Acumpower = acumpower;
            Frequency = frequency;
        }

        public Vibrator() { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Frequency", Frequency);
        }

        protected Vibrator(SerializationInfo info, StreamingContext context) : base(info,context)
        {
            Frequency = info.GetInt32("Frequency");
        }
    }
}
