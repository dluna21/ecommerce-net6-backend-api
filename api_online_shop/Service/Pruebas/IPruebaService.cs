using CB.Entidades;

namespace api_online_shop.Service.Pruebas
{
    public interface IPruebaService
    {
        Task<IList<testModel>> get();
    }
}
