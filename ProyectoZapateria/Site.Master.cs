using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZapateriaDAL;

namespace ProyectoZapateria
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Verifica si el usuario está autenticado utilizando HttpContext
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                // Si el usuario está autenticado, mostrar los enlaces correspondientes  
                productosItem.Visible = true;  
                usuariosItem.Visible = true;     
                contactoItem.Visible = true;      
            }
            else
            {
                // Si el usuario no está autenticado, ocultar algunos enlaces  
                productosItem.Visible = false;   
                usuariosItem.Visible = false;     
                contactoItem.Visible = true;       
            }
        }
    }
}