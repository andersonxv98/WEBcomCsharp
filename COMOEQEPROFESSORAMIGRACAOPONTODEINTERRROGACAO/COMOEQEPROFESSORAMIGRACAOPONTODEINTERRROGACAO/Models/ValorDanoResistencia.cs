namespace COMOEQEPROFESSORAMIGRACAOPONTODEINTERRROGACAO.Models
{
    public class ValorDanoResistencia
    {
        int Dano { get; set; }
        int Resistencia { get; set; }

        public ValorDanoResistencia(int dano, int resistencia)
        { 
            if (resistencia > 0)
            {
                Dano = dano;
                Resistencia = resistencia;
            }
            else
            {
                return;
            }
        }
    }
}
