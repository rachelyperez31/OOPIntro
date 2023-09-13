namespace MiembroDeLaComunidadPJR.Class
{
    public interface IMiembroDeLaComComando
    {
        void Guardar(MiembroDeLaComunidad miembroComunidad);
        List<MiembroDeLaComunidad> GetMiembrosDeLaComunidad();
        void Modificar(MiembroDeLaComunidad miembroComunidad);
        void Eliminar(MiembroDeLaComunidad miembroComunidad);
    }
}
