
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgenciaViagens.Models
{
  public class Usuario
  {
    [Key]
    public int id { get; set; }

    [Required(ErrorMessage = "Campo nome é obrigatório")]
    public string nome { get; set; }

    [Required(ErrorMessage = "Campo email é obrigatório")]
    [MaxLength(50)]
    public string email { get; set; }

    [Required(ErrorMessage = "Campo telefone é obrigatório")]
    [MaxLength(15)]
    public string telefone { get; set; }

    [Required(ErrorMessage = "Campo cpf é obrigatório")]

    public double cpf { get; set; }

    public int idade { get; set; }

    public List<Passagem> passagens { get; set; }//Relação com a tabela passagem 

  }
}