using Application.Interfaces;
using Domain.Interfaces;
using Domain.Interfaces.InterfaceServicos;
using Entidades.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Aplicacoes
{
    public class AplicacaoNoticia : IAplicacaoNoticia
    {
        INoticia _INoticia;
        IServiceNoticia _IServicoNoticia;
        
        public AplicacaoNoticia(INoticia INoticia, IServiceNoticia IServicoNoticia)
        {
            _INoticia = INoticia;
            _IServicoNoticia = IServicoNoticia; 
        }

        public async Task<List<Noticia>> Listar()
        {
            return await _INoticia.Listar();
        }

        public async Task<Noticia> BuscarPorId(int Id)
        {
            return await _INoticia.BuscarPorId(Id);
        }

        public async Task Adicionar(Noticia Objeto)
        {
            await _INoticia.Adicionar(Objeto);
        }

        public async Task Atualizar(Noticia Objeto)
        {
            await _INoticia.Atualizar(Objeto);
        }

        public async Task Remover(Noticia Objeto)
        {
            await _INoticia.Remover(Objeto);
        }

        public async Task AdicionarNoticia(Noticia noticia)
        {
            await _IServicoNoticia.AdicionarNoticia(noticia);   
        }

        public async Task AtualizaNoticia(Noticia noticia)
        {
            await _IServicoNoticia.AtualizaNoticia(noticia);
        }

        public async Task<List<Noticia>> ListarNoticiasAtivas()
        {
            return await _IServicoNoticia.ListarNoticiasAtivas();
        }

    }
}
