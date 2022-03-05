namespace COMOEQEPROFESSORAMIGRACAOPONTODEINTERRROGACAO.Models
{
    public class Mana 
    {
        int incolor { get; set; }
        int vermelho { get; set; }
        int verde { get; set; }
        int azul { get; set; }
        int preto { get; set; }
        int branco { get; set; }

        public Mana(int incolor, int vermelho, int verde, int azul, int preto, int branco)
        {
            this.incolor = incolor;
            this.vermelho = vermelho;
            this.verde = verde;
            this.azul = azul;
            this.preto = preto;
            this.branco = branco;
        }
    }
}