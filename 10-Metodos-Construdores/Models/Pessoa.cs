namespace Models
{
    public class Pessoa
    {
        //*---atributos class 'Pessoa'
        private string nome { get; set; }
        private int idade { get; set; }
        private string email { get; set; }
        private string anoNascimento { get; set; }


        //*---metodo class 'Pessoa'

        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }
        public Pessoa(string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
  
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idadePessoa;

        }

        public void Infomacoes()
        {
            Console.WriteLine($"{nome} tem {idade} e nasceu é {anoNascimento}");
        }

       

    }
}