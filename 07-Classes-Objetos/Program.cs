//!-- Quando tiver que usar biblioteca ou as classes já criadas, lembrar de usar o 'using'

using Sesai.Model;

class Program
{
    public static void Main()
    {
        //*-- Criando uma variavel que sera fornecida pela class 'Aluno'
        var aluno1 = new Aluno();

        //-- Distribuição de um valor para informar o 'aluno1'
        aluno1.nome = " Rafael ";
        aluno1.idade = 16;
        aluno1.turma = " 2º EM ";

        aluno1.Apresentar();


        aluno1.ResumirFaltas();
        aluno1. AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1. AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);
        aluno1.ResumirFaltas();

        var aluno2 = new Aluno();

        aluno2.nome = " Claudia ";
        aluno2.idade = 14;
        aluno2.turma = " 8º ano ";

        aluno2.Apresentar();

    }
}