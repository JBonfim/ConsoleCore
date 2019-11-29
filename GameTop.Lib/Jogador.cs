using System;
using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador : iJogador
    {
        public readonly string _Nome ;

        public Jogador(string nome)
        {
            this._Nome = nome;
        }

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