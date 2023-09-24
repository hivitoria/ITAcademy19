using System.ComponentModel.DataAnnotations;

namespace DemoHelloWorldRest.DTOs;

public class Pessoa
{
    [StringLength(50, ErrorMessage = "Nome no máximo com 50 caracteres.")]
    public string Nome {get;set;} = null!; // cuidado pois esse null! com a ! após uma expressão é um truque de programação para garantir para o compilador que o que está aqui não é null e é para aceitar.
    [Required(ErrorMessage = "Idade é obrigatória.")]
    [Range(0,150,ErrorMessage = "Idade deve ser entre 0 e 150.")]
    public int? Idade {get;set;}           // int? é uma propriedade anulável e portanto é assumido que a declaração de idade é opcional.
}