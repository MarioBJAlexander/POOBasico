using System;
using System.Collections.Generic;
using System.Text;

namespace segundoPrograma
{
    class Curso
    {
        public int Id { get; set; }

        public string Nivel { get; set; }

        public string Paralelo { get; set; }

        public string Escritorios { get; set; }

        public string Registro_curso(string Nivel,string Paralelo, string Escritorio)
        {
             return ", Nivel: " + Nivel +", Paralelo: "+ Paralelo + ", Nro escritorios: " + Escritorio;
        }
    }
}
