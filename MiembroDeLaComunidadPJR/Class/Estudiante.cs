namespace MiembroDeLaComunidadPJR.Class
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public string? GradoCurso { get; set; }
        public double PromedioAcademico { get; set; }

        public void AgregarAsignacion() {
            Console.WriteLine("Agregando asignación...");
        }

    }
}
