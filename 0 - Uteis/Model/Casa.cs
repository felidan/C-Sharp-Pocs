namespace _0___Uteis.Model
{
    public class Casa
    {
        public string Tipo { get; set; }
        public int QuantidadeComodos { get; set; }
        public int QuantidadeQuartos { get; set; }
        public decimal Tamanho { get; set; }

        public static Casa GetCasaPreenchida()
        {
            Casa casa = new Casa()
            {
                QuantidadeComodos = 5,
                QuantidadeQuartos = 2,
                Tamanho = 54,
                Tipo = "Apartamento"
            };

            return casa;
        }
    }
}
