﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RS181977_TB181979_desafío01.Models
{
    public class TipoCuentaBancaria
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Tipo de cuenta bancaria")]
        [StringLength(150)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo tipo de cuenta bancaria requerido")]
        public String Tipo_CuentaBancaria { get; set; }
        [Display(Name = "Activo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo activo requerido")]
        public Boolean Activo { get; set; }

    }
}