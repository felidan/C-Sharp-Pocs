using _0___Uteis.Model;
using Delegate.Core;
using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Foto foto = new Foto();

            Processador.filtro = new FotoFiltro().Colorir; 
            Processador.filtro += new FotoFiltro().Crop; 
            Processador.filtro += new FotoFiltro().Histogramizacao; 
            Processador.filtro += new FotoFiltro().PretoBranco; 
            Processador.filtro += new FotoFiltro().Redimencionar;

            Processador.ProcessarFoto(foto.GetFotoPreenchido());

            Console.ReadKey();
        }
    }
}
