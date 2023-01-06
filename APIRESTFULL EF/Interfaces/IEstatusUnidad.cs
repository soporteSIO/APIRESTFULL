using APIRESTFULL_EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIRESTFULL_EF.Interfaces
{
    public interface IEstatusUnidad
    {
        Task<List<EstatusUnidad>> listaEstatus();
    }
}
