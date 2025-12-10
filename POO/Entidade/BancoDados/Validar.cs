using System.Text.RegularExpressions;
public static class Validar
{
    private static bool ValidarEmail(string email)
    {
        //padrão regex
        string padraoEmail =  @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, padraoEmail);
    }
    private static bool ValidarSenha(string senha)
    {
        //Senha é mínimo 6, caracter especiais, numeros, letras maiusculas e minusculas
        string padraoSenha = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$";
        return Regex.IsMatch(senha, padraoSenha);
    }
    public static bool ValidarEmailESenha(string email, string senha)
    {
        return ValidarEmail(email) && ValidarSenha(senha);
    }
}