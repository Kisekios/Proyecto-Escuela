using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string IDunico { get; private set; }
        public string Nombre { get; set; } = "";
        public TiposJornada Jornada { get; set; }

        public Curso()=>IDunico = Guid.NewGuid().ToString();
    }
}