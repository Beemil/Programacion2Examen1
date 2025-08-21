

namespace Programacion2Examen1
{
    public class Asignatura
    {
        public string NombreAsignatura { get; set; }
        public string NombreDocente { get; set; }
        public string Horario { get; set; }

        public Asignatura() { }

        public Asignatura(string nombreAsignatura, string nombreDocente, string horario)
        {
            NombreAsignatura = nombreAsignatura;
            NombreDocente = nombreDocente;
            Horario = horario;
        }
    }
}
