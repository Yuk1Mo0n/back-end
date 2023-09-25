
class Animal
{
    public string cor { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}

class Gato : Animal
{
        public override void EmitirSom()
    {
        Console.WriteLine("O Gato esta miando");
    }
}
class Cachorro : Animal
{
    public string tipoPelo { get; set; }
    public void Latir()
    {
        Console.WriteLine($"O cachorro {cor} está latindo");
    }
}
class Program
{
    public static void Main()
    {
       // Animal animalGenerico = new Animal();
       // animalGenerico.EmitirSom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.Latir();
       // meuCachorro.EmitirSom();
        meuCachorro.cor = "Caramelo";

        Gato meugato = new Gato();
        meugato.EmitirSom();
    }
}

//!-----------    --------------