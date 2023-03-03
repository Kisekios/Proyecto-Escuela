using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEscuela.Entidades;
using CoreEscuela;
using CoreEscuela.Otra;


namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string IDunico { get; private set; }
        public string Nombre { get; set; } = "";

        public Alumno() => IDunico = Guid.NewGuid().ToString();

        public Evaluaciones Evaluaciones { get; set;}
    }
}