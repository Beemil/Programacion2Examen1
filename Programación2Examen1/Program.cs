using Programacion2Examen1;

Alumno alumno = new Alumno();
alumno.Nombre = "Alexis Ventura";
alumno.NumeroCuenta = "2020-1234";
alumno.Email = "alex0220@gmail.com";

Asignatura asignatura = new Asignatura();
asignatura.NombreAsignatura = "Programación 2";
asignatura.NombreDocente = "Ing. Edgardo Pérez";
asignatura.Horario = "Lunes y Miércoles de 9:40 a 11:40";

Matricula matricula = new Matricula();
matricula.Alumno = alumno;
matricula.Asignatura = asignatura;

try
{
    Console.WriteLine("Ingrese las 3 notas parciales: ");

    for (int i = 1; i <= 3; i++)
    {
        Console.Write($"Nota {i}: ");
        double nota = double.Parse(Console.ReadLine()!);
        matricula.NotasParciales.Add(nota);
    }

    matricula.ValidarNotas(matricula.NotasParciales[0], matricula.NotasParciales[1], matricula.NotasParciales[2]);
    double notaFinalSinParametros = matricula.CalcularNotaFinal();
    double notaFinalConParametros = matricula.CalcularNotaFinal(matricula.NotasParciales[0], matricula.NotasParciales[1], matricula.NotasParciales[2]);

    string mensajeSinParametros = matricula.ObtenerMensajeNota(notaFinalSinParametros);
    string mensajeConParametros = matricula.ObtenerMensajeNota(notaFinalConParametros);

    Console.WriteLine($"\nNota final (sin parámetros): {notaFinalSinParametros} - {mensajeSinParametros}");
    Console.WriteLine($"Nota final (con parámetros): {notaFinalConParametros} - {mensajeConParametros}");
    Console.WriteLine();
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese solo números validos");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error en las notas: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
}


