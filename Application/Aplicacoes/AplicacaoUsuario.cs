using Application.Interfaces;
using Domain.Interfaces;
using System.Threading.Tasks;

namespace Application.Aplicacoes
{
    public class AplicacaoUsuario : IAplicacaoUsuario
    {
        IUsuario _IUsuario;

        public AplicacaoUsuario(IUsuario Usuario)
        {
            _IUsuario = Usuario;
        }

        public async Task<bool> AdicionarUsuario(string email, string senha, int idade, string celular)
        {
            return await _IUsuario.AdicionarUsuario(email, senha, idade, celular);
        }

        public async Task<bool> ExisteUsuario(string email, string senha)
        {
            return await _IUsuario.ExisteUsuario(email, senha);
        }
    }
}
