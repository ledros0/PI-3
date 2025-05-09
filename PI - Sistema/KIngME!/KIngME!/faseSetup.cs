using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;
 public class faseSetup
{
    List<string> listaPersonagens = new List<string>(){
            "A", "B", "C", "D", "E", "G", "H", "K", "L", "M", "Q", "R", "T"
        };
    public string[] idSenhaJogador;
    public  int idpartida;

       public faseSetup(string[]idSenhaJogador,int idPartida) { 
        
        this.idSenhaJogador = idSenhaJogador;
        this.idpartida = idPartida;
       }
    public void reescreverLista()
    {
        listaPersonagens.Add("A");
        listaPersonagens.Add("B");
        listaPersonagens.Add("C");
        listaPersonagens.Add("D");
        listaPersonagens.Add("E");
        listaPersonagens.Add("G");
        listaPersonagens.Add("H");
        listaPersonagens.Add("K");
        listaPersonagens.Add("L");
        listaPersonagens.Add("M");
        listaPersonagens.Add("Q");
        listaPersonagens.Add("R");
        listaPersonagens.Add("T");
    }
    public void removerTodaLista()
    {
        listaPersonagens.Clear();
    }
    public void jogarPersonagem()
    {
        Random r = new Random();
        int setorAleatorio = r.Next(1, 5);
        int personagemAleatorio = r.Next(0, listaPersonagens.Count);

        int idJogador = Convert.ToInt32(idSenhaJogador[0]);
        string[] jogadorDaVez = Jogo.VerificarVez(idpartida).Split(',');


        string senhaJogador = idSenhaJogador[1];


        Jogo.ColocarPersonagem(idJogador, senhaJogador, setorAleatorio,
        Convert.ToString(listaPersonagens[personagemAleatorio]));
    }
    public void posicionarPersonagem()
    {
        if (listaPersonagens.Count == 0)
            return;

        string[] verificarPersonagemTabuleiro = Jogo.VerificarVez(idpartida).Replace("\r", "").Split('\n');

        if (!(verificarPersonagemTabuleiro[1] == ""))
        {
            for (int i = 1; i < verificarPersonagemTabuleiro.Length; i++)
            {
                string[] siglaPersonagem = verificarPersonagemTabuleiro[i].Split(',');
                if (siglaPersonagem.Length == 1)
                {
                    continue;
                }
                else
                {
                    if (listaPersonagens.Contains(siglaPersonagem[1]))
                    {
                        listaPersonagens.Remove(siglaPersonagem[1]);
                    }                  
                }
                //implementar estratégia de posicionamento
            }
            jogarPersonagem();
        }
        else
        {
            jogarPersonagem();
        }
      
    }
}

