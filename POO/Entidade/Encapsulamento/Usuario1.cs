public class Usuario1
{
    public string Id {get; set;}
    public string Name {get; set;}
    private int idade;

    public int Idade
    {
        get {return idade;}
        set
        {
            if (value >= 0)
            {
                idade = value;
                Console.WriteLine("Dado modificado!");
            }
            else
            {
                Console.WriteLine("Idade inválida");
            }
        }
    }
}