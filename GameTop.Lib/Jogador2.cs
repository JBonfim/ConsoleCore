using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public readonly string _Nome = "Maradona" ;

        public string Chuta()
        {
            return $"{_Nome} está Chutando. \n";
        }

        public string Corre()
        {
            return $"{_Nome} está Correndo. \n"; 
        }

        public string Passe()
        {
            return $"{_Nome} está Passando.";
        }
    }
}