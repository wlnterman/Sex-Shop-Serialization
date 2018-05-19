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
using Serialization.classes;
using Serialization.View;
using System.IO;
using System.Windows.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;

namespace Serialization
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Product> products = new List<Product>();

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Balls.IsChecked == true)
            {  
                products.Add(new Analballs(
                    Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text),
                    Colors.Gold, 
                    Int32.Parse(Ballread.Text)
                    ));//pofiksit pol na muzkoi
                listbox.Items.Add(new ProductView(products[0]));
            }

            if (Plug.IsChecked == true)
            {
                products.Add(new Analplug(
                    Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text),
                    Colors.Gold, 
                    Int32.Parse(heightread.Text), Analplug.Partof.FurTail
                    ));
                listbox.Items.Add(new ProductView(products[0]));
            }

            if (Dildo.IsChecked == true)
            {
                products.Add(new Dildo(
                    Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text),
                    Colors.Gold,
                    Int32.Parse(sizeread.Text)
                    ));
                listbox.Items.Add(new ProductView(products[0]));
            }

            if (Lubricant.IsChecked == true)
            {
                products.Add(new Lubricant(
                    Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text),
                    effektread.Text
                    ));
                listbox.Items.Add(new ProductView(products[0]));
            }

            //if (Strapon.IsChecked == true)
            //{
            //    products.Add(new Strapon(
            //        Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text),
            //        Colors.Gold,
            //        Int32.Parse(heghtread.Text) 
            //        ));
            //    listbox.Items.Add(new ProductView(products[0]));
            //}

            if (Vibrator.IsChecked == true)
            {
                products.Add(new Vibrator(
                    Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text),
                    Colors.Gold,
                    Int32.Parse(Frequencyread.Text)
                    ));
                listbox.Items.Add(new ProductView(products[0]));
            }
        }
    }
}
