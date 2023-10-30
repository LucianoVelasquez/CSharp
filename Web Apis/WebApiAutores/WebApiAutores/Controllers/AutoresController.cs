using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiAutores.DTOS;
using WebApiAutores.Entidades;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/autores")] //Un ejemplo de ruta "api/[controller]" => [controller] = Toma el nombre de la clase, en este caso Autores.
    public class AutoresController: ControllerBase
    {
        private readonly AplicationDbContext context;
        private readonly IMapper mapper;

        public AutoresController(AplicationDbContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet] //Atributo de enrutamiento, decora el metodo del controlador.
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
        public async Task<ActionResult> Put([FromBody] Autor autor,[FromRoute] int id)
        {
            if(autor.Id != id)
            {
                return BadRequest("El id del autor no coincide con el id de la URL");
            }

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
    }
}
