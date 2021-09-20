using System;
using System.IdentityModel.Tokens.Jwt;

namespace WebAPI.Token
{
    public class TokenJWT
    {
        private JwtSecurityToken token;

        internal TokenJWT(JwtSecurityToken token)
        {
            this.token = token;
        }

        //Data de validação do token
        public DateTime VaalidTo => token.ValidTo;

        public string value => new JwtSecurityTokenHandler().WriteToken(this.token);
    }
}
