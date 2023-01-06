using APIRESTFULL_EF.Context;
using APIRESTFULL_EF.Interfaces;
using APIRESTFULL_EF.Models;
using APIRESTFULL_EF.Logs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using APIRESTFULL_EF.Services;

namespace APIRESTFULL_EF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        IUsuario UsuarioService;

        //private DefMtyContext _dbcontext;

        private readonly ILogger<UsuarioController> _logger;
        public UsuarioController(IUsuario usuario, ILogger<UsuarioController> logger, ILoggerFactory loggerFactory)
        {
            UsuarioService = usuario;
            _logger = logger;
            loggerFactory.AddFile("Log-{Date}.txt");
            //_dbcontext = dbcontext;


        }
        [HttpGet]
        public async Task<ActionResult<Usuario>> GetAll()
        {

            try
            {
                List<Usuario> lista = await UsuarioService.UsuarioList();
                if (lista != null)
                {
                    _logger.LogInformation(MyLogEvents.GetItem, "Obteniendo Lista de usuarios");
                    return Ok(lista);

                }
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "Ups", e.Message });
                _logger.LogCritical(MyLogEvents.GetItem, "Error al cargar lista de usuarios");
            }
            return NotFound();
        }


        [HttpPost]
        public ActionResult<Usuario> Login([FromBody]Usuario usuario)
        {

            string user = usuario.U_Usuario;
            string pass = usuario.U_Contrasena;
         
            if (user =="" && pass =="")
            {
                _logger.LogWarning(MyLogEvents.GetItem, "Usuario:{user} Intento de sesion fallida ", user);
                return StatusCode(StatusCodes.Status401Unauthorized, new { mensaje = "Usuario o contraseña incorrecto" });
            }
            else
            {
                 bool Login = UsuarioService.Login(usuario.U_Usuario, usuario.U_Contrasena);
                if (Login)
                {

                    _logger.LogInformation(MyLogEvents.GetItem, "Usuario : {user} Inicio de sesion ", user);
                    return Ok("Usuario correcto");

                }
                else
                {

                    _logger.LogWarning(MyLogEvents.GetItem, "Usuario:{user} Intento de sesion fallida ", user);
                    return StatusCode(StatusCodes.Status401Unauthorized, new { mensaje = "Usuario o contraseña incorrecto" });

                }
            }
           

            
           
        }
    }
}
