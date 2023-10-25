
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Museum.Data;
using Museum.Data.ObjsForAuth;
using Museum.Models.Users;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;


namespace Museum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private MuseumContext context;

        public AccountController(MuseumContext context)
        {
            this.context = context;
        }
        [HttpPost("Login")]
        public async Task<ActionResult<string>> Login([FromBody] LogData data)
        {
            User user = await context.Users.Where(e=>e.name.Equals(data.Login) && e.password.Equals(data.Password)).FirstOrDefaultAsync();
            
            if (user != null)
            {
                string jwt = CreateToken(user);
                return Ok(jwt);
            }
            else
            {
                return BadRequest("Введені некоректні дані");
            }
        }

        [HttpPost("Register")]
        public async Task<ActionResult<string>> Register(User data)
        {
           
            
            User user = new User()
            {               
                name = data.name,
                password = data.password,   

            };
            context.Users.Add(user);
            await context.SaveChangesAsync();

            return Ok("Користувача створено");
        }

        private string CreateToken(User user)
        {
            var identity = GetIdentity(user);
            var now = DateTime.UtcNow;

            var jwt = new JwtSecurityToken(
               issuer: AuthOptions.ISSUER,
            audience: AuthOptions.AUDIENCE,
            notBefore: now,
            claims: identity.Claims,
            expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
               signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            return encodedJwt;
        }
        private ClaimsIdentity GetIdentity(User user)
        {
            var claims = new List<Claim>
                {
                    new Claim("Id", Convert.ToString(user.id)),
                    new Claim("Name", Convert.ToString(user.name)),
                    new Claim("Login", Convert.ToString(user.name))
                };
            ClaimsIdentity claimsIdentity =
            new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            return claimsIdentity;
        }

    }
}
