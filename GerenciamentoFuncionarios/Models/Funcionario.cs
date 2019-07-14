using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios.Models
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string NomeCompleto { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Codigo { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Posicao { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LocalizacaoEscritorio { get; set; }
    }
}
