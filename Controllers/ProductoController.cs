using CRUDmvc.Models;
using CRUDmvc.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDmvc.Controllers
{
    public class ProductoController : Controller
    {
        // GET: ProductoController
        public IActionResult Index()
        {
            return View(Util.Utils.ListaProductos);
        }

        // GET: ProductoController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductoController/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            Console.WriteLine(producto.Nombre);
            int id = Utils.ListaProductos.Count() + 1;
            Utils.ListaProductos.Add(producto);
            return RedirectToAction("Index");
        }


        // GET: ProductoController/Edit/5
        public IActionResult Edit(int IdProducto)
        {
            Producto producto = Utils.ListaProductos.Find(x => x.IdProducto == IdProducto);
            if (producto != null)
            {
                return View(producto);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Producto producto)
        {
            Producto producto2 = Utils.ListaProductos.Find(x => x.IdProducto == producto.IdProducto);
            if (producto != null)
            {
                producto2.Nombre = producto.Nombre;
                producto2.Descripcion = producto.Descripcion;
                producto2.Cantidad = producto.Cantidad;
                return RedirectToAction("Index");
                
            }
            return View();
        }



        // GET: ProductoController/Delete/5
        public IActionResult Delete(int IdProducto)
        {
            Producto producto = Utils.ListaProductos.Find(x => x.IdProducto==IdProducto);
            if (producto != null)
            {
                Utils.ListaProductos.Remove(producto);
            }
            return RedirectToAction("Index");
        }

      
    }
}
