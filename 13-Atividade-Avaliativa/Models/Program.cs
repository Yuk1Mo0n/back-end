namespace Models
{

    public class Banco
    {
        private int saldo { get; set; } = 0;
        private string titular { get; set; } = "";

        public Banco(string titularNome)
        {
            this.titular = titularNome;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"O seu saldo atual é {saldo}");
            int valorConta = int.Parse(Console.ReadLine());
        }
        public void Depositar()
        {
            Console.WriteLine(" Quantos vocês que adicionar? ");
            int dinheiroDepositado = int.Parse(Console.ReadLine());
            saldo += dinheiroDepositado;
        }
        public void Sacar()
        {
            Console.WriteLine(" Quantos vocês quer sacar? ");
            int dinheiroSacado = int.Parse(Console.ReadLine());
            saldo -= dinheiroSacado;
        }

    }
}