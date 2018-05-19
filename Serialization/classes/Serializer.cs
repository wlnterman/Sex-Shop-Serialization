using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.classes
{
    static class Serializer
    {
        //public static void XmlSerialize(List<Product> stars, string path)
        //{
        //    XmlSerializer xml = new XmlSerializer(stars.GetType(), new Type[] { typeof(PlanetWithRings) });
        //    using (FileStream stream = new FileStream(path, FileMode.Create))
        //    {
        //        xml.Serialize(stream, stars);
        //    }
        //}

        //public static List<Product> XmlDeserializeWorld(string path, IEnumerable<Type> types)
        //{
        //    List<Star> stars = null;

        //    foreach (Type type in types)
        //    {
        //        try
        //        {
        //            XmlSerializer xml = new XmlSerializer(type, new Type[] { typeof(PlanetWithRings) });
        //            using (FileStream stream = new FileStream(path, FileMode.Open))
        //            {
        //                stars = (List<Star>)xml.Deserialize(stream);
        //            }
        //            break;
        //        }
        //        catch { }
        //    }

        //    foreach (Star star in stars)
        //    {
        //        star.SetCenters();
        //    }

        //    return stars;
        //}

        //public static void BinarySerialize(List<Product> stars, string path)
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();
        //    using (FileStream stream = new FileStream(path, FileMode.Create))
        //    {
        //        formatter.Serialize(stream, stars);
        //    }
        //}

        //public static List<Product> BinaryDeserializeWorld(string path)
        //{
        //    List<Star> stars;

        //    BinaryFormatter formatter = new BinaryFormatter();
        //    using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
        //    {
        //        stars = (List<Star>)formatter.Deserialize(stream);
        //    }

        //    foreach (Star star in stars)
        //    {
        //        star.SetCenters();
        //    }

        //    return stars;
        //}

        //public static void JsonSerialize(List<Product> stars, string path)
        //{
        //    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(stars.GetType(), new Type[] { typeof(Planet), typeof(Satellite), typeof(PlanetWithRings), typeof(Point) });
        //    using (FileStream stream = new FileStream(path, FileMode.Create))
        //    {
        //        jsonFormatter.WriteObject(stream, stars);
        //    }
        //}

        //public static List<Product> JsonDeserializeWorld(string path, Type type)
        //{
        //    List<Star> stars;

        //    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(type, new Type[] { typeof(Planet), typeof(Satellite), typeof(PlanetWithRings), typeof(Point) });
        //    using (FileStream stream = new FileStream(path, FileMode.Open))
        //    {
        //        stars = (List<Star>)jsonFormatter.ReadObject(stream);
        //    }

        //    foreach (Star star in stars)
        //    {
        //        star.SetCenters();
        //    }

        //    return stars;
        //}
    }
}
