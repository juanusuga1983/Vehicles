﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Models
{
    public class LoginViewModel
    {
        [Display(Name ="Email")]
        [EmailAddress(ErrorMessage ="Debes introducir un email válido.")]
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        [MinLength(6, ErrorMessage = "El campo {0} debe tener una longitud minima de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Password { get; set; }

        [Display(Name ="Recuerdame")]
        public bool RememberMe { get; set; }
    }
}
