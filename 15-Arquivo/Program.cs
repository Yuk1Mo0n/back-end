using System.IO;

class Program
{
    public static string caminhoArg = "Arquivo/arquivo2.txt";
    public static void Main()
    {
        GravarArg();
        LerArg();
    }
    public static void LerArg()
    {
        try
        {
            //*___Verificar se o arquivo existe
            if (File.Exists("Arquivo/arquivo.txt") == false)
            {
                //Criando meu arquivo.txt, este comando é executado quando a verificação no if é falsa ou seja o arquivo não existe 
                File.Create("Arquivo/arquivo.txt");
            }

            using (StreamReader arquivo = new StreamReader("Arquivo/arquivo.txt"))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro:Menssage}");

        }
    }
    public static void GravarArg()
    {
        try
        {
            using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt", true))
            {
                arquivo.WriteLine("digite algo");
                arquivo.WriteLine(Console.ReadLine());
                arquivo.WriteLine("(O^o)");


            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro:Menssage}");
        }
    }

}
//?__( quando o arquivo estiver com 'true', toda vez que for executado so vai ser adicionado mais;
//?__ enquando qaundo estiver como 'false', toda vez que executar só vai ser mostrado um vez; )
