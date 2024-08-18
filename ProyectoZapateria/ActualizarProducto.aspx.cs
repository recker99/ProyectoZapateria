using System;
using ZapateriaDAL;

namespace Multitienda.Web.Pages
{
    public partial class ActualizarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int idProducto;
                if (int.TryParse(Request.QueryString["id"], out idProducto))
                {
                    CargarProducto(idProducto);
                }
                else
                {
                    LblError.Text = "ID de producto no válido.";
                    pnlForm.Visible = false;
                }
            }
        }

        protected void CargarProducto(int idProducto)
        {
            try
            {
                ProductosBF productosBF = new ProductosBF();
                var producto = productosBF.ObtenerProductoPorId(idProducto);

                if (producto != null)
                {
                    txtNomProd.Text = producto.nombre_producto;
                    txtDes.Text = producto.descripcion;
                    txtPrecio.Text = producto.precio.ToString();
                    txtUltMod.Text = producto.ultima_modificacion;
                }
                else
                {
                    LblError.Text = "Producto no encontrado.";
                    pnlForm.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones y de errores
                LblError.Text = "Se produjo un error al cargar el producto.";
               
                Console.WriteLine(ex.Message); 
                pnlForm.Visible = false;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int idProducto;
                if (int.TryParse(Request.QueryString["id"], out idProducto))
                {
                    string nombre = txtNomProd.Text.Trim();
                    string descripcion = txtDes.Text.Trim();
                    int precio;
                    if (int.TryParse(txtPrecio.Text.Trim(), out precio))
                    {
                        try
                        {
                            string ultimaModificacion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            ProductosBF productosBF = new ProductosBF();
                            bool actualizado = productosBF.EditarBF(idProducto, nombre, descripcion, precio, ultimaModificacion);

                            if (actualizado)
                            {
                                Response.Redirect("Productos.aspx?mensaje=Producto actualizado con éxito.");
                            }
                            else
                            {
                                LblError.Text = "No se pudo actualizar el producto.";
                            }
                        }
                        catch (Exception ex)
                        {
                            LblError.Text = "Se produjo un error al actualizar el producto.";                        
                            Console.WriteLine(ex.Message);                         }
                    }
                    else
                    {
                        LblError.Text = "El precio ingresado no es válido.";
                    }
                }
                else
                {
                    LblError.Text = "ID de producto no válido.";
                }
            }
        }
    }
}
