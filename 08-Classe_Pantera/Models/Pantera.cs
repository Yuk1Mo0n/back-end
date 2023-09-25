namespace Animal
{

    public class Pantera
    {
        public decimal Tipo { get; set; }
        public decimal Tamanho { get; set; }
        public int Peso { get; set; }
        public string Cor { get; set; }
        public string Especie { get; set; }
        public string Alimentacao { get; set; }

        public void Correr()
        {
            Console.WriteLine($"{Tipo} está correndo/correu")
        }
        public void Cacar()
        {
            Console.WriteLine($"{Tipo} está caçando/caçou")
        }
        public void Reproduzir()
        {
            Console.WriteLine($"{Tipo} reproduziu com outra")
        }

    }





}