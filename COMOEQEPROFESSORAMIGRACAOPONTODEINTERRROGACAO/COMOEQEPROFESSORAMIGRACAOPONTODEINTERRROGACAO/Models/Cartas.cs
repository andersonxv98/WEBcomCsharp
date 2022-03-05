using System.ComponentModel.DataAnnotations;

namespace COMOEQEPROFESSORAMIGRACAOPONTODEINTERRROGACAO.Models
{
    public class Cartas
    {
        [Key]
        public int ID { get; set; }
       public Mana mana_ { get; set; }
        public Atributos atributos_ { get; set; }
        public ValorDanoResistencia valorDanores_ { get; set; }

        public string descricao { get; set; }

        public Cartas(int id ,string descricao,
            int incolor, int vermelho, int verde, int azul, int preto, int branco,
            bool ameacar, bool vinculovida, bool toquemortifero, bool indestrutivel, bool voar, bool defensor,
            int dano, int resistencia
            )

        {   this.ID = id;
            this.descricao = descricao;
            this.mana_ = new Mana(incolor,vermelho,verde,azul,preto,branco);
            this.atributos_ =new Atributos(ameacar,vinculovida,toquemortifero,indestrutivel, voar,defensor);
            this.valorDanores_ = new ValorDanoResistencia( dano,resistencia);
        }

      /*  public bool VerTerreno()
        {
            if (this.mana_ == null)
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        public bool VerDifCreature()
        {
            if (this.valorDanores_ == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
