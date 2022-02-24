using Microsoft.AspNetCore.Builder;
using COMOEQEPROFESSORAMIGRACAOPONTODEINTERRROGACAO.Models;
using Microsoft.EntityFrameworkCore;

namespace COMOEQEPROFESSORAMIGRACAOPONTODEINTERRROGACAO
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration) { Configuration = configuration; }
        public void Configure(IApplicationBuilder app)
        {
            
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
        public void ConfigureServices(IServiceCollection services) {
            services.AddDbContext<Contexto>(options => options.UseSqlServer(Configuration.GetConnectionString("conexao")));
        }
    }
}
