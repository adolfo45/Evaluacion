using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Usuarios
    {
        public int UsuarioId { get; }
        public string CorreoElectronico { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public bool Estatus { get; set; }
        public int Sexo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
