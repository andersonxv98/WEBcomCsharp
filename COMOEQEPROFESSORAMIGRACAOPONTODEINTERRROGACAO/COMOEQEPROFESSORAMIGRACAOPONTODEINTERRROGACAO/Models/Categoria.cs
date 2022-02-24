using System.ComponentModel.DataAnnotations;

namespace COMOEQEPROFESSORAMIGRACAOPONTODEINTERRROGACAO.Models
{
    public class Categoria
    {
        [Key]   
        public int id { get; set; }
        
        public string description { get; set; }

        public Categoria(int id, string description)
        {
            this.id = id;
            this.description = description;
        }
    }
}
