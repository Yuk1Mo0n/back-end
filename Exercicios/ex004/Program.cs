class 004{
    public static void Main()
    {
        int valorD = int.Parse(Console.ReadLine());
        int resultadoDobro = Dobro(valorD);
        Console.WriteLine($"Dobro do {valorD} é {resultadoDobro}");
        Tabuada(valorD);
        SomaWhile();
    }

    public static int Dobro(int valor)
    {
        int soma = valor * 2;
        return soma;
    }

    public static int Metade(int valor)
    {
        int resultadoa = valor / 2;
        return resultadoa;
    }

    public static int Tabuada(int valor)
    {
        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine($"{valorD} x {contador} = {valorD * contador}");
            contador++;
        }
    }

    public static void SomaWhile("Digite o valor desejado")
    {
        int soma = 0;
        int menor = 10000;
        int maior = 0;
        int comp = 0;
        do
        {

            comp = int.Parse(Console.ReadLine());

            if (comp > 0)
            {
                soma = soma + comp;
            }
            i(comp > maior){
                maior = comp;
            }
            if (comp < menor && comp comp > 0){
                menor = comp;
            }
        }
        while (comp > 0);
        Console.WriteLine($"A soma dor numeros é {soma}, o maior numero é {maior}, e o menor é {menor}")
    }
}
