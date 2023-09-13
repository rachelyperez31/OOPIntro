using MiembroDeLaComunidadPJR.Class;

namespace MiembroDeLaComunidadPJR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();
            Docente docente1 = new Docente();
            Administrador admin1 = new Administrador();

            estudiante1.Nombre = "Rachely";
            estudiante1.Apellido = "Pérez";
            estudiante1.Codigo = "20221856";

            estudiante1.Guardar(estudiante1);

            docente1.Nombre = "Francis";
            docente1.Apellido = "Ramírez";
            docente1.Asignatura = "Programación II";

            docente1.Guardar(docente1);

            admin1.CalcularSalario();
        }
    }
}