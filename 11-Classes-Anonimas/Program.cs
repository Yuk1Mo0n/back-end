public class Program
{
    public static void Main()
    {
        //Class anônima(sem definição inicial)

        var pessoa1 = new
        {
            nome = "João",
            idade = 17
        };

        var pessoa2 = new
        {
            nome = "Maria",
            email = "maria@aluno.sesi.br"
        };

        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"A pessoa2 é {pessoa2.nome} e seu email é {pessoa2.email}");

        //pessoa1 = "Douglas";

        var carro1 = new
        {
            marca = "Vw",
            Modelo = "Gol",
            anoLancamento = "2021",
            cor = "Vermelho"
        };
        var carro2 = new
        {
            marca = "Ford",
            Modelo = "Ranger",
            anoLancamento = "2019",
            cor = "Prata"
        };

        Console.WriteLine($"A carro1 é da marca {carro1.marca}, do modelo {carro1.Modelo}, do ano de {carro1.anoLancamento} e da cor {carro1.cor}");
        Console.WriteLine($"A carro2 é da marca {carro2.marca}, do modelo {carro2.Modelo}, do ano de {carro2.anoLancamento} e da cor {carro2.cor}");
    }
}