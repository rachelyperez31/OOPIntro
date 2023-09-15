namespace MiembroDeLaComunidadPJR.Class
{
    public abstract class Empleado : MiembroDeLaComunidad
    {
        public string? Cargo { get; set; }
        public string? Departamento { get; set; }
        public decimal Salario { get; set; }

        public override void Guardar(MiembroDeLaComunidad miembroComunidad)
        {
            // base.Guardar(miembroComunidad);
            Console.WriteLine("Guardando empleado...");
        }

        public override void Modificar(MiembroDeLaComunidad miembroComunidad)
        {
            Console.WriteLine("Modificando empleado...");
        }

        public override void Eliminar(MiembroDeLaComunidad miembroComunidad)
        {
            Console.WriteLine("Eliminando empleado...");
        }

        public virtual void CalcularSalario()
        {
            Console.WriteLine("Calculando salario de empleado");
        }
    }
}
