using APIRESTFULL_EF.Models;

namespace APIRESTFULL_EF.Interfaces
{
    public interface IOperador
    {
        Task<List<Operador>> OperadoresList();
    }
}
