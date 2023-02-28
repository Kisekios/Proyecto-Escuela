using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuelas("Deko Academy", 2020, TiposDeEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";
            Console.WriteLine(new string('=', 50) + (System.Environment.NewLine) + escuela + (System.Environment.NewLine) + new string('=', 50));
            var curso1 = new Curso()
            {
                Nombre= "101"
            };
            var curso2 = new Curso()
            {
                Nombre= "201"
            };
            var curso3 = new Curso()
            {
                Nombre= "301"
            };
            System.Console.WriteLine(new string('=',50));
            Console.WriteLine(curso1.Nombre +  ", " + curso1.IDunico);
            Console.WriteLine($"{curso2.Nombre}, {curso2.IDunico}");
            Console.WriteLine($"{curso3.Nombre}, {curso3.IDunico}");
            System.Console.WriteLine(new string('=',50));
        }
    }
}
