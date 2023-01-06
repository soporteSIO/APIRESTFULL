using APIRESTFULL_EF.Interfaces;
using APIRESTFULL_EF.Logs;
using APIRESTFULL_EF.Models;
using APIRESTFULL_EF.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIRESTFULL_EF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperadorController : Controller
    {
        IOperador OperadorService;

        //private DefMtyContext _dbcontext;

        private readonly ILogger<OperadorController> _logger;
        public OperadorController(IOperador operador, ILogger<OperadorController> logger, ILoggerFactory loggerFactory)
        {
            OperadorService = operador;
            _logger = logger;
            loggerFactory.AddFile("Log-{Date}.txt");
            //_dbcontext = dbcontext;


        }
        [HttpGet]
        public async Task<ActionResult<Operador>> GetAll()
        {

            try
            {
                List<Operador> lista = await OperadorService.OperadoresList();
                if (lista != null)
                {
                    _logger.LogInformation(MyLogEvents.GetItem, "Obteniendo Lista de operadores");
                    return Ok(lista);

                }
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "Ups", e.Message });
                _logger.LogCritical(MyLogEvents.GetItem, "Error al cargar lista de operadores");
            }
            return NotFound();
        }




    }
}
