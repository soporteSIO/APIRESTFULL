using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace APIRESTFULL_EF.Models
{
    public class Usuario
    {
        [Key]
        public string? U_Usuario { get; set; }
        public string? U_Contrasena { get; set; }
        
        public string? NombreCompleto { get; set; }
        public int U_IdEstatusEmpleado { get; set; }
        public int U_IdDepartamento { get; set; }
    }
}
