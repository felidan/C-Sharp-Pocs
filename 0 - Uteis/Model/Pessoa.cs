namespace _0___Uteis.Model
{
    public class Pessoa
    {
        public Pessoa()
        {
            Endereco = new Endereco();
        }
        public int IdPesspa { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public Endereco Endereco { get; set; }

        public static Pessoa GetPessoaPreenchido()
        {
            Pessoa pessoa = new Pessoa();

            pessoa.IdPesspa = 1;
            pessoa.Nome = "Antonio Silva";
            pessoa.Idade = 22;
            pessoa.Peso = 90.5;

            pessoa.Endereco = new Endereco()
            {
                Rua = "Andrade",
                Bairro = "Vila Torres",
                Cidade = "Santo André",
                Estado = "SP",
                Nomero = 546
            };

            return pessoa;
        }
    }
}
