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
    public class Analballs : SexToy  // класс, к которому надо адаптировать другой класс  
    {
        public virtual void RequestAD()
        { }
        public override void Request()
        { }
        public int Ballcount { get; set; }
        //public int Length { get; set; }

        public Analballs(SexVariants sex, string name, int price, Color color, int ballcount) : base(sex, name, price, color)
        {
            Ballcount = ballcount;
            //Length = length;
        }

        public Analballs() {}

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Ballcount", Ballcount);
        }

        protected Analballs(SerializationInfo info, StreamingContext context) : base(info,context)
        {
            Ballcount = info.GetInt32("Ballcount");
        }
    }
}
