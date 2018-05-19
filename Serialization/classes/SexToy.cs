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
    public abstract class SexToy : Product 
    {
        public Color Color { get; set; }
        //public string Material { get; set; }

        public SexToy(SexVariants sex, string name, int price, Color color) : base(sex, name, price)
        {
            Color = color;
            //Material = material;
        }
    }
}
