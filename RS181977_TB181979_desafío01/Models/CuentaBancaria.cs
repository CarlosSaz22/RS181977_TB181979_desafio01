using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RS181977_TB181979_desafío01.Models
{
    public class CuentaBancaria
    {

        [Key]
        public int id { get; set; }

        public int? idCliente { get; set; }
        public virtual Cliente Clientes { get; set; }
       

        [StringLength(100)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo moneda requerido")]
        public String Moneda { get; set; }

        public int? Tipo { get; set; }
        public virtual TipoCuentaBancaria TipoCuentaBancarias { get; set; }

    }
}