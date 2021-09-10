using Entidades.Enums;
using Microsoft.AspNetCore.Identity;

namespace Entidades.Entidades
{
    public class ApplicationUser : IdentityUser
    {
        public int Idade { get; set; }

        public string Celular { get; set; }

        public TipoUsuario? Tipo { get; set; }
    }
}
