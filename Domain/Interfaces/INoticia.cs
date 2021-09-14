using Domain.Interfaces.Generics;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface INoticia : IGenericos<Noticia>
    {
        //Metodo customizado (consegue fazer qualquer expressao, usando o Expression)
        Task<List<Noticia>> ListarNoticias(Expression<Func<Noticia, bool>> exNoticia);
    }
}
