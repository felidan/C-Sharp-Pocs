using _0___Uteis.Model;
using Generics.Core;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = Carro.GetCarroPreenchido();
            Casa casa = Casa.GetCasaPreenchida();
            Pessoa pessoa = Pessoa.GetPessoaPreenchido();

            Serializador<Carro>.Serializar(carro);
            Serializador<Casa>.Serializar(casa);
            Serializador<Pessoa>.Serializar(pessoa);

            var car = Serializador<Carro>.Deserializar();
            var cas = Serializador<Casa>.Deserializar();
            var pes = Serializador<Pessoa>.Deserializar();

            Console.WriteLine($"{car.GetType()} - {car.Nome}");
            Console.WriteLine($"{cas.GetType()} - {cas.Tipo}");
            Console.WriteLine($"{pes.GetType()} - {pes.Nome}");

            Console.WriteLine();
        }
    }
}
