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
using System.IO;
using System.Windows.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using Serialization.View;
using System.Security.Cryptography;
//using Serialization.Classes;
//using Serialization.Classes.UI;
using Serialization;
using Microsoft.Win32;
using Serialization.classes;

namespace Serialization.classes
{
    static class Serializer
    {
        public static void XmlSerialize(List<Product> stars, string path)
        {
            XmlSerializer xml = new XmlSerializer(stars.GetType(), new Type[] { typeof(Product), typeof(SexToy), typeof(Analballs), typeof(Analplug), typeof(Dildo), typeof(Lubricant), typeof(Strapon), typeof(Vibrator) });
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                xml.Serialize(stream, stars);
               // Sex = (SexVariants)info.GetValue("Sex", typeof(SexVariants));
               // xml.Serialize(stream, (Object)Convert.ToBase64String(Encoding.UTF8.GetBytes(stars))typeof;
                //var simpleTextBytes = Encoding.UTF8.GetBytes(stars);
                //string enText = Convert.ToBase64String(Encoding.UTF8.GetBytes(stars););
            }
        }

        public static List<Product> XmlDeserializeWorld(string path, IEnumerable<Type> types)
        {
            List<Product> stars = null;

            foreach (Type type in types)
            {
                try
                {
                    XmlSerializer xml = new XmlSerializer(type, new Type[] { typeof(Product), typeof(SexToy), typeof(Analballs), typeof(Analplug), typeof(Dildo), typeof(Lubricant), typeof(Strapon), typeof(Vibrator) });
                    using (FileStream stream = new FileStream(path, FileMode.Open))
                    {
                        stars = (List<Product>)xml.Deserialize(stream);

                        //var enTextBytes = Convert.FromBase64String(enText);
                        //string deText = Encoding.UTF8.GetString(enTextBytes);
                        
                    }
                    break;
                }
                catch { }
            }

            //foreach (Product star in stars)
            //{
              //  star.SetCenters();
            //}

            return stars;
        }

        public static void BinarySerialize(List<Product> stars, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(stream, stars);
            }
        }

        public static List<Product> BinaryDeserializeWorld(string path)
        {
            List<Product> stars;

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                stars = (List<Product>)formatter.Deserialize(stream);
            }

            //foreach (Star star in stars)
            //{
             //   star.SetCenters();
            //}

            return stars;
        }

        public static void JsonSerialize(List<Product> stars, string path)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(stars.GetType(), new Type[] { typeof(Analballs), typeof(Analplug), typeof(Dildo), typeof(Lubricant), typeof(Strapon), typeof(Vibrator) });
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                jsonFormatter.WriteObject(stream, stars);
            }
        }

        public static List<Product> JsonDeserializeWorld(string path, Type type)
        {
            List<Product> stars;

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(type, new Type[] { typeof(Analballs), typeof(Analplug), typeof(Dildo), typeof(Lubricant), typeof(Strapon), typeof(Vibrator) });
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                stars = (List<Product>)jsonFormatter.ReadObject(stream);
            }
            //int i = 0;
            //foreach (Product star in stars)
            //{
            //    //star.SetCenters();
            //    MainWindow.listbox.Items.Add(new ProductView(stars[i++]));                
            //}

            return stars;
        }
    }
}
