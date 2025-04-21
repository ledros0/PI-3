using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;

namespace KIngME_
{
    public class fasePromocao
    {
        int idJogador;
        string senhaJogador;
        string favoritos;
        
        public fasePromocao(int idJogador,string senhaJogador,string favoritos) {
            this.idJogador = idJogador;
            this.senhaJogador = senhaJogador;
            this.favoritos = favoritos;
        }
  
        public void posicionar()
        {   
            Random r = new Random();
            string[] letrasFavoritos = favoritos.Select(c => c.ToString()).ToArray();
            int i = r.Next(0,letrasFavoritos.Length);
            Jogo.Promover(idJogador, senhaJogador,letrasFavoritos[i]);
        }
    }
}
