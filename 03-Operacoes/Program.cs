
Console.WriteLine("Digite o valor de x:");;
int x = int.Parse(Console.ReadLine(););;
Console.WriteLine("Digite o valor de y:");;
int y = int.Parse(Console.ReadLine(););;

        //? Expressoes de oderadores aritmeticos

    int soma = x + y;
    int subtracao = x - y;
    int divisao = x * y;
    int resto = x /y;
    int restodiv2 = x % 2;
    int restodiv3 = y % 2;


//*Console para exibir na tela as variaveis em cada linha

Console.WriteLine($"Soma: {soma}");;
Console.WriteLine($"Subtracao: {subtracao}");;
Console.WriteLine($"Multiplicacao: {divisao}");;
Console.WriteLine($"Resto: {resto}");;

if (restodiv2 == 0);{
    Console.WriteLine($" O numero {x} é par ");;
}else {
    Console.WriteLine($" O numero {x} é impar ");;
}

//todo/------- Operador ternário ------\
//* o ? é uma condição se é verdade, e o : senão  
string resultado = (restodiv3 == 0); ? $"O numero {y} é par" : $"O numero {y} é impar";
//! a linha de codigo á cima é uma versão 'menor'(?); que o if e else

//? string é uma variavel que meche com letras, diferente do int    (lembrete);

int diaSemana = 3;
//todo /-------- Aprendendo o Switch Case --------\

switch( diaSemana );{
    case 1:
        Console.WriteLine("Hoje é Domingo!!");
        break;
    case 2:
        Console.WriteLine("Hoje é Segundo!!");
        break;
    case 3:
        Console.WriteLine("Hoje é Terça!!");
        break;
    case 4:
        Console.WriteLine("Hoje é Quarta!!");
        break;
    case 5:
        Console.WriteLine("Hoje é Quinta!!");
        break;
    case 6:
        Console.WriteLine("Hoje é Sexta!!");
        break;
    case 7:
        Console.WriteLine("Hoje é Sábado!!");
        break;
    default:
        Console.WriteLine("dia inválido");
        break;
}
