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
    public class Analplug : SexToy  // Адаптируемый класс
    {
        public void SpecificRequest()
        { }
        public override void Request()
        { }
        public int Height { get; set; }

        public enum Partof
        {
            FurTail, Stone, Ring
        }
        public Partof Part { get; set; }

        public Analplug(SexVariants sex, string name, int price, Color color, int height, Partof part) : base(sex, name, price, color)
        {
            Height = height;
            Part = part;
        }

        public Analplug() { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Height", Height);
            info.AddValue("Part", Part);
        }

        protected Analplug(SerializationInfo info, StreamingContext context) : base(info,context)
        {
            Part = (Partof)info.GetValue("Part", typeof(Partof));
            Height = info.GetInt32("Height");
        }
    }
}
