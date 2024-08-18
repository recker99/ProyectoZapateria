using System;
using System.Linq;
using System.Web.UI.WebControls;
using ZapateriaDAL;

namespace ProyectoZapateria
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarUsuarios();
            }
        }

        private void CargarUsuarios()
        {
            using (var db = new zapateriaEntities())
            {
                var usuarios = db.usuarios.ToList();
                GridView1.DataSource = usuarios;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView1.Rows[index];
            string usuario = GridView1.DataKeys[index].Value.ToString();

            switch (e.CommandName)
            {
                case "Editar":
                    // falta crear la pagina EditarUsuario
                    Response.Redirect($"EditarUsuario.aspx?usuario={usuario}");
                    break;
                case "Eliminar":
                    EliminarUsuario(usuario);
                    CargarUsuarios(); 
                    break;
                default:
                    break;
            }
        }

        private void EliminarUsuario(string usuario)
        {
            using (var db = new zapateriaEntities())
            {
                var usuarioAEliminar = db.usuarios.FirstOrDefault(u => u.usuario == usuario);
                if (usuarioAEliminar != null)
                {
                    db.usuarios.Remove(usuarioAEliminar);
                    db.SaveChanges();
                }
            }
        }
    }
}
