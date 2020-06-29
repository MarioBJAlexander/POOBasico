using System;
using System.Collections.Generic;
using System.Text;

namespace segundoPrograma
{
    class Carrera
    {
        public int Id { get; set; }

        public string Nombre_carrera { get; set; }

        public string Modalidad { get; set; }

        public string Registro_carrera(string Nombre_carrera, string Modalidad)
        {
            return ", Nombre de la carrera: " + Nombre_carrera + ", Modalidad: " + Modalidad;
        }
    }
}
