namespace MiembroDeLaComunidadPJR.Class
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public string? EstadoAcademico { get; set; }

        public override void Guardar(MiembroDeLaComunidad miembroComunidad)
        {
            // base.Guardar(miembroComunidad);
            Console.WriteLine("Guardando ex-alumno...");
        }

        public override void Modificar(MiembroDeLaComunidad miembroComunidad)
        {
            Console.WriteLine("Modificando ex-alumno...");
        }

        public override void Eliminar(MiembroDeLaComunidad miembroComunidad)
        {
            Console.WriteLine("Eliminando ex-alumno...");
        }

    }
}
