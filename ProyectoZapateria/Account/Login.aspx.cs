using System;
using System.Linq;
using System.Web.Security;
using System.Web.UI;
using ZapateriaDAL;

namespace ProyectoZapateria
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new zapateriaEntities())
            {
                var usuario = db.usuarios.SingleOrDefault(u => u.usuario == txtUsuario.Text && u.contrasena == txtContrasena.Text);

                if (usuario != null)
                {
                    FormsAuthentication.SetAuthCookie(usuario.nombre_usuario, false);
                    Response.Redirect("~/Inicio.aspx");
                }
                else
                {
                    lblMensaje.Text = "Usuario o contraseña incorrectos.";
                }
            }
        }
    }
}
