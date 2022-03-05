namespace COMOEQEPROFESSORAMIGRACAOPONTODEINTERRROGACAO.Models
{
    public class Atributos
    {
        bool ameacar { get; set; }
        bool vinculovida { get; set; }
        bool toquemortifero { get; set; }

        bool indestrutivel { get; set; }

        bool voar { get; set; }

        bool defensor { get; set; }

        public Atributos(bool ameacar, bool vinculovida, bool toquemortifero, bool indestrutivel, bool voar, bool defensor)
        {
            this.ameacar = ameacar;
            this.vinculovida = vinculovida;
            this.toquemortifero = toquemortifero;
            this.indestrutivel = indestrutivel;
            this.voar = voar;
            this.defensor = defensor;
        }
    }
}
