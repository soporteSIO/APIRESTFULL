using APIRESTFULL_EF.Context;
using APIRESTFULL_EF.Interfaces;
using APIRESTFULL_EF.Logs;
using APIRESTFULL_EF.Models;
using APIRESTFULL_EF.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIRESTFULL_EF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecepcionUnidadController : Controller
    {
        IRecepcionUnidad RecepcionUnidadService;
        private readonly ILogger<RecepcionUnidadController> _logger;
        private DefMtyContext _dbcontext;
        public RecepcionUnidadController(IRecepcionUnidad unidad, ILogger<RecepcionUnidadController> logger, ILoggerFactory loggerFactory)
        {
            RecepcionUnidadService = unidad;
            _logger = logger;
            loggerFactory.AddFile("Log-{Date}.txt");
            //_dbcontext = dbcontext;
        }

        [HttpGet]
        public async Task<ActionResult<RecepcionUnidad>> GetAll()
        {

            try
            {
                List<RecepcionUnidad> lista = await RecepcionUnidadService.recepcionLista();
                if (lista != null)
                {
                    _logger.LogInformation(MyLogEvents.GetItem, "Obteniendo Lista de Unidades");
                    return Ok(lista);

                }

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "Ups", e.Message });
                _logger.LogCritical(MyLogEvents.GetItem, "Error al cargar lista de unidades");
            }
            return NotFound();

        }



        [HttpPost]
        public async Task<ActionResult> Update([FromBody] RecepcionUnidad unidad)
        {

            RecepcionUnidad responseUnidad = await RecepcionUnidadService.InsertarRegistro(unidad);


            if (responseUnidad == null)
            {
                return NotFound();
            }
            else
            {
                _logger.LogInformation(MyLogEvents.GetItem, "Inserto nuevo registro el usuario: "+responseUnidad.Mecanico +"unidad registrada: "+responseUnidad.Unidad);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Registro insertado", });
            }
        }
    }
}
