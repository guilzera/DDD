using Application.Interfaces.Genericos;
using Entidades.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAplicacaoNoticia : IGenericaAplicacao<Noticia>
    {
        Task AdicionarNoticia(Noticia noticia);

        Task AtualizaNoticia(Noticia noticia);

        Task<List<Noticia>> ListarNoticiasAtivas();
    }
}
