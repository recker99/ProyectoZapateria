using System;
using System.Data;
using System.Linq;
using ZapateriaDAL;

public class UsuariosDAL
{
    public DataSet LoginUsuario(string usuario, string contrasena)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("id", typeof(int));
        dt.Columns.Add("usuario", typeof(string));
        dt.Columns.Add("nombre_usuario", typeof(string));

        using (var context = new zapateriaEntities())
        {
            var usuarioEncontrado = (from u in context.usuarios
                                     where u.usuario == usuario && u.contrasena == contrasena
                                     select u).ToList();

            foreach (var user in usuarioEncontrado)
            {
                DataRow row = dt.NewRow();
                row["id"] = user.id;
                row["usuario"] = user.usuario;
                row["nombre_usuario"] = user.nombre_usuario;
                dt.Rows.Add(row);
            }
        }

        DataSet ds = new DataSet();
        ds.Tables.Add(dt);
        return ds;
    }

    public DataSet ReadAllUsuarios()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("id", typeof(int));
        dt.Columns.Add("usuario", typeof(string));
        dt.Columns.Add("nombre_usuario", typeof(string));

        using (var context = new zapateriaEntities())
        {
            var usuarios = (from u in context.usuarios select u).ToList();

            foreach (var user in usuarios)
            {
                DataRow row = dt.NewRow();
                row["id"] = user.id;
                row["usuario"] = user.usuario;
                row["nombre_usuario"] = user.nombre_usuario;
                dt.Rows.Add(row);
            }
        }

        DataSet ds = new DataSet();
        ds.Tables.Add(dt);
        return ds;
    }

    public bool Crear(string usuario, string contrasena, string nombre_usuario)
    {
        try
        {
            using (var context = new zapateriaEntities())
            {
                var nuevoUsuario = new usuarios
                {
                    usuario = usuario,
                    contrasena = contrasena,
                    nombre_usuario = nombre_usuario
                };

                context.usuarios.Add(nuevoUsuario);
                context.SaveChanges();
                return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al crear el usuario: " + ex.Message);
            return false;
        }
    }

    public bool Editar(string usuario, string contrasena, string nombre_usuario)
    {
        try
        {
            using (var context = new zapateriaEntities())
            {
                var usuarioExistente = context.usuarios.SingleOrDefault(u => u.usuario == usuario);

                if (usuarioExistente == null)
                {
                    return false; // Usuario no encontrado
                }

                usuarioExistente.contrasena = contrasena;
                usuarioExistente.nombre_usuario = nombre_usuario;

                context.SaveChanges();
                return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al editar el usuario: " + ex.Message);
            return false;
        }
    }

    public bool Eliminar(string usuario)
    {
        try
        {
            using (var context = new zapateriaEntities())
            {
                var usuarioExistente = context.usuarios.SingleOrDefault(u => u.usuario == usuario);

                if (usuarioExistente == null)
                {
                    return false; // Usuario no encontrado
                }

                context.usuarios.Remove(usuarioExistente);
                context.SaveChanges();
                return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al eliminar el usuario: " + ex.Message);
            return false;
        }
    }
}
