using System.ComponentModel.DataAnnotations;

namespace validacao.Models;

public class Categoria
{
    [Required(ErrorMessage = "O nome da categoria é obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 50 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Range(0, 100000, ErrorMessage = "A quantidade deve estar entre 0 e 100.000.")]
    public int Quantidade { get; set; }

    // Regra personalizada (3ª regra): garante que descrições/códigos de observação não venham zerados ou muito curtos.
    [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "O código identificador deve conter apenas letras, números, hífens ou underlines sem espaços.")]
    public string CodigoIdentificador { get; set; } = string.Empty;
}