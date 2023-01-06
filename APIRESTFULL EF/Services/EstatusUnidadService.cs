using APIRESTFULL_EF.Context;
using APIRESTFULL_EF.Interfaces;
using APIRESTFULL_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace APIRESTFULL_EF.Services
{
    public class EstatusUnidadService:IEstatusUnidad
    {
        private readonly DefMtyContext _dbcontext;

        public EstatusUnidadService(DefMtyContext dbcontext)
        {
            _dbcontext = dbcontext;
        }



        public async Task<List<EstatusUnidad>> listaEstatus()
        {
            List<EstatusUnidad> list = await _dbcontext.EstatusUnidad.ToListAsync();
            return list;


        }
    }
}
