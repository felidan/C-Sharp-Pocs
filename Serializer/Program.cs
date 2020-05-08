using _0___Uteis.Model;
using System;
using System.IO;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace Serializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Pessoa.GetPessoaPreenchido();

            // Serializar em XML
            using(var file = new StreamWriter(Directory.GetCurrentDirectory() + "\\XML.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(a.GetType());
                serializador.Serialize(file, a);
                Console.WriteLine("+ XML Serializado");
            }

            // Deserializar XML
            using(var file = new StreamReader(Directory.GetCurrentDirectory() + "\\XML.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(a.GetType());
                var pessoa = (Pessoa)serializador.Deserialize(file);
                Console.WriteLine("+ XML Deserializado");
            }

            // Serializar Json
            using(var file = new StreamWriter(Directory.GetCurrentDirectory() + "\\JS.json"))
            {
                JavaScriptSerializer serializador = new JavaScriptSerializer();
                file.Write(serializador.Serialize(a));
                Console.WriteLine("+ JS Serializado");
            }

            // Deserializar Json
            using(var file = new StreamReader(Directory.GetCurrentDirectory() + "\\JS.json"))
            {
                JavaScriptSerializer serializador = new JavaScriptSerializer();
                var pessoa = serializador.Deserialize<Pessoa>(file.ReadToEnd());
                Console.WriteLine("+ JS Deserializado");
            }

            Console.ReadKey();
        }
    }
}
