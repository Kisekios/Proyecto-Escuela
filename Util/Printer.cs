using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tamaño = 50)
        {
            WriteLine(new string('=', tamaño));
        }
        public static void EscribirTitulo(string titulo)
        {
            DibujarLinea(titulo.Length);
            WriteLine(titulo);
            DibujarLinea(titulo.Length);
        }
        public static void Sonido(int hz = 2000, int tiempo = 500, int veces = 1)
        {
            while (veces-- > 0)
            {
                System.Console.Beep(hz, tiempo);
            }
        }
    }
}