using System.ComponentModel.DataAnnotations;

namespace ControleEstoque
{
    public class CategoriaModel
    {
            [Key]
            public int IdCategoria{get;set;}
            [Required, MaxLength(128)]
            public string Nome{get;set;}
    }
}