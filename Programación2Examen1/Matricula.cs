

namespace Programacion2Examen1
{
    public class Matricula : ICalculoNota
    { 
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public List<double> NotasParciales { get; set; }

        public Matricula()
        {
            NotasParciales = new List<double>();
        }
        public Matricula(Alumno alumno, Asignatura asignatura, List<double> notasParciales)
        {
            Alumno = alumno;
            Asignatura = asignatura;
            NotasParciales = notasParciales;
        }
        public double CalcularNotaFinal()
        {
            double suma = 0;
        
            foreach (var nota in NotasParciales)
            {
                suma += nota;
            }
            return suma;
        }
       
        public double CalcularNotaFinal(double np1, double np2, double np3)
        {
            return np1+ np2 + np3;
        }

        public string ObtenerMensajeNota(double notaFinal)
        {
            if (notaFinal >=0 && notaFinal <60)
            {
                return "Reprobado";
            }
            else if (notaFinal >=60 && notaFinal <80)
            {
                return "Bueno";
            }
            else if (notaFinal >=80 && notaFinal <90)
            {
                return "Muy Bueno";
            }
            else if (notaFinal >=90 && notaFinal <=100)
            {
                return "ESobresaliente";
            }
            else
            {
                return "Nota no válida";
            }

        }

        public void ValidarNotas(double np1, double np2, double np3)
        {
            if (np1 +np2 >30)
            {
                throw new ArgumentException("La suma de las dos primeras notas no puede ser mayor a 30");
            }
            else if (np3 >40)
            {
                throw new ArgumentException("La tercera nota no debe ser mayor a 40");
            }

        }
    }
}
