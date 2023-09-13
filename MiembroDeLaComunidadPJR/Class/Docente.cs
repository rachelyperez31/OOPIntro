namespace MiembroDeLaComunidadPJR.Class
{
    public class Docente : Empleado
    {
        public string? Asignatura { get; set; }

        public override void CalcularSalario()
        {
            Console.WriteLine("Calculando salario de docente...");
        }

        public override void Guardar(MiembroDeLaComunidad miembroComunidad)
        {
            Console.WriteLine("Guardando docente...");
        }

        public override void Modificar(MiembroDeLaComunidad miembroComunidad)
        {
            Console.WriteLine("Modificando docente...");
        }

        public override void Eliminar(MiembroDeLaComunidad miembroComunidad)
        {
            Console.WriteLine("Eliminando docente...");
        }
    }
}
