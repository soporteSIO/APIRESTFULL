using APIRESTFULL_EF.Context;
using APIRESTFULL_EF.Interfaces;
using APIRESTFULL_EF.Models;

namespace APIRESTFULL_EF.Services
{
    public class OperadorService:IOperador
    {
        private readonly DefMtyContext _dbcontext;

        public OperadorService(DefMtyContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<Operador>> OperadoresList()
        {

            var res = from o in _dbcontext.Trabajadores
                      where o.IdDepartamento == 7 && o.IdEstatusEmpleado == 1
                      orderby o.NombreCompleto ascending
                      select o;
                     
            List<Operador> operadores = new List<Operador>(res);
            return operadores;

        }
    }
}
