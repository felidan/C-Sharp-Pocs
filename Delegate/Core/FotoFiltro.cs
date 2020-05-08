using _0___Uteis.Model;
using System;

namespace Delegate.Core
{
    public class FotoFiltro
    {
        public void Colorir(Foto foto)
        {
            Console.WriteLine("FotoFiltro --> Colorir");
        }

        public void PretoBranco(Foto foto)
        {
            Console.WriteLine("FotoFiltro --> PretoBranco");
        }

        public void Crop(Foto foto)
        {
            Console.WriteLine("FotoFiltro --> Crop");
        }

        public void Redimencionar(Foto foto)
        {
            Console.WriteLine("FotoFiltro --> Redimencionar");
        }
        
        public void Histogramizacao(Foto foto)
        {
            Console.WriteLine("FotoFiltro --> Histogramizacao");
        }
    }
}
