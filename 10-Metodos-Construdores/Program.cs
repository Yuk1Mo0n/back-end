using Models;
public class Program
{
    public static void Main()
    {
        /*Pessoa pessoa1 = new Pessoa();

        pessoa1.nome = "halua";
        pessoa1.idade = 19;

        pessoa1.Cantar();
        
        //?-- Forma diferente de colocar o 
        pessoa1 pessoa2 = new Pessoa
        {
            pessoa2.nome = "diva",
            pessoa2.idade = 28
        };
        pessoa2.Cantar();*/


        //* forma mais 'simples de classes'
        Pessoa pessoa1 = new Pessoa("halua", 19, "halua.al@gmail.com");
        pessoa1.Cantar();

        pessoa1.Infomacoes();

         Pessoa pessoa2 = new Pessoa("Miku", 16, "mikuhatsuni@gmail.com")
         
        pessoa1.Infomacoes();

    }
}