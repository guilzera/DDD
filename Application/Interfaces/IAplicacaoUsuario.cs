using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAplicacaoUsuario
    {
        Task<bool> AdicionarUsuario(string email, string senha, int idade, string celular);

        Task<bool> ExisteUsuario(string email, string senha);

        Task<string> RetornaIdUsuario(string email);
    }
}
