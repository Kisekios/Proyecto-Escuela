using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string IDunico { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }

        public Curso()
        {
            Random id = new Random();
            IDunico = id.Next(1,100).ToString();
        }
    }
}