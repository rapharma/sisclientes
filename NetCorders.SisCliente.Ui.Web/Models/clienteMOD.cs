using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.SisCliente.Ui.Web.Models
{
    [Table("Tb_Cliente")]
    public class clienteMOD
    {
        [Key]
        public int Codigo { get; set; }
        //Data Annotations para validar os campos
        [Required(ErrorMessage = "Digite o nome")]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}