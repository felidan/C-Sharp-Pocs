namespace _0___Uteis.Model
{
    public class Carro
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }

        public static Carro GetCarroPreenchido()
        {
            Carro carro = new Carro()
            {
                Ano = 2020,
                Nome = "Fox",
                Marca = "VW"
            };

            return carro;
        }
    }
}
