using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
