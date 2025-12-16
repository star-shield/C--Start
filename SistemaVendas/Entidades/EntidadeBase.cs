using System.ComponentModel.DataAnnotations;
namespace SistemaVendas.Entidades;

public abstract class EntidadeBase
{
    [Key]
    public int Id {get; set;}
    public DateTime CriadoEm { get; set; }
    public DateTime AtualizadoEm { get; set; }
    public bool Deletado { get; set; } = false;
}