public class Veiculo
{
    public virtual void Buzinar()
    {
        Console.WriteLine("Buzina genérica!");
    }
}

public class Carro : Veiculo
{
    public override void Buzinar()
    {
        Console.WriteLine("Buzina de carro: Beep Beep!");
    }
}