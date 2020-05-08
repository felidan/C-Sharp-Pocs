using _0___Uteis.Model;
using System;

namespace Delegate.Core
{
    public class Processador
    {
        public delegate void FotoFiltroHandler(Foto foto);

        public static FotoFiltroHandler filtro;

        public static void ProcessarFoto(Foto foto)
        {
            Console.WriteLine("Processador => Iniciando processamento..");
            
            filtro(foto);

            Console.WriteLine("Processador => Finalizando processamento..");
        }
    }
}
