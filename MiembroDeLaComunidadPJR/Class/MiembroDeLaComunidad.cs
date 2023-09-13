using System.Net.WebSockets;

namespace MiembroDeLaComunidadPJR.Class
{
    public abstract class MiembroDeLaComunidad : IMiembroDeLaComComando
    {
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Direccion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaTermino { get; set; }

        public virtual void Guardar(MiembroDeLaComunidad miembroComunidad)
        {
            Console.WriteLine("Guardando...");
            // Console.ReadKey();
        }

        public virtual List<MiembroDeLaComunidad> GetMiembrosDeLaComunidad()
        {
            Console.WriteLine("Obteniendo miembros de la comunidad...");
            return new List<MiembroDeLaComunidad>();
        }

        public virtual void Modificar(MiembroDeLaComunidad miembroComunidad)
        {
            Console.WriteLine("Modificando...");
        }

        public virtual void Eliminar(MiembroDeLaComunidad miembroComunidad)
        {
            Console.WriteLine("Eliminando...");
        }

    }
}
