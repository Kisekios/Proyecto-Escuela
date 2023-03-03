using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEscuela.Entidades;
using CoreEscuela;
using CoreEscuela.Otra;


namespace CoreEscuela.Entidades
{
    public class Evaluaciones
    {
        public string IDunico { get; private set; }
        public string Nombre { get; set; } = "";
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura {get;set;}
        public float Nota { get; set; }

        public Evaluaciones() => IDunico = Guid.NewGuid().ToString();

        internal void Add(Evaluaciones ev)
        {
            throw new NotImplementedException();
        }
    }
}