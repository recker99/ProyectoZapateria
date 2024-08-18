using System.Collections.Generic;
using System.Linq;
using ZapateriaDAL;

public class ProductosBF
{
    public bool CrearBF(string nombre, string descripcion, int precio, string ultima_modificacion)
    {
        using (var db = new zapateriaEntities())
        {
            var producto = new productos
            {
                nombre_producto = nombre,
                descripcion = descripcion,
                precio = precio,
                ultima_modificacion = ultima_modificacion
            };
            db.productos.Add(producto);
            db.SaveChanges();
            return true;
        }
    }

    public bool EditarBF(int id, string nombre, string descripcion, int precio, string ultima_modificacion)
    {
        using (var db = new zapateriaEntities())
        {
            var producto = db.productos.Find(id);
            if (producto != null)
            {
                producto.nombre_producto = nombre;
                producto.descripcion = descripcion;
                producto.precio = precio;
                producto.ultima_modificacion = ultima_modificacion;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }

    public bool EliminarBF(int id)
    {
        using (var db = new zapateriaEntities())
        {
            var producto = db.productos.Find(id);
            if (producto != null)
            {
                db.productos.Remove(producto);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }

    public List<productos> ReadAllBF()
    {
        using (var db = new zapateriaEntities())
        {
            return db.productos.ToList();
        }
    }

    public productos ObtenerProductoPorId(int idProducto)
    {
        using (var db = new zapateriaEntities())
        {
            return db.productos.Find(idProducto);
        }
    }
}
