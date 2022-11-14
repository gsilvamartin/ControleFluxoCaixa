using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIMSLancamentos.Repository.Context.Model
{
    [Table("lancamentos")]
    public class Lancamentos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}

