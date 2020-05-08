using System.IO;
using System.Xml.Serialization;

namespace Generics.Core
{
    public class Serializador<T>
    {
        private static string Url = Directory.GetCurrentDirectory() + $"\\Generics\\###.txt";
        public static void Serializar(T obj)
        {
            ValidaDiretorio();

            using (var file = new StreamWriter(Url.Replace("###", obj.GetType().Name)))
            {
                XmlSerializer xml = new XmlSerializer(obj.GetType());
                xml.Serialize(file, obj);
            }
        }

        public static T Deserializar()
        {
            ValidaDiretorio();

            using (var file = new StreamReader(Url.Replace("###", typeof(T).Name)))
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                var obj = (T)xml.Deserialize(file);
                return obj;
            }
        }

        private static void ValidaDiretorio()
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Generics"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Generics");
            }
        }
    }
}
