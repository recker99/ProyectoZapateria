using System;
using System.Data;
using System.Linq;

namespace ZapateriaDAL
{
    public class ProductosDAL
    {
        public DataSet BuscarProductos(int id)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Nombre_producto", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Precio", typeof(int)); // Cambiado a int
            dt.Columns.Add("Ultima_Actualizacion", typeof(string));

            using (var context = new zapateriaEntities())
            {
                var productos = (from p in context.productos
                                 where p.id == id
                                 select p).ToList();

                foreach (var producto in productos)
                {
                    DataRow row = dt.NewRow();
                    row["id"] = producto.id;
                    row["Nombre_producto"] = producto.nombre_producto;
                    row["Descripcion"] = producto.descripcion;
                    row["Precio"] = producto.precio;
                    row["Ultima_Actualizacion"] = producto.ultima_modificacion;
                    dt.Rows.Add(row);
                }
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        public DataSet ReadAllProductos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("nombre_producto", typeof(string));
            dt.Columns.Add("descripcion", typeof(string));
            dt.Columns.Add("precio", typeof(int)); // Cambiado a int
            dt.Columns.Add("ultima_modificacion", typeof(string));

            using (var context = new zapateriaEntities())
            {
                var productos = (from p in context.productos select p).ToList();

                foreach (var producto in productos)
                {
                    DataRow row = dt.NewRow();
                    row["id"] = producto.id;
                    row["nombre_producto"] = producto.nombre_producto;
                    row["descripcion"] = producto.descripcion;
                    row["precio"] = producto.precio;
                    row["ultima_modificacion"] = producto.ultima_modificacion;
                    dt.Rows.Add(row);
                }
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        public bool Crear(string nombre_producto, string descripcion, int precio, string ultima_modificacion)
        {
            try
            {
                using (var context = new zapateriaEntities())
                {
                    var producto = new productos
                    {
                        nombre_producto = nombre_producto,
                        descripcion = descripcion,
                        precio = precio,
                        ultima_modificacion = ultima_modificacion
                    };

                    context.productos.Add(producto);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear el producto: " + ex.Message);
                return false;
            }
        }

        public bool Editar(int id, string nombre_producto, string descripcion, int precio, string ultima_modificacion)
        {
            try
            {
                using (var context = new zapateriaEntities())
                {
                    var producto = context.productos.SingleOrDefault(p => p.id == id);

                    if (producto == null)
                    {
                        return false; // Producto no encontrado
                    }

                    producto.nombre_producto = nombre_producto;
                    producto.descripcion = descripcion;
                    producto.precio = precio;
                    producto.ultima_modificacion = ultima_modificacion;

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar el producto: " + ex.Message);
                return false;
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                using (var context = new zapateriaEntities())
                {
                    var producto = context.productos.SingleOrDefault(p => p.id == id);
                    if (producto == null) return false;

                    context.productos.Remove(producto);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el producto: " + ex.Message);
                return false;
            }
        }

        public DataSet BuscarProducto(int id)
        {
            // Crear un DataTable para almacenar los resultados
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("nombre_producto", typeof(string));
            dt.Columns.Add("descripcion", typeof(string));
            dt.Columns.Add("precio", typeof(int));
            dt.Columns.Add("ultima_modificacion", typeof(string));

            // Crear una instancia del contexto de Entity Framework
            using (var context = new zapateriaEntities())
            {
                // Consultar el producto por id
                var producto = (from p in context.productos
                                where p.id == id
                                select p).FirstOrDefault();

                // Si se encuentra el producto, agregarlo al DataTable
                if (producto != null)
                {
                    DataRow row = dt.NewRow();
                    row["id"] = producto.id;
                    row["nombre_producto"] = producto.nombre_producto;
                    row["descripcion"] = producto.descripcion;
                    row["precio"] = producto.precio;
                    row["ultima_modificacion"] = producto.ultima_modificacion;
                    dt.Rows.Add(row);
                }
            }

            // Crear un DataSet y agregar el DataTable
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

    }
}
