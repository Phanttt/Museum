
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
            User user = await context.Users.Include(u => u.Role).Where(e=>e.name.Equals(data.Login) && e.password.Equals(data.Password)).FirstOrDefaultAsync();

			Role userRole = context.Roles.Where(x => x.id == user.Role.id).FirstOrDefault();

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
        public async Task<ActionResult<string>> Register(UserAccept data)
        {

            Role userRole = context.Roles.Where(x => x.id == data.roleId).FirstOrDefault();

			User user = new User()
            {               
                name = data.name,
                password = data.password,   
                Role = userRole,
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
                    new Claim("id", Convert.ToString(user.id)),
                    new Claim("name", Convert.ToString(user.name)),
                    new Claim("login", Convert.ToString(user.name)),
                    new Claim("roleId", Convert.ToString(user.Role.id))
                };
            ClaimsIdentity claimsIdentity =
            new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            return claimsIdentity;
        }

    }
}
