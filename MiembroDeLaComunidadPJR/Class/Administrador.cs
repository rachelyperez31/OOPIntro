namespace MiembroDeLaComunidadPJR.Class
{
    public class Administrador : Docente
    {
        public string? DepartamentoACargo { get; set; }

        public override void CalcularSalario()
        {
            Console.WriteLine("Calculando salario administrador...");
            Console.ReadKey();
        }

    }
}
