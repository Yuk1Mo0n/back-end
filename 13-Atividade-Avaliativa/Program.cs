using Models;

public class Program
{
    public static void Main()
    {

        Console.Clear();

        Console.WriteLine("Qual é seu nome");
        string seuNome = Console.ReadLine();

        Console.WriteLine(" --------------------------------------");
        Console.WriteLine($"| Bem-Vindo a sua conta bancaria {seuNome} |");
        Console.WriteLine(" --------------------------------------");

        string opcao = "";

        Banco conta = new Banco(seuNome);

        do
        {
            Console.WriteLine("------------ MENU -----------");
            Console.WriteLine("| 1 - Para Consultar Saldo ");
            Console.WriteLine("| 2 - Para Depositar ");
            Console.WriteLine("| 3 - Para Sacar ");
            Console.WriteLine("| 0 - Para fechar o sistema ");
            Console.WriteLine("-----------------------------");
            opcao = Console.ReadLine();

            switch (opcao)

            {
                case "0":
                    Console.Clear();
                    Console.WriteLine("Obrigado, volte sempre!! ;D");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    conta.ConsultarSaldo();
                    break;
                case "2":
                    conta.Depositar();
                    break;
                case "3":
                    conta.Sacar();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        } while (opcao != "0");
    }
}