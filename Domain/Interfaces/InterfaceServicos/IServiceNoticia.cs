using Entidades.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface IServiceNoticia
    {
        Task AdicionarNoticia(Noticia noticia);

        Task AtualizaNoticia(Noticia noticia);

        Task<List<Noticia>> ListarNoticiasAtivas();
    }
}
