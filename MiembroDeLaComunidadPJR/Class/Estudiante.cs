namespace MiembroDeLaComunidadPJR.Class
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public string? GradoCurso { get; set; }
        public double PromedioAcademico { get; set; }

        public override void Guardar(MiembroDeLaComunidad miembroComunidad)
        {
            // base.Guardar(miembroComunidad);
            Console.WriteLine("Guardando estudiante...");
        }

        public override void Modificar(MiembroDeLaComunidad miembroComunidad)
        {
            Console.WriteLine("Modificando estudiante...");
        }

        public override void Eliminar(MiembroDeLaComunidad miembroComunidad)
        {
            Console.WriteLine("Eliminando estudiante...");
        }

        public void AgregarAsignacion() {
            Console.WriteLine("Agregando asignación...");
        }

    }
}
