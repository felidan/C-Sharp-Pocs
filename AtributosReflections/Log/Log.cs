using AtributosReflections.Atributos;
using System;
using System.Collections.Generic;

namespace AtributosReflections.Log
{
    public class Log
    {
        public static List<Object> list = new List<object>();
        
        public static void GerarLog(object obj)
        {
            list.Add(obj);
        }

        public static void ImprimirLog()
        {
            foreach(var obj in list)
            {
                Console.WriteLine($"Classe: {obj.GetType().Name}");

                foreach (var prop in obj.GetType().GetProperties())
                {
                    Console.WriteLine($"Nome: {prop.Name} - Tipo: {prop.PropertyType} - Valor: {prop.GetValue(obj).ToString()}");
                    
                    foreach(var att in prop.GetCustomAttributes(typeof(MappingAtributo), true)[0].GetType().GetProperties())
                    {
                        Console.WriteLine($"Atributo: {att.Name} - Valor: {att.PropertyType}");
                    }
                }
            }
        }
    }
}
