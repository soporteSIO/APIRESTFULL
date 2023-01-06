using APIRESTFULL_EF.Models;

namespace APIRESTFULL_EF.Interfaces
{
    public interface IRecepcionUnidad
    {
        Task<List<RecepcionUnidad>> recepcionLista();
        Task<RecepcionUnidad> InsertarRegistro(RecepcionUnidad recepcionunidad);
    }
}
