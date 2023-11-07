using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiAutores.DTOS;
using WebApiAutores.Entidades;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/autores")] //Un ejemplo de ruta "api/[controller]" => [controller] = Toma el nombre de la clase, en este caso Autores.
    public class AutoresController : ControllerBase
    {
        private readonly AplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;

        public AutoresController(AplicationDbContext context, IMapper mapper,IConfiguration configuration)
        {
            this.context = context;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        [HttpGet] //Atributo de enrutamiento, decora el metodo del controlador.
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<List<AutorDTO>>> Get()
        {
            var autores = await context.Autores.ToListAsync();

            return mapper.Map<List<AutorDTO>>(autores);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<AutorDTO>> Get([FromRoute] int id)
        {
            var autor = await context.Autores.FirstOrDefaultAsync(autorDB => autorDB.Id == id);

            if (autor == null)
            {
                return NotFound();
            }

            return mapper.Map<AutorDTO>(autor);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AutorCreacionDTO autorCreacionDTO)
        {
            var autor = mapper.Map<Autor>(autorCreacionDTO);

            context.Add(autor);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")] // api/autores/id
        public async Task<ActionResult> Put(AutorCreacionDTO autorCreacionDTO,int id)
        {
            var existe = await context.Autores.AnyAsync(autor => autor.Id == id);

            if (!existe) { return NotFound(); }

            var autor = mapper.Map<Autor>(autorCreacionDTO);
            autor.Id = id;

            context.Update(autor);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            var existe = await context.Autores.AnyAsync(x => x.Id == id);

            if (!existe) return NotFound();

            context.Remove(new Autor { Id = id });
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("configuraciones")]
        public ActionResult<string[]> OntenerConfiguracion()
        {
            var apellido = new [] { configuration["apellido2"], configuration["connectionStrings:defaultConnection"] };
            //apellido2 viene de variable de entorno. "Depurar/Propiedad de APP"
            //el segundo agurmento viene de appsettings.develoment.json //conexion a bd
            return apellido; 
        }
    }
}
