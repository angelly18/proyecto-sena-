using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mi_proyecto_sena.Models
{
    public class usuarioModel
    {
        
        public int usuario_Id { get; set; }
        [Required(ErrorMessage = "nombre obligatorio")]
        public required string usuario_Nombre { get; set; }
        [Required(ErrorMessage = "Apellido obligatorio")]
        public required string usuario_Apellido { get; set; }
        [Required(ErrorMessage = "correo obligatorio")]
        public required string usuario_Correo { get; set; }
        [Required(ErrorMessage = "contraseña obligatoria")] 
        [MinLength(6,ErrorMessage = "contraseña debe tener menos de 6 caracteres")]
        public required string usuario_contraseña { get; set; }
    }
}  