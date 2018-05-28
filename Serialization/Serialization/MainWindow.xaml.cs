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
using Microsoft.Win32;
using Serialization.Pattern;

namespace Serialization
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void RequestAD(Analballs analballs)
        {
            analballs.RequestAD();
        }

        private List<Product> products = new List<Product>();

        public MainWindow()
        {
            InitializeComponent();   
        }
        int i = 0;
        private string pluginPath = "Plugins";

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(Balls.IsChecked == true)
            {  
                products.Add(new Analballs(
                    Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text),
                    Colors.Gold, 
                    Int32.Parse(Ballread.Text)
                    ));//pofiksit pol na muzkoi
                listbox.Items.Add(new ProductView(products[i++]));
            }

            if (Plug.IsChecked == true)
            {
                products.Add(new Analplug(
                    Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text),
                    Colors.Gold, 
                    Int32.Parse(heightread.Text), Analplug.Partof.FurTail
                    ));
                listbox.Items.Add(new ProductView(products[i++]));
            }

            if (Dildo.IsChecked == true)
            {
                products.Add(new Dildo(
                    Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text),
                    Colors.Gold,
                    Int32.Parse(sizeread.Text)
                    ));
                listbox.Items.Add(new ProductView(products[i++]));
            }

            if (Lubricant.IsChecked == true)
            {
                
                products.Add(new Lubricant(
                    Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text),
                    effektread.Text
                    ));
                listbox.Items.Add(new ProductView(products[i++]));
                //listbox.Items.Refresh();
            }

            if (Strapon.IsChecked == true)
            {
                products.Add(new Strapon(
                    Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text),
                    Colors.Gold,  
                    new Dildo(Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text), Colors.Gold, Int32.Parse(heghtread.Text)), 
                    true//Int32.Parse(heghtread.Text)
                    ));
                listbox.Items.Add(new ProductView(products[i++]));
            }

            if (Vibrator.IsChecked == true)
            {
                //int i = 0;
                products.Add(new Vibrator(
                    Product.SexVariants.Woman, nameread.Text, Int32.Parse(priceeread.Text),
                    Colors.Gold,
                    Int32.Parse(Frequencyread.Text)
                    ));
                listbox.Items.Add(new ProductView(products[i++]));
            }
                            
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "List";

            //CompressionAlgs algorithms = new CompressionAlgs(pluginPath);
            //if (algorithms.objects.Count == 0)
            //{
            //    MessageBox.Show("No plugins");
            //    return;
            //}


            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                string ext = System.IO.Path.GetExtension(dlg.FileName);
                //string name = dlg.FileName.Replace(ext, "");
            //    ICompressor compressor = algorithms.objects.Find(obj => obj.Format == ext);

                Serializer.XmlSerialize(products, dlg.FileName + ".xml");
                //compressor.Compress(dlg.FileName + ".xml", dlg.FileName + ".xml" + ext);
                //File.Delete(dlg.FileName + ".xml");
                MessageBox.Show("Сохранено xml");

                //Serializer.BinarySerialize(products, dlg.FileName + ".bin");
                //compressor.Compress(dlg.FileName + ".bin", dlg.FileName + ".bin" + ext);
                //File.Delete(dlg.FileName + ".bin");
                MessageBox.Show("Сохранено binary");

                Serializer.JsonSerialize(products, dlg.FileName + ".json");
                //compressor.Compress(dlg.FileName + ".json", dlg.FileName + ".json" + ext);
                //File.Delete(dlg.FileName + ".json");
                MessageBox.Show("Сохранено json");                

                SexToy sextoy = new Proxy();
                sextoy.Request();

            }

        }


        private List<Product> DeserializeWorld(string fileName)
        {
            List<Product> stars = null;
            switch (System.IO.Path.GetExtension(fileName).ToLower())
            {
                case ".xml":
                    stars = Serializer.XmlDeserializeWorld(fileName, new Type[] { typeof(List<Product>) });
                    MessageBox.Show("Восстановлено xml");
                    MessageBox.Show("Восстановлено binary");
                    break;

                case ".json":
                    stars = Serializer.JsonDeserializeWorld(fileName, typeof(List<Product>));
                    MessageBox.Show("Восстановлено json");
                    break;

                //case ".bin":
                //    stars = Serializer.BinaryDeserializeWorld(fileName);
                //    break;
            }
            if (stars == null)
            {
                throw new Exception();
            }

            int j = 0;

            foreach (Product star in stars)
            {
                //listbox.Items.Remove();
                listbox.Items.Add(new ProductView(stars[j++]));
                listbox.Items.Refresh();
            }



            return stars;
        }


        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //dlg.Filter = "Space Object files (*.xml;*json;*bin)|*.xml;*json;*bin";
            dlg.FileName = "List";

            bool? result = dlg.ShowDialog();

            products = DeserializeWorld(dlg.FileName);        

            //for(int j =1; products.LongCount; j++)
            //{
            //    listbox.Items.Add(new ProductView(products[j++]));
            //}
        }
    }
}
