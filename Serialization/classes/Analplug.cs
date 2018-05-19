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
    public class Analplug : SexToy
    {
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
    }
}
