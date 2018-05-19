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

namespace Serialization.classes
{
    [Serializable]
    public class Analballs :SexToy
    {
        public int Ballcount { get; set; }
        //public int Length { get; set; }

        public Analballs(SexVariants sex, string name, int price, Color color, int ballcount) : base(sex, name, price, color)
        {
            Ballcount = ballcount;
            //Length = length;
        }
    }
}
