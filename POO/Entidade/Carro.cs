
public class Carro
{
     public string Marca {get; set;} = string.Empty;
     public string Modelo {get; set;} = string.Empty;  
     public int Ano {get; set;}

     public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;      
    }  

    public override string ToString()
    {
        return $"{Marca}, {Modelo}, {Ano}";
    }
}
