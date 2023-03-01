using CoreEscuela.Entidades;
using static System.Console;


namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuelas("Deko Academy", 2020, TiposDeEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";
            WriteLine(new string('=', 50) + (System.Environment.NewLine) + escuela + (System.Environment.NewLine) + new string('=', 50));

            escuela.Cursos = new Curso[]  {
                new Curso(){Nombre = "101"},
                new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"}
            };


            WriteLine(new string('=', 50));
            ImprimirCursos(escuela);
            WriteLine(new string('=', 50));

            if (true)
            {

            }
        }

        private static void ImprimirCursos(Escuelas escuela)
        {
            WriteLine(new string('=', 50));
            WriteLine("Cursos de la escuela");
            WriteLine(new string('=', 50));
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, ID: {curso.IDunico}");
                }
            }
        }
    }
}
