
class Program
{

    public static void Main()
    {
        ListaChurrasco();



    }
    public static void ListaChurrasco()
    {
        string[] lista = new string[6];

        lista[0] = "1kg Picanha";
        lista[5] = "Pão de alho";
        lista[4] = "Carvão";
        lista[3] = "Queijo coalho";
        lista[2] = "Guarana";
        lista[1] = "Farofa";

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("Itens que normalmente compra para churrasco");
            string produto = Console.ReadLine();

            lista[i] = produto;

        }
        Array.Sort(lista);
        foreach (string item in lista)
        {
            Console.WriteLine(item);

        }

    }

    public static void ListaSonhos()
    {
        string[] sonhos = new string[3];
        decimal[] valores = new decimal[3];
        decimal total = 0;

        for (int i = 0; i < 3; i++){
            Console.WriteLine($"Informe o seu {i}º sonho");
            string sonho = Console.ReadLine();
            Console.WriteLine($"Informe o valor do {i}º sonho");
            decimal valor = decimal.Parse(Console.ReadLine());
            sonhos[i] = sonho;
            valores[i] = valor;
        }
    }

}
