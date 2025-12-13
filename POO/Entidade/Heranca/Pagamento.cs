public interface IPagamento
{
    void Pagar();
}

public abstract class Pagamento : IPagamento
{
    public decimal Valor {get; set;}
    public DateTime DataPagamento {get; set;}
    public abstract void Pagar();
}

public class Pix : Pagamento
{
    public string? ChavePix {get; set;}

    public override void Pagar()
    {
        Console.WriteLine($"Pagamento via Pix de R${Valor:F2} realizado na Data: {DataPagamento}");
    }
}

public class CartaoCredito : Pagamento
{
    public string? NumeroCartao {get; set;}

    public override void Pagar()
    {
        Console.WriteLine($"Pagamento via Cartão de Crédito de R${Valor:F2} realizado na Data: {DataPagamento}");
    }
}