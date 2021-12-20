using System.ComponentModel.DataAnnotations;
using System;

namespace AgenciaViagens.Models
{
  public class Viagem
  {

    [Key]
    public int id { get; set; }


    [Display(Name = "Destino")]
    [Required(ErrorMessage = "Informe o destino da viagem")]
    [StringLength(80, MinimumLength = 2, ErrorMessage = "Destino da viagem deve ter entre 2 e 80 caracteres.")]
    public string destinoViagem { get; set; }

    [Display(Name = "Preço")]
    [Required(ErrorMessage = "Informe o preço")]
    public double preco { get; set; }

    [Display(Name = "Taxas")]
    [Range(1, 100, ErrorMessage = "Valor fora da faixa de porcentagem")]
    public int taxas { get; set; }
  }
}