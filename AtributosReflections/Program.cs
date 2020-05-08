using AtributosReflections.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AtributosReflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Proposta proposta = new Proposta();

            ValidaPropostaPorAtributo(proposta);

            Reflections();

            Console.ReadKey();
        }

        private static void Reflections()
        {
            Proposta prop = new Proposta() { IdProposta = 500,  IdStatus = 5, Descricao = "Teste", DataInclusao = DateTime.Now};

            Log.Log.GerarLog(prop);
            Log.Log.ImprimirLog();

        }

        private static void ValidaPropostaPorAtributo(Proposta proposta)
        {
            // Validação por atributo
            ValidationContext contexto = new ValidationContext(proposta);

            List<ValidationResult> results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(proposta, contexto, results, true))
            {
                foreach (var x in results)
                {
                    Console.WriteLine(x.ErrorMessage);
                }
            }
            else
                Console.WriteLine("OK");
        }
    }
}
