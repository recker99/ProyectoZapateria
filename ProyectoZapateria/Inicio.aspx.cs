using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZapateriaDAL;

namespace ProyectoZapateria
{
    public partial class Inicio : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              /*  if (User.Identity.IsAuthenticated)
                {
                    lblWelcome.Text = $"Hola, {User.Identity.Name}! Bienvenido a nuestra zapatería.";
                }
                else
                {
                    lblWelcome.Text = "¡Bienvenido a nuestra zapatería! Inicia sesión para ver más opciones.";
                }
              */
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            using (var db = new zapateriaEntities()) 
            {
                var productos = db.productos.ToList();
                gvProductos.DataSource = productos;
                gvProductos.DataBind();
            }
        }
    }

}