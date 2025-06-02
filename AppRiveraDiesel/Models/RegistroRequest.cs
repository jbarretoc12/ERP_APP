using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRiveraDiesel.Models
{
    public class RegistroRequest
    {
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string ConfirmarContrasena { get; set; }
    }
}
