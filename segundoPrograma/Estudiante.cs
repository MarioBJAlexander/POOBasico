using System;

namespace segundoPrograma
{
    class Estudiante
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Apodo { get; set; }

        public string Registro_alumno(string Nombre,string Apellido, string Apodo)
        {
             return "Registro Nro: 1, Nombre:"+ Nombre +", Apellido: "+ Apellido + ", Apodo: " + Apodo;
        }
    }
}
