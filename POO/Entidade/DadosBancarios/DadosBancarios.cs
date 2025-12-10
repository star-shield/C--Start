public class DadosBancarios
{
    private double saldo;
    private double limite = 1000;

    public double Saldo
    {
        get {return saldo;}
        set
        {
             if (value + saldo <= limite && value >=0)
            {
            saldo += value;
            Console.WriteLine("Valor adicionado na conta");
            }
            else Console.WriteLine("Valor acima do limite, tente novamente");
        }
    }
}