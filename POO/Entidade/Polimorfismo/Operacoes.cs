public class OperacoesAritmeticas
{
    public virtual decimal Operacao (int a, int b)
    {
        return 0;
    }
}

public class Soma : OperacoesAritmeticas
{
    public override decimal Operacao (int a, int b)
    {
        return a + b;
    }
}

public class Subtracao : OperacoesAritmeticas
{
    public override decimal Operacao (int a, int b)
    {
        return a - b;
    }
}

public class Multiplicacao : OperacoesAritmeticas
{
    public override decimal Operacao (int a, int b)
    {
        return a * b;
    }
}

public class Divisao : OperacoesAritmeticas
{
    public override decimal Operacao (int a, int b)
    {
        return a / b;
    }
}

public class Calculadora
{
    public decimal Calcular (OperacoesAritmeticas operacao, int a, int b)
    {
        return operacao.Operacao(a , b);
    }
}