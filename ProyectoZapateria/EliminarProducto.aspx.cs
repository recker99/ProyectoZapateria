using System;
using System.Web.UI;
using ZapateriaDAL;

namespace ProyectoZapateria
{
    public partial class EliminarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int idProducto;
                if (!int.TryParse(Request.QueryString["id"], out idProducto))
                {
                    LblError.Text = "ID de producto no válido.";
                    
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int idProducto;
            if (int.TryParse(Request.QueryString["id"], out idProducto))
            {
                ProductosBF productosBF = new ProductosBF();
                bool eliminado = productosBF.EliminarBF(idProducto);

                if (eliminado)
                {
                    Response.Redirect("Productos.aspx?mensaje=Producto eliminado con éxito.");
                }
                else
                {
                    LblError.Text = "No se pudo eliminar el producto.";
                }
            }
            else
            {
                LblError.Text = "ID de producto no válido.";
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Productos.aspx?mensaje=Eliminación cancelada.");
        }
    }
}
