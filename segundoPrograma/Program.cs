using System;
using System.Threading;

namespace segundoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante primerEstudiante = new Estudiante();
            Curso primerCurso = new Curso();
            Carrera primerCarrera = new Carrera();

            Console.WriteLine("Ingrese su nombre: ");
            primerEstudiante.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            primerEstudiante.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese apodo: ");
            primerEstudiante.Apodo = Console.ReadLine();
            Console.WriteLine("Ingrese su nivel: ");
            primerCurso.Nivel = Console.ReadLine();
            Console.WriteLine("Ingrese su paralelo: ");
            primerCurso.Paralelo = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de escritorios: ");
            primerCurso.Escritorios = Console.ReadLine();
            Console.WriteLine("Ingrese la carrera a seguir: ");
            primerCarrera.Nombre_carrera = Console.ReadLine();
            Console.WriteLine("Ingrese la modalidad: ");
            primerCarrera.Modalidad = Console.ReadLine();


            string registro_a = primerEstudiante.Registro_alumno(primerEstudiante.Nombre, primerEstudiante.Apellido, primerEstudiante.Apodo);
            string registro_c = primerCurso.Registro_curso(primerCurso.Nivel, primerCurso.Paralelo, primerCurso.Escritorios);
            string registro_ca = primerCarrera.Registro_carrera(primerCarrera.Nombre_carrera, primerCarrera.Modalidad);
            Console.WriteLine(registro_a + registro_c + registro_ca);
        }
    }
}
