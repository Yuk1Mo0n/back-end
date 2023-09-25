Console.WriteLine("Qual mês deseja?");
int meses = int.Parse(Console.ReadLine());

switch(meses){
    case 01:
        Console.WriteLine("Mês 1, 31 dias");
        break;
    case 02:
        Console.WriteLine("Mês 2, 28 dias");
        break;
    case 03:
        Console.WriteLine("Mês 3, 31 dias");
        break;
    case 04:
        Console.WriteLine("Mês 4, 30 dias");
        break;
    case 05:
        Console.WriteLine("Mês 5, 31 dias");
        break;
    case 06:
        Console.WriteLine("Mês 6, 30 dias");
        break;
    case 07:
        Console.WriteLine("Mês 7, 31 dias");
        break;
    case 08:
        Console.WriteLine("Mês 8, 31 dias");
        break;
    case 09:
        Console.WriteLine("Mês 9, 30 dias");
        break;
    case 10:
        Console.WriteLine("Mês 10, 31 dias");
        break;
    case 11:
        Console.WriteLine("Mês 11, 30 dias");
        break;
    case 12:
        Console.WriteLine("Mês 12, 31 dias");
        break;
    default:
        Console.WriteLine("Não tem");
        break;
}