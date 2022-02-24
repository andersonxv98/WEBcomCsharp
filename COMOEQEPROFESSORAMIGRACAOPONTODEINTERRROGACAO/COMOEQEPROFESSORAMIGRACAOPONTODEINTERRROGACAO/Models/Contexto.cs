using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace COMOEQEPROFESSORAMIGRACAOPONTODEINTERRROGACAO.Models
{
    public class Contexto : DbContext
    {
     
            public Contexto(DbContextOptions options): base(options)
        {

        }

        public  DbSet<Categoria> Categorias { get; set; }
        //injeção de dependencia tira a responsabilidade da classe de instanciar objetos, deixando a cargo da aplicação essa função(de instanciar o objeto);
    }
}
