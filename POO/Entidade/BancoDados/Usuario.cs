public class Usuario
{
    public string email {get; set;}
    public string senha {get; set;}

    public Usuario(string email ="não informado", string senha ="não informado")
    {
        this.email = email;
        this.senha = senha;
    }
}