using APIRESTFULL_EF.Context;
using APIRESTFULL_EF.Interfaces;
using APIRESTFULL_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace APIRESTFULL_EF.Services
{
    public class RecepcionUnidadService : IRecepcionUnidad
    {
        private readonly DefMtyContext _dbcontext;

        public RecepcionUnidadService(DefMtyContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<RecepcionUnidad> InsertarRegistro(RecepcionUnidad recepcionunidad)
        {

            RecepcionUnidad nuevoregistro = new RecepcionUnidad()
            {
               
                NAguaRadiador = recepcionunidad.NAguaRadiador,
                NAceiteMotor = recepcionunidad.NAceiteMotor,
                NAceiteHID = recepcionunidad.NAceiteHID,
                SELuzDeFreno = recepcionunidad.SELuzDeFreno,
                SETorreta = recepcionunidad.SETorreta,
                SELuzDeReversa = recepcionunidad.SELuzDeReversa,
                SEFarosDelanteros = recepcionunidad.SEFarosDelanteros,
                SEDireccionales = recepcionunidad.SEDireccionales,
                SEIntermitentes = recepcionunidad.SEIntermitentes,
                ISinFugasFiltro = recepcionunidad.ISinFugasFiltro,
                IFiltroAireLimpio = recepcionunidad.ITapaFiltroAire,
                IFiltroDieselSinFugas = recepcionunidad.IFiltroDieselSinFugas,
                ITaponRadiador = recepcionunidad.ITaponRadiador,
                ITapaFiltroAire = recepcionunidad.ITapaFiltroAire,
                IBayonetaAceite = recepcionunidad.IBayonetaAceite,
                ITuboAceite = recepcionunidad.ITuboAceite,
                ISinFugasCarter = recepcionunidad.ISinFugasCarter,
                IFugasSistemaFrenos = recepcionunidad.IFugasSistemaFrenos,
                IBateriaYCables = recepcionunidad.IBateriaYCables,
                CVidriosBuenEstado = recepcionunidad.CVidriosBuenEstado,
                CPuertasCierranBien = recepcionunidad.CPuertasCierranBien,
                CEspejosLateralesCompletos = recepcionunidad.CEspejosLateralesCompletos,
                CZoqueterasCompletas = recepcionunidad.CZoqueterasCompletas,
                CFaldonesYEstribos = recepcionunidad.CFaldonesYEstribos,
                CLimpiabrisasFuncionando = recepcionunidad.CLimpiabrisasFuncionando,
                CPlacas = recepcionunidad.CPlacas,
                PBombas = recepcionunidad.PBombas,
                PMirillas = recepcionunidad.PMirillas,
                PValvulas = recepcionunidad.PValvulas,
                PExtintor = recepcionunidad.PExtintor,
                PFiltros = recepcionunidad.PFiltros,
                PMangueras = recepcionunidad.PMangueras,
                PCarretes = recepcionunidad.PCarretes,
                Mecanico = recepcionunidad.Mecanico,
                FechaRegistro = recepcionunidad.FechaRegistro,
                Unidad = recepcionunidad.Unidad,
                Comentarios = recepcionunidad.Comentarios,
                MotivoIngreso = recepcionunidad.MotivoIngreso,
                Operador = recepcionunidad.Operador,
            };

            _dbcontext.RecepcionUnidades.Add(recepcionunidad);
            _dbcontext.SaveChangesAsync();


            return nuevoregistro;
         }

        public async Task<List<RecepcionUnidad>> recepcionLista()
        {
           List<RecepcionUnidad> lista= await _dbcontext.RecepcionUnidades.ToListAsync();
            return lista;
        }
    }
}

