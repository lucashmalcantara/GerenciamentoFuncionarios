using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Nome completo")]
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string NomeCompleto { get; set; }

        [DisplayName("Código")]
        [Column(TypeName = "nvarchar(10)")]
        public string Codigo { get; set; }

        [DisplayName("Posição")]
        [Column(TypeName = "nvarchar(100)")]
        public string Posicao { get; set; }

        [DisplayName("Localização do escritório")]
        [Column(TypeName = "nvarchar(100)")]
        public string LocalizacaoEscritorio { get; set; }
    }
}
