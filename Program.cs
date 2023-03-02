using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;



namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            Printer.Sonido(hz: 10000, veces: 2, tiempo: 2000);
            engine.Inicializar();
            WriteLine(new string('=', 45) + (System.Environment.NewLine) + engine.Escuela + (System.Environment.NewLine) + new string('=', 45));
            ImprimirCursos(engine.Escuela);
        }

        private static void ImprimirCursos(Escuelas escuela)
        {
            Printer.EscribirTitulo("Cursos Habiles");
            if (escuela?.Cursos != null)
            {
                Printer.DibujarLinea(53);
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, ID: {curso.IDunico}");
                }
                Printer.DibujarLinea(53);
            }
        }
    }
}
