
using Microsoft.AspNetCore.Mvc;
using APIRESTFULL_EF.Services;
using APIRESTFULL_EF.Interfaces;
using APIRESTFULL_EF.Context;
using APIRESTFULL_EF.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.Design;
using APIRESTFULL_EF.Logs;

namespace APIRESTFULL_EF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class UnidadController : Controller
    {
        IUnidad UnidadService;
        private readonly ILogger<UsuarioController> _logger;

        //private DefMtyContext _dbcontext;
        public UnidadController(IUnidad unidad, ILogger<UsuarioController> logger, ILoggerFactory loggerFactory)
        {
            UnidadService = unidad;
            _logger = logger;
            loggerFactory.AddFile("Log-{Date}.txt");
            //    _dbcontext = dbcontext;
        }

        [HttpGet]
        public async Task<ActionResult<Unidad>> GetAll()
        {

            try
            {
                List<Unidad> lista = await UnidadService.UnidadesList();
                if (lista != null)
                {
                    _logger.LogInformation(MyLogEvents.GetItem, "Obteniendo Lista de Undiades");
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



        [HttpGet("{id}")]
        public async Task<ActionResult<Unidad>> Get(int id)
        {
          Unidad unidad =await UnidadService.Unidad(id);

            if (unidad !=null)
            {
                _logger.LogInformation(MyLogEvents.GetItem, "Obteniendo datos de la Unidada {id}",id);
                return Ok(unidad);
            }
            return NotFound();

        }




        [HttpPost]
        public async Task<ActionResult> Update([FromBody] Unidad unidad)
        {
            
            Unidad responseUnidad = await UnidadService.ActualizarUnidad(unidad.Idunidad, unidad.IdEstatus, unidad.FechaIngresoTaller, unidad.FechaSalidaTaller);

            int id = unidad.NumeroEconomico;
            string fechaT = unidad.FechaIngresoTaller;
            string fechaST = unidad.FechaSalidaTaller;


            if (responseUnidad == null)
            {
                return NotFound();
            }
            else
            {
                _logger.LogInformation(MyLogEvents.GetItem, "Unidad Actualizada, Numero Economico {id}  FechaIngresoTaller: {fechaT} FechaSalidadTaller: {fechaST}", id, fechaT, fechaST);
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Estatus Actualizado", responseUnidad.NumeroEconomico });
            }



        }



        //[HttpDelete("{index}")]
        //public async Task<ActionResult<Unidad>> Delete(int index)
        //{
        //    Unidad responseUnidad = await UnidadService.EliminarUnidad(index);

        //    if (responseUnidad==null)
        //    {
        //        return NotFound();
        //    }
        //    return StatusCode(StatusCodes.Status200OK, new { mensaje = "Unidad eliminada", responseUnidad.NumeroEconomico });
        //}

    }
}
