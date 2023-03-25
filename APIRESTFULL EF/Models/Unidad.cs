using APIRESTFULL_EF.Controllers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;

namespace APIRESTFULL_EF.Models
{
    public class Unidad
    {
        [Key]
        public int Idunidad { get; set; }

        public int NumeroEconomico { get; set; }

        public string Tipo { get; set; }

        public string Capacidad { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Serie { get; set; }

        public string Placas { get; set; }

        public int IdTipoServicio { get; set; }

        public int OtroServicio { get; set; }

        public int IdTipoServicio2 { get; set; }

        public string Estatus { get; set; }

        public int IdUnidadM { get; set; }

        public int IdEstatus { get; set; }

        public int ServiciosDiarios { get; set; }

        public int? Orden { get; set; }

        public string CategoriaAlethia { get; set; }

        public int? Id_CategoriaUnidad { get; set; }

        public string? FechaIngresoTaller { get; set; }

        public string? FechaSalidaTaller { get; set; }



    }

   
   
}
