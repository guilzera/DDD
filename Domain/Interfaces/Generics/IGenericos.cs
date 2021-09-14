using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    //interface que contém os serviços CRUD
    public interface IGenericos<T> where T : class
    {
        Task Adicionar(T Objeto);

        Task Atualizar(T Objeto);

        Task Remover(T Objeto);

        Task<T> BuscarPorId(int Id);

        Task<List<T>> Listar();
    }
}
