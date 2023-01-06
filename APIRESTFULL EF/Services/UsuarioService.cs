using APIRESTFULL_EF.Context;
using APIRESTFULL_EF.Interfaces;
using APIRESTFULL_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace APIRESTFULL_EF.Services
{
    public class UsuarioService:IUsuario
    {
        private readonly DefMtyContext _dbcontext;

        public UsuarioService(DefMtyContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public bool Login(string user, string pass)
        {
            var res = from usuario in _dbcontext.Usuarios
                      where usuario.U_Usuario == user && usuario.U_Contrasena == pass
                      select usuario;
            if (res.Any())
            {
                return true;
            }
            return false;

        }

        public async Task<List<Usuario>> UsuarioList()
        {

            var res = from u in _dbcontext.Usuarios
                      where u.U_IdEstatusEmpleado == 1
                      select new Usuario
                      {
                          U_Usuario = u.U_Usuario,
                          U_IdDepartamento = u.U_IdDepartamento,
                          NombreCompleto = u.NombreCompleto,
                      };
            List<Usuario> usuarios = new List<Usuario>(res);
            return usuarios;

        }
    }
}
