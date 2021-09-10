using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Notificacoes
{
    public class Notifica
    {
        [NotMapped]
        public string NomePropriedade { get; set; } //Nome do erro

        [NotMapped]
        public string Mensagem { get; set; } //Mensagem do erro

        [NotMapped]
        public List<Notifica> Notificacoes; //Lista de erros de validações

        public Notifica()
        {
            Notificacoes = new List<Notifica>();
        }

        public bool ValidarPropriedadeString(string valor, string nomePropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notifica
                {
                    Mensagem = "Campo obrigatório",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            return true;
        }

        public bool ValdiarPropriedadeDecimal(decimal valor, string nomePropriedade)
        {
            if(valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notifica
                {
                    Mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = nomePropriedade
                });

                return false;
            }
            return true;
        }
    }
}
