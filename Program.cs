using CoreEscuela.Entidades;
using static System.Console;


namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            WriteLine(new string('=', 50) + (System.Environment.NewLine) + engine.Escuela + (System.Environment.NewLine) + new string('=', 50));
            ImprimirCursos(engine.Escuela); 
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
