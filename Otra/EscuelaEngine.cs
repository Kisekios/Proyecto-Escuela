using CoreEscuela.Entidades;


namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuelas Escuela { get; set; }
        public EscuelaEngine()
        {

        }
        public void Inicializar(){
            Escuela = new Escuelas("Deko Academy", 2020, TiposDeEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");

            Escuela.Cursos = new List<Curso>(){
            new Curso(){Nombre = "101", Jornada = TiposJornada.Mañana},
            new Curso(){Nombre = "201", Jornada = TiposJornada.Mañana},
            new Curso(){Nombre = "301", Jornada = TiposJornada.Mañana},
            new Curso(){Nombre = "102", Jornada = TiposJornada.Tarde},
            new Curso(){Nombre = "202", Jornada = TiposJornada.Tarde},
            new Curso(){Nombre = "302", Jornada = TiposJornada.Tarde},
            };
        }
    }
}