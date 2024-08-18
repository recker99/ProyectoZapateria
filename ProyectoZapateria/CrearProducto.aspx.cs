using System;
using ZapateriaDAL;

namespace ProyectoZapateria
{
    public partial class CrearProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // No es necesario cargar datos en el Page_Load para esta página
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string nombre = txtNomProd.Text.Trim();
                string descripcion = txtDes.Text.Trim();
                int precio;
                if (int.TryParse(txtPrecio.Text.Trim(), out precio))
                {
                    string ultimaModificacion = User.Identity.Name; // Obtener el nombre del usuario actual
                    
                    ProductosBF productosBF = new ProductosBF();
                    bool creado = productosBF.CrearBF(nombre, descripcion, precio, ultimaModificacion);

                    if (creado)
                    {
                        Response.Redirect("Productos.aspx?mensaje=Producto creado con éxito.");
                    }
                    else
                    {
                        LblError.Text = "No se pudo crear el producto.";
                    }
                }
                else
                {
                    LblError.Text = "El precio ingresado no es válido.";
                }
            }
        }
    }
}
