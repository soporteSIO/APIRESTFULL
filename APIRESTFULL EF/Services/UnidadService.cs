    using APIRESTFULL_EF.Context;
using APIRESTFULL_EF.Interfaces;
using APIRESTFULL_EF.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;

namespace APIRESTFULL_EF.Services
{
    public class UnidadService: IUnidad
    {

        private readonly DefMtyContext _dbcontext;
        
        public UnidadService(DefMtyContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<Unidad>> UnidadesList()
        {



            List<Unidad> unidades = await _dbcontext.Unidades.Where(x=>x.IdEstatus!=3 && x.Id_CategoriaUnidad!=0).ToListAsync();
            return unidades;

        }

        public async Task<Unidad> Unidad(int id)
        {
            Unidad unidad = await _dbcontext.Unidades.FindAsync(id);

            if (unidad != null)
            {
                return unidad;
            }
            return unidad;
        }


        public async Task<Unidad> ActualizarUnidad(int index, [FromBody] int estatus, string fechaT, string FechaST)
        {
            Unidad unidad = await _dbcontext.Unidades.FindAsync(index);
            if (unidad != null)
            {
                string unidadEstatus;
                if (unidad.IdEstatus==1)
                {
                    unidadEstatus = "TALLER";
                }
                else
                {
                    unidadEstatus = "ACTIVO";
                }


                unidad.IdEstatus = estatus;
                unidad.Estatus = unidadEstatus;
                unidad.FechaIngresoTaller = fechaT;
                unidad.FechaSalidaTaller = FechaST;
                _dbcontext.SaveChanges();
                return unidad;
            }
            return unidad;
        }




        public async Task<Unidad> EliminarUnidad(int index)
        {
            Unidad unidad = await _dbcontext.Unidades.FindAsync(index);

            if (unidad != null)
            {
                _dbcontext.Unidades.Remove(unidad);
                _dbcontext.SaveChanges();
                return unidad;
            }
            return unidad;

        }

    }
}
