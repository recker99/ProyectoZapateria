using System;
using System.Web.UI.WebControls;
using ZapateriaDAL;

namespace ProyectoZapateria
{
    public partial class Productos : System.Web.UI.Page
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

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int idProducto = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

            string nombreProducto = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtNomProd")).Text.Trim();
            string descripcion = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtDes")).Text.Trim();
            int precio = Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPrecio")).Text.Trim());

            // Falta Obtener el nombre del usuario actual para la última modificación
            string ultimaModificacion = User.Identity.Name; 

            // Actualiza el producto 
            ProductosBF productosBF = new ProductosBF();
            bool actualizado = productosBF.EditarBF(idProducto, nombreProducto, descripcion, precio, ultimaModificacion);

            if (actualizado)
            {
                GridView1.EditIndex = -1; 
                CargarProductos(); 
            }
            else
            {
                // mensaje al usuario
                LblError.Text = "No se pudo actualizar el producto.";
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int idProducto = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex].Value);
            Response.Redirect($"ActualizarProducto.aspx?id={idProducto}");
        }


        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            CargarProductos();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int idProducto = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            Response.Redirect($"EliminarProducto.aspx?id={idProducto}");
        }

    }
}
