using System.Data;

public class UsuariosBF
{
    public DataSet LoginUsuarioBF(string usuario, string contrasena)
    {
        UsuariosDAL capaDatos = new UsuariosDAL();
        return capaDatos.LoginUsuario(usuario, contrasena);
    }

    public DataSet ReadAllUsuariosBF()
    {
        UsuariosDAL capaDatos = new UsuariosDAL();
        return capaDatos.ReadAllUsuarios();
    }

    public bool CrearBF(string usuario, string contrasena, string nombre_usuario)
    {
        UsuariosDAL capaDatos = new UsuariosDAL();
        return capaDatos.Crear(usuario, contrasena, nombre_usuario);
    }

    public bool EditarBF(string usuario, string contrasena, string nombre_usuario)
    {
        UsuariosDAL capaDatos = new UsuariosDAL();
        return capaDatos.Editar(usuario, contrasena, nombre_usuario);
    }

    public bool EliminarBF(string usuario)
    {
        UsuariosDAL capaDatos = new UsuariosDAL();
        return capaDatos.Eliminar(usuario);
    }
}
