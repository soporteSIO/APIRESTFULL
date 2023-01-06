using APIRESTFULL_EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIRESTFULL_EF.Interfaces
{
    public interface IUnidad
    {
        Task<List<Unidad>> UnidadesList();

       
        Task<Unidad> Unidad(int id);

        Task<Unidad> ActualizarUnidad(int index, int estatus, string fechaT, string fechaST);

        //Task<Unidad> EliminarUnidad(int index);

    }
}
