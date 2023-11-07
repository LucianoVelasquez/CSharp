using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApiAutores.DTOS;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/cuentas")]
    public class CuentasController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;
        private readonly SignInManager<IdentityUser> signInManager;

        public CuentasController(UserManager<IdentityUser> userManager,IConfiguration configuration, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.signInManager = signInManager;
        }

        [HttpPost("registrar")] //  api/cuentas/registrar
        public async Task<ActionResult<RepuestaAuntenticacion>> Registrar(CredencialUsuario credencialUsuario)
        {
            var usuario = new IdentityUser { UserName = credencialUsuario.Email, Email = credencialUsuario.Email };
            var resultado = await userManager.CreateAsync(usuario,credencialUsuario.Paswword);

            if (resultado.Succeeded)
            {
                return ContruirToken(credencialUsuario);
            }
            else
            {
                return BadRequest(resultado.Errors);
            }
        }
        [HttpPost("login")]
        public async Task<ActionResult<RepuestaAuntenticacion>> Login(CredencialUsuario credencialUsuario)
        {
            var resultado = await signInManager.PasswordSignInAsync(credencialUsuario.Email,
                credencialUsuario.Paswword, isPersistent: false, lockoutOnFailure: false);

            if (resultado.Succeeded)
            {
                return ContruirToken(credencialUsuario);
            }
            else
            {
                return BadRequest("Login Incorrecto");
            }
        }
        private RepuestaAuntenticacion ContruirToken(CredencialUsuario credencialUsuario)
        {
            var claims = new List<Claim>()
            {
                new Claim("email", credencialUsuario.Email),

            };

            var llave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["llavejwt"]));
            var creds = new SigningCredentials(llave, SecurityAlgorithms.HmacSha256);

            var expiracion = DateTime.UtcNow.AddYears(1);

            var securityToken = new JwtSecurityToken(issuer: null, audience: null, claims: claims, expires: expiracion, signingCredentials: creds);

            return new RepuestaAuntenticacion()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(securityToken),
                Expiracion = expiracion,
            };
        }
    }
}
