using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace WebApiAutores
{
    public class StartUp
    {
        public StartUp(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) //Sistema de inyenccion de dependencia.
        {
            services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            services.AddDbContext<AplicationDbContext>(options => 
                    options.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));


            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen();

            services.AddAutoMapper(typeof(StartUp));
        }
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            //MiddleWares:

            app.Map("/ruta1", app => //Ejemplo de Middleware
            {
                app.Run(async contexto =>
                {
                    await contexto.Response.WriteAsync("Soy un middleware.");
                });
            });
            

            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(enpoint =>
            {
                enpoint.MapControllers();
            });

        }
    }
}
