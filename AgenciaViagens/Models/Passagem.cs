using System.ComponentModel.DataAnnotations;
using System;

namespace AgenciaViagens.Models
{
  public class Passagem
  {
    [Key]
    public int id { get; set; }

    [Display(Name = "Usuário")]
    [Required(ErrorMessage = "Campo obrigatório")]
    public int usuarioId { get; set; }
    public Usuario usuario { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public int viagemId { get; set; }
    public Viagem viagens { get; set; }
  }
}