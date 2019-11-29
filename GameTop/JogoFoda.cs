using System;
using GameTop.Interface;

namespace GameTop
{
    class JogoFoda{
        private readonly iJogador _Jogador;

        public JogoFoda(iJogador jogador)
        {
            this._Jogador = jogador;
        }
        public void IniciarJogo(){
           Console.Write(_Jogador.Corre());
            Console.Write(_Jogador.Chuta());
           Console.Write( _Jogador.Passe());

        }
    }
}