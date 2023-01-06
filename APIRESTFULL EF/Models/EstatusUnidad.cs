using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;


namespace APIRESTFULL_EF.Models
{
    public class EstatusUnidad
    {
        [Key]
       
        public int EstatusId { get; set; }
        public string Descripcion { get; set; }

     
  
    }
}
