//media de 3 notas

Console.WriteLine("Coloque nome de Aluno");
string nomeAluno = (Console.ReadLine());

Console.WriteLine("Nota da 1° etapa:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Nota da 2° etapa:");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Nota da 3° etapa:");
int z = int.Parse(Console.ReadLine());

int nota = (x + y + z) / 3;

//Console.WriteLine($"A nota do {nomeAluno} é {nota}");

if (nota >=  7){
    Console.WriteLine($" O {nomeAluno} {nota} passou ");
}else {
    Console.WriteLine($" O {nomeAluno}  {nota} reprovou ");
}
