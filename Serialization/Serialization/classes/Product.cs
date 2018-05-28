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
    public abstract class Product
    {
        public enum SexVariants
        {
            Man, Woman, Unisex
        }
        public SexVariants Sex { get; set; }

        public string Name { get; set; }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                //price = Math.Abs(value);
                if (value < 0)
                    throw new Exception("Цена товара должна быть больше 0!");
                price = value;
            }
        }
        private int price;

        public Product(SexVariants sex, string name, int price)
        {
            Sex = sex;
            Name = name;
            Price = price;

        }

        public Product() { }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Sex", Sex);
            info.AddValue("Name", Name);
            info.AddValue("Price", Price);
        }

        protected Product(SerializationInfo info, StreamingContext context)
        {
            Sex = (SexVariants)info.GetValue("Sex", typeof(SexVariants));
            Name = info.GetString("Name");
            Price = info.GetInt32("Price");
        }
    }
}
