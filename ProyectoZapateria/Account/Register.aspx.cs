using System;
using System.Web.UI;
using ZapateriaDAL;

namespace ProyectoZapateria
{
    public partial class Registro : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (var db = new zapateriaEntities())
            {
                var nuevoUsuario = new usuarios
                {
                    usuario = txtUsuario.Text,
                    contrasena = txtContrasena.Text, // Falta cifrar la contraseña antes de guardarla
                    nombre_usuario = txtNombreUsuario.Text
                };

                db.usuarios.Add(nuevoUsuario);
                db.SaveChanges();

                lblMensaje.Text = "Usuario registrado exitosamente.";
            }
        }
    }
}
