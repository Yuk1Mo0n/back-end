public class Program
{
    public static void Main()
    {
        //!catch é o tratamento do erro, normalmente colocamos as mensagens de acordo
        //!com o tipo do erro, para melhor compreenção do usuario
        
        //!O try serve para tratar um erro e não parar a execução do programa
        //*Se ocorrer qualquer erro dentro do bloco try, o sistema interrompe -
        //*- a execução do bloco e vai para o catch

        try//'tem algo de errado, mas o programa não vai sair '
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o nº{numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"O resultado é:{resultado}");

        }

        //Tratando esceção de 'overflow'(estouro de campo)
        catch (OverflowException)
        {
            Console.WriteLine("Este número inteiro é maior que o suportado")
        }

        //Tratando exceção de erro de formato
        catch (FormatException)
        {
            Console.WriteLine("Erro: Digite um numero inteiro");

        }

        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro:{erro.Message}");
        }

        //finally é um bloco executado independentemente se ocorrer erro ou não

        finally
        {
            Console.WriteLine("Entrando no finally");
        }
    }
}