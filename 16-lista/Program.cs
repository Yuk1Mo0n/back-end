using System.Collections.Generic;
using Sesi.Model;
public class Program
{
    public static void Main()
    {
        //lista de inteiros
        List<int> listaNumeros = new List<int>();

        //adicionar elementos na lista(pode adicionar quantos quiser 'posições')
        listaNumeros.Add(10); //posição [0]
        listaNumeros.Add(69); //posição [1]
        listaNumeros.Add(45); //posição [2]

        //!_ Visualizar os dados da lista
        Console.WriteLine(listaNumeros[1]);

        //!_ var.Count pega o tanto de pocições que tem
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");

        //*se for adicionado outro 'var.Add' ele não sera contado ate que tenha outro 'var.Count'
        listaNumeros.Add(75); //posição [3]
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");

        //---------------------------------------------------------------------------------//

        List<string> listaNomes = new List<string>();

        listaNomes.Add("Perola");
        listaNomes.Add("Julia");
        listaNomes.Add("Anna");

        //Console.WriteLine(listaNomes[0]);

        //---------------------------------------------------------------------------------//

        //Lista com coisas já atribuitas
        List<int> numeros = new List<int> { 1, 2, 6, 9, 8, 3 };

        Console.WriteLine($"Quantidade de elementos na lista númeroa: {numeros.Count}");

        numeros.Remove(3);  //?_ Remove o elemento 
        numeros.RemoveAt(1);  //?_ Remove o indice do elemento 
        //numeros.RemoveRange(5,1);  //?_ Remove o elemento pelo indice

        //Substituição de informação dos itens da lista
        numeros[0] = 100;

        //Interando todos os itens da lista
        //?_ item é sincular e o collection plural

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        //---------------------------------------------------------------------------------//

        foreach (string listaNome in listaNomes)
        {
            Console.WriteLine(listaNome);
        }

        //---------------------------------------------------------------------------------//

        //Criando uma lista com objetos da Classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno á minha lista
        //*_ Existe dois jeitos de adicionar coisas na lista
        Aluno novoAluno = new Aluno("Pedro", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia", 17));
        listaAlunos.Add(new Aluno("Chayenne", 16));

        //Exibindo lista de alunos
        Console.WriteLine("Lista de Alunos:");
        foreach (Aluno listaAluno in listaAlunos)
        {
            Console.WriteLine(listaAluno.nome);
        }

        //LINQ utilizando Sintaxe de consulta

        //Criando uma nova lista, ordenando por nome
        var ordenacao = from aluno in listaAlunos
                        orderby aluno.nome
                        select aluno.nome;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno);
        }

        //LINQ utilizando Sintaxe de método
        var consulta = listaAlunos
                    .Where(aluno => aluno.idade == 17)
                    .OrderBy(aluno => aluno.nome);
                    
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }

    }
}