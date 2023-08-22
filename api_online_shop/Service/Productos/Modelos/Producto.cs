namespace api_online_shop.Service.Productos.Modelos
{
    public class Producto
    {
        public int productoId { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string precioVenta { get; set; }
    }
}
