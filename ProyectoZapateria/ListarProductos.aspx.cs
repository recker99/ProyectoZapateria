using System;
using System.Web.UI.WebControls;
using ZapateriaDAL;

namespace ProyectoZapateria
{
    public partial class ListarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            ProductosBF productosBF = new ProductosBF();
            GridView1.DataSource = productosBF.ReadAllBF();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Obtén el ID del producto en la fila que estás editando
            int idProducto = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex].Value);
            // Redirige a la página de actualización pasando el ID del producto
            Response.Redirect($"ActualizarProducto.aspx?id={idProducto}");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // Obtén el ID del producto en la fila que estás eliminando
            int idProducto = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            // Redirige a la página de eliminación pasando el ID del producto
            Response.Redirect($"EliminarProducto.aspx?id={idProducto}");
        }
    }
}
