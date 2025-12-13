// class Program
// {
//     static void Main()
//     {
//***************Banco de dados com validação******************
// Console.Write("Infome um email: ");
// string email = Console.ReadLine()!;
// Console.Write("Informe uma senha: ");
// string senha = Console.ReadLine()!;

// Usuario usuario = new Usuario(email, senha);
// if(Validar.ValidarEmailESenha(usuario.email, usuario.senha))
// {
//     Console.WriteLine("------------------------");
//     Console.WriteLine("Email e senha válidos✅");
//     Console.WriteLine("------------------------");
//     await BancoDados.SalvarUsuarioAsync(usuario);
//     Console.WriteLine("------------------------");
//     Console.WriteLine("Processamento assíncrono iniciado para salvar o usuário🙌");
// }
// else
// {
//     Console.WriteLine("Email ou senha não são válidos ou fortes");
// }

//**************Dados bancarios com depósito**********************
// DadosBancarios dados = new DadosBancarios();
// int continuar=0;
// do
// {
//     dados.Saldo = double.Parse(Console.ReadLine()!);
//     Console.WriteLine($"Seu saldo é: {dados.Saldo}");
//     continuar = int.Parse(Console.ReadLine()!);
// }while(continuar == 1);


//     }
// }

// class Program
// {
//     static void Main()
//     {
//          Calculadora calculadora = new Calculadora();

//         int a = 3, b = 5;

//         OperacoesAritmeticas soma = new  Soma();
//         OperacoesAritmeticas subtracao = new  Subtracao();
//         OperacoesAritmeticas multiplicacao = new  Multiplicacao();
//         OperacoesAritmeticas divisao = new  Divisao();

//         decimal resultadoSoma = calculadora.Calcular(soma, a, b);
//         decimal resultadoSubtracao = calculadora.Calcular(subtracao, a, b);
//         decimal resultadoMultiplicacoa = calculadora.Calcular(multiplicacao, a, b);
//         decimal resultadoDivisao = calculadora.Calcular(divisao, a, b);

//         Console.WriteLine($"O calcúlo dos números {a} e {b} usando polimorfismo\n");
//         Console.WriteLine($"Soma: {resultadoSoma}");
//         Console.WriteLine($"Subtração: {resultadoSubtracao}");
//         Console.WriteLine($"Multiplicação: {resultadoMultiplicacoa}");
//         Console.WriteLine($"Divisão: {resultadoDivisao}");
//     }
// }

class Program
{
    static void Main()
    {
        Pix pix = new Pix();
        pix.DataPagamento = DateTime.Now;
        pix.Valor = 1000.0m;
        pix.ChavePix = "kasdklfjk";
        pix.Pagar();

        CartaoCredito cartaoCredito = new CartaoCredito();
        cartaoCredito.Valor = 100m;
        cartaoCredito.DataPagamento = DateTime.Now;
        cartaoCredito.Pagar();
    }
}