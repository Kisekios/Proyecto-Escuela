using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Deko Academy", 2020);
            escuela.Pais= "Colombia";
            escuela.Ciudad= "Bogota";
            Console.WriteLine(escuela.Nombre);
        }
    }
}
