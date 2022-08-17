using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona(string Nombre, string Apellido, string Documento, int Edad, DateTime fechaNac)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Documento = Documento;
            this.Edad = Edad;
            this.FechaNacimiento = fechaNac;
        }

    }
}
