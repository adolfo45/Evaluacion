using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Datos.Domains
{
    public class UsuarioDomain
    {

        #region * Constructor *
        public UsuarioDomain(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        #endregion

        #region * Variables *
        private readonly ApplicationDbContext _context;
        #endregion

        #region * Métodos *
        public Usuarios Agregar(Usuarios model)
        {
            _context.Usuarios.Add(model);

            _context.SaveChanges();

            return model;
        }//public Usuarios Agregar(Usuarios model)
        public Usuarios Editar(Usuarios model)
        {
            var usuarioEditar = _context.Usuarios.FirstOrDefault(u => u.UsuarioId == model.UsuarioId);

            usuarioEditar.Usuario = model.Usuario;
            usuarioEditar.Contrasena = model.Contrasena;
            usuarioEditar.Sexo = model.Sexo;
            usuarioEditar.CorreoElectronico = model.CorreoElectronico;

            _context.SaveChanges();

            return usuarioEditar;
        }//public Usuarios Editar(Usuarios model)
        public Usuarios ObtenerUsuario(string nombreUsuario, string contrasena)
        {
            var usuario = _context.Usuarios
                .Where(u => u.Usuario == nombreUsuario &&
                            u.Contrasena == contrasena).FirstOrDefault();

            return usuario;
        }//public Usuarios ObtenerUsuario(string nombreUsuario, string contrasena)
        public IEnumerable<Usuarios> ObtenerUsuarios()
        {
            var usuarios = _context.Usuarios;

            return usuarios;
        }//public IEnumerable<Usuarios> ObtenerUsuarios()
        #endregion

    }//public class UsuarioDomain
}//namespace Datos.Domains
