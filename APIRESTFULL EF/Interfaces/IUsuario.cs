using APIRESTFULL_EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIRESTFULL_EF.Interfaces
{
    public interface IUsuario
    {
        bool Login(string username, string password);

        Task<List<Usuario>> UsuarioList();
    }
}
