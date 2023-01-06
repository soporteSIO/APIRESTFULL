using System.ComponentModel.DataAnnotations;

namespace APIRESTFULL_EF.Models
{
    public class Operador
    {

        [Key]
        public int IdEmpleado { get; set; }

        public int IdDepartamento { get; set; }

        public int IdEstatusEmpleado { get; set; }
        public string? NombreCompleto { get; set; }
    }
}
