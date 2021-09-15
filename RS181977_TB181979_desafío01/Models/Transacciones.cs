using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RS181977_TB181979_desafío01.Models
{
    public class Transacciones
    {

        [Key]
        public int id { get; set; }

        public int? idCuentaBancaria { get; set; }
        public virtual CuentaBancaria GetCuentaBancarias { get; set; }

        public int? TipoTransaccion { get; set; }
        public virtual TipoTransaccion TipoTransacciones { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Range(1, float.MaxValue, ErrorMessage = "El monto debe ser positivo")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Campo Monto requeridos")]
        public float Monto{ get; set; }

        [StringLength(100)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo estado requerido")]
        public String Estado { get; set; }

        [Display(Name = "Fecha de transacción")]
        [Required(ErrorMessage = "Campo fecha de transacción requerido")]
        [DataType(DataType.Date)]
        public DateTime FechaTransaccion { get; set; }

        [Display(Name = "Fecha de aplicación")]
        [Required(ErrorMessage = "Campo fecha de aplicación requerido")]
        [DataType(DataType.Date)]
        public DateTime FechaAplicación { get; set; }
    }
}