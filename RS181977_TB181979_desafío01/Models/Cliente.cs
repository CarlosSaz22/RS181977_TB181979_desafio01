using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RS181977_TB181979_desafío01.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }


        [StringLength(100)]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Campo nombres requerido")]
        public String nombres { get; set; }

        [Display(Name = "Primer apellido")]
        [StringLength(100)]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Campo primer apellido requerido")]
        public String primerApellido { get; set; }

        [Display(Name = "Segundo apellido")]
        [StringLength(100)]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Campo segundo apellido requerido")]
        public String segundoApellido { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "El teléfono no cumple con el formato correcto")]
        [StringLength(8)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo teléfono requerido")]
        public string Telefono { get; set; }

        [StringLength(100)]
        [EmailAddress(ErrorMessage = "El correo no cumple con el formato correcto")]
        public string email { get; set; }

      

       
    }
}