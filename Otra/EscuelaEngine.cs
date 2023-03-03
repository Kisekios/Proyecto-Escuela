using CoreEscuela.Entidades;
using System.Linq;
using static System.Console;

namespace CoreEscuela.Otra
{
    public class EscuelaEngine
    {
        public Escuelas Escuela { get; set; }
        /* public EscuelaEngine()
        {
            
        } */
        public void Inicializar()
        {
            Escuela = new Escuelas("Deko Academy", 2020, TiposDeEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluaciones
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(ev);
                        }
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var ListaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre="Matematicas"},
                    new Asignatura{Nombre="Educacion Fisica"},
                    new Asignatura{Nombre="Castellano"},
                    new Asignatura{Nombre="Ciencias Naturales"},
                    new Asignatura{Nombre="Ciencias Sociales"}
                };

                curso.Asignaturas = ListaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosRandom(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipe", "Andres", "Camilo", "Nicolas", "Stiven", "Sebastian", "Juan"};
            string[] nombre2 = { "Javier", "Johan", "Daniel", "Diego", "Esneider", "Alex", "Francisco", "Miguel"};
            string[] Apellido1= {"Torres", "Plaza", "Cuervo", "Diaz", "Soler", "Rodriguez", "Gonzalez", "Rueda"};

            var listaAlumnos = from n1 in nombre1  
                                from n2 in nombre2 
                                from a1 in Apellido1
                select new Alumno{ Nombre = $"{n1} {n2} {a1}"};

                return listaAlumnos.OrderBy((al)=> al.IDunico).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
            new Curso(){Nombre = "101", Jornada = TiposJornada.Mañana},
            new Curso(){Nombre = "201", Jornada = TiposJornada.Mañana},
            new Curso(){Nombre = "301", Jornada = TiposJornada.Mañana},
            new Curso(){Nombre = "102", Jornada = TiposJornada.Tarde},
            new Curso(){Nombre = "202", Jornada = TiposJornada.Tarde},
            new Curso(){Nombre = "302", Jornada = TiposJornada.Tarde},
            };
            Random rnd = new Random();
            
            foreach (var c in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5,20);
                c.Alumnos = GenerarAlumnosRandom(cantidadRandom);
            }
        }
    }
}