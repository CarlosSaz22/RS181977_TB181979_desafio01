﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RS181977_TB181979_desafío01.Models
{
    public class TipoTransaccion
    {

        [Key]
        public int id { get; set; }

        [Display(Name = "Tipo de transacción")]
        [StringLength(150)]
        [Required(ErrorMessage = "Campo tipo transacción requerido")]
        public String Tipo_Transaccion { get; set; }
    }
}