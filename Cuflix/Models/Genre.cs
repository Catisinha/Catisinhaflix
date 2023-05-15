using System.ComponentModel.DataAnnotations;

namespace Cuflix.Models;

public class Genre
{
    [Key] // Define a propriedade como chave primária
    public byte Id { get; set; }

    [Required] // Requerido - Not Null; Validação
    [StringLength(30)] // Tamanho máximo da propriedade
    public string Name { get; set; }
}