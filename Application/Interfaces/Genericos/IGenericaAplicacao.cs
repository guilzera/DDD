using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces.Genericos
{
    public interface IGenericaAplicacao<T> where T : class
    {
        Task Adicionar(T Objeto);

        Task Atualizar(T Objeto);

        Task Remover(T Objeto);

        Task<T> BuscarPorId(int Id);

        Task<List<T>> Listar();
    }
}
