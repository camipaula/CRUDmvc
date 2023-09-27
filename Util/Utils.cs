using CRUDmvc.Models;
namespace CRUDmvc.Util

{
    public class Utils
    {
        public static List<Producto> ListaProductos = new List<Producto>()
        {
            new Producto()
            {
                IdProducto = 1,
                Nombre = "Producto1",
                Descripcion="Descripcion 1",
                Cantidad = 1
            },

            new Producto()
            {
                IdProducto = 2,
                Nombre = "Producto2",
                Descripcion="Descripcion 2",
                Cantidad = 1
            },
            new Producto()
            {
                IdProducto = 3,
                Nombre = "Producto3",
                Descripcion="Descripcion 3",
                Cantidad = 1
            },




        };
    }
}
