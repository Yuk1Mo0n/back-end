//!--- namespace é usado para fazer referencia quando usamos outras classes

namespace Sesai.Model
{
    //*--- declaração de classe'Aluno'
    public class Aluno
    {
        //*Codigo pra declarar o recurso 'atributo' da classe  
        public string nome { get; set; }

        public int idade { get; set; }
        public string turma { get; set; }

        private int nrFaltas { get; set; }

        //--- Criando um metodo
        public void Apresentar()
        {
            Console.WriteLine($" Olá, Meu nome é {nome}, eu tenho {idade} e estudo na turma {turma} ");
        }
        public void AdicionarFaltas(int nr)
        {
            nrFaltas = nrFaltas + nr;
        }
        public void JustificarFaltas(int nr)
        {
            nrFaltas = nrFaltas - nr;
        }
        public void ResumirFaltas()
        {
            Console.WriteLine($"{nome} você tem {nrFaltas} faltas");
        }
    }
}