using CB.Entidades;

namespace CB.Core.Aplicacion.Service.Pruebas
{
    public interface IPruebaService
    {
        Task<IList<testModel>> get();
    }
}
