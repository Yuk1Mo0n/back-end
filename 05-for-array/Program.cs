class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Estou passando pela {i}ª vez no for");
        }
        for (int i = 1; i <= 10; i += 5)//adiciona um numero + outro numero(ultimo)
        {
            Console.WriteLine($"Estou passando pela {i}ª vez no for");
        }
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"variavel vale {i}");
        }

        int numero = 87;
        for (int cont = 1; cont <= 10; cont++)
        {
            Console.WriteLine($"{numero} x {cont} = {numero * cont}");
        }
        //abaixo é declaração de vetor
        string[] alunos = new string[34];

        foreach (string aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        int[] cadeiras = new int[5];
        cadeiras[0] = 5;
        cadeiras[4] = 34;
        cadeiras[1] = 69;
        cadeiras[2] = 99;
        cadeiras[3] = 50;

        int soma = 0;

        int maior = 0;

        int menor = 100;

        foreach (int aluno in cadeiras)
        {
            soma = soma + aluno;
            if (aluno > maior)
            {
                maior = aluno;
            }
            if (aluno < menor)
            {
                menor = aluno;
            }
        }
        Console.WriteLine($"Soma: {soma}, Maior {maior} e menor {menor}");

        Array.Sort(cadeiras);

        for(int x = 0; x < cadeiras.Length; x++){
            Console.WriteLine($"Pos {x} - valor {cadeiras[x]}");
        }
    }
}
//nome de var não pode ser espaçada nem 