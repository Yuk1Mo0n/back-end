
//!-------------------------------  moderador de acesso  -------------------------------------
    //* public - informação que pode ser visto a todos 
        //* private - informação que só pode ser exibido para uma 'sala'(informação privada)
    //* protected - informação com proteção






//!------ FUNÇÃO / MÉTODO EM C# ----------------------
    //*public static string nomeFuncao(string nome){}


//? algo sem retorno é algo sem string no parentese ☺☻♥♦♣•◘○◙♂♀♪♫☼►☺↕‼¶§▬↨↑↓→←∟↔▲▼ !%&'())*+,-./0123456789:;<34568?@ABCDEFGHIJKLNMNOPQRSTUVWXYZ[]\]^_`abcdefghijklmnopqrstuvwxyz{}|}~⌂ÇüéâäàåçêëèïîìÄÅÉæÆôöòûùÿÖÜø£Ø×ƒáíóúñÑªº¿®¬½¼¡«»░▒▓│┤ÁÂÀ©╣║╗╝¢¥┐└┴┬├─┼ãÃ╚╔╩╦╠═╬¤ðÐÊËıÍÎÏ┘┌█▄¦Ì▀ÓßÔÒõÕµþÞÚÛÙýÝ¯´­±­‗¾¶§÷¸°¨

//todo||| é recomendado usar o mesmo nome que o arquivo, porem pode ser diferente o nome(pode ser util essa informação)
class Sesi{

    public static void Main(){
        mostrarMensagem("Seja bem vindo");
        mostrarMensagem("SESI / SENAI");
        imprimeDataHora();
        double potencia = Potenciacao(4);
        Console.WriteLine($"Potenciação {potencia}");
        contagemRegressiva(10);
        JogoqyeNrSou();
    }

    public static double Potenciacao(int num){
        double resultado = Math.Pow(num, 4);
        return resultado;
    }

    public static void imprimeDataHora() {
        Console.WriteLine(DateTime.Now.ToString());
    }
    public static void mostrarMensagem(string mensagem) {
        Console.WriteLine(mensagem);
    }


    public static void contagemRegressiva(int n){
        
        while(n >= 0){
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("aaaaaaaaaaa") ;
    }

    public static void JogoqyeNrSou(){
    
        Console.WriteLine("********************************************");
        Console.WriteLine("*             Bem vindo ao Jogo            *");
        Console.WriteLine("*Sorteei um nº de 1 a 20, tente adivinha-lo*");
        Console.WriteLine("*                                          *");
        Console.WriteLine("********************************************");
        Console.WriteLine("");
        
        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        int nrDigitado = -1;

        do{
            Console.WriteLine("Digite um nº");
            nrDigitado = int.Parse (Console.ReadLine());
            if (nrDigitado > nrSorteado)
                Console.WriteLine("O número digitando é MAIOR que o sorteado");
            else if(nrDigitado < nrSortead20)
        Console.WriteLine("Parabéns você acertou‼");
        }
    }
}