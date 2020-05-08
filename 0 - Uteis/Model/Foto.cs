namespace _0___Uteis.Model
{
    public class Foto
    {
        public string Nome { get; set; }
        public int TamanhoX { get; set; }
        public int TamanhoY { get; set; }

        public Foto GetFotoPreenchido()
        {
            Foto foto = new Foto()
            {
                Nome = "Foto teste",
                TamanhoX = 1200,
                TamanhoY = 2400
            };

            return foto;
        }
    }
}
