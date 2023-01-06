using APIRESTFULL_EF.Context;
using APIRESTFULL_EF.Interfaces;
using APIRESTFULL_EF.Models;
using APIRESTFULL_EF.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIRESTFULL_EF.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class EstatusUnidadController : Controller
    {
        IEstatusUnidad EstatusUnidadService;

        private DefMtyContext _dbcontext;
        public EstatusUnidadController(IEstatusUnidad estatus, DefMtyContext dbcontext)
        {
            EstatusUnidadService = estatus;
            _dbcontext = dbcontext;
        }

        [HttpGet]
        public async Task<ActionResult<EstatusUnidad>> getAll()
        {
            try
            {
                List<EstatusUnidad> lista =  await EstatusUnidadService.listaEstatus();
                if (lista != null)
                {
                    return Ok(lista);
                }

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "Ups", e.Message });
            }
            return NotFound();

        }
    }
}
