//! 'int' declaração de variável do tipo inteira e sem algum valor 
//todo int num1;

//* Declarando uma variavel inteira com valor atribuido
//todo int num2 = 5;

//*para atribuir algo ao int usar 'string' com um (nome) = "algo/alguem"
//? string é uma variavel
//todo string nomeAluno = "Amanda";

//*Variável com nome 'boll' que é só para (true/false)
//todo boll resultado = true;

//todo double coordenada = 1.803645628;
//todo decimal valor = 1.80M;

//! duas variáveis que são para numeros decimais
//*double é uma variável que consegue mais casas decimais
//*decimal é uma variável que não se utiliza de muitas casas decimais

int idade = 16;
string meuNome = "Yasmin";
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");

Console.WriteLine("Em qual cidade você nasceu?");
//! 'ReadLine' serve apenas para receber uma informação do usuário e armazenar em uma variável
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {nomeCidade}");
