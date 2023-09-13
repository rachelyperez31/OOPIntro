namespace MiembroDeLaComunidadPJR.Class
{
    public class Maestro : Docente
    {
        public decimal Bonificacion { get; set; }

        public override void CalcularSalario()
        {
            Console.WriteLine("Calculando salario de maestro...");
        }
    }
}
