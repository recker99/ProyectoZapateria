using System;
using System.Linq;
using System.Web.Security;
using System.Web.UI;
using ZapateriaDAL;

namespace ProyectoZapateria
{
    public partial class Manage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var db = new zapateriaEntities())
                {
                    // Obtener el usuario actual desde la autenticación
                    string nombreUsuario = User.Identity.Name;

                    var usuario = db.usuarios.SingleOrDefault(u => u.nombre_usuario == nombreUsuario);

                    if (usuario != null)
                    {
                        txtUsuario.Text = usuario.usuario;
                        txtNombreUsuario.Text = usuario.nombre_usuario;
                    }
                    else
                    {
                        lblMensaje.Text = "Error al cargar los datos del usuario.";
                    }
                }
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            using (var db = new zapateriaEntities())
            {
                string nombreUsuario = User.Identity.Name;

                var usuario = db.usuarios.SingleOrDefault(u => u.nombre_usuario == nombreUsuario);

                if (usuario != null)
                {
                    usuario.nombre_usuario = txtNombreUsuario.Text;

                    // Solo actualizar la contraseña si se ha proporcionado una nueva
                    if (!string.IsNullOrEmpty(txtContrasena.Text))
                    {
                        usuario.contrasena = txtContrasena.Text; // Asegúrate de cifrar la contraseña antes de guardarla
                    }

                    db.SaveChanges();
                    lblMensaje.Text = "Perfil actualizado correctamente.";
                }
                else
                {
                    lblMensaje.Text = "Error al actualizar los datos del usuario.";
                }
            }
        }
    }
}
