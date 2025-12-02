public static class BancoDados
{
    public static async Task SalvarUsuarioAsync(Usuario usuario)
    {
        Console.WriteLine("Salvando usuário no banco de dados⌛");
        await Task.Delay(10000);
        Console.WriteLine("Usuário salvo no banco de dados");
        Console.WriteLine($"Email: {usuario.email}✅🚀");
    }
}