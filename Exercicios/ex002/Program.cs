Console.WriteLine("Digite sua placa");
string placa = Console.ReadLine();

string ultima = placa.Substring(6);

if (ultima == "1" || ultima == "2"){
    Console.WriteLine("Você não pode rodar em SP na Segunda-Feira ");
}else if (ultima == "3" || ultima == "4"){
    Console.WriteLine("Você não pode rodar em SP na Terça-Feira ");
}else if (ultima == "5" || ultima == "6"){
    Console.WriteLine("Você não pode rodar em SP na Quarta-Feira ");
}else if (ultima == "7" || ultima == "8"){
    Console.WriteLine("Você não pode rodar em SP na Quinta-Feira ");
}else {
     Console.WriteLine("Você não pode rodar em SP na Sexta-Feira ");
};