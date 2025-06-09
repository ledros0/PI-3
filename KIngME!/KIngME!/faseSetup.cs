using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;
using manager;
public class faseSetup
{
    List<string> listaPersonagens = new List<string>(){
            "A", "B", "C", "D", "E", "G", "H", "K", "L", "M", "Q", "R", "T"
        };
    public string[] idSenhaJogador;
    public  int idpartida;
    int rodada = 0;
    public faseSetup(string[]idSenhaJogador,int idPartida) { 
        
        this.idSenhaJogador = idSenhaJogador;
        this.idpartida = idPartida;
       }
    public void removerTodaLista()
    {
        listaPersonagens.Clear();
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
    public void jogarPersonagem()
    {
        string favoritos = Jogo.ListarCartas(Convert.ToInt32(idSenhaJogador[0]), idSenhaJogador[1]);
        string[] favoritosArray = favoritos.Select(c => c.ToString()).ToArray();

        Random r = new Random();
        int[] setor = { 5, 4, 5, 4, 5, 4, 5, 4 };

        int personagem = r.Next(0, favoritosArray.Length);
        int listaAleatoria = r.Next(0, listaPersonagens.Count);
        int numeroBaixo = r.Next(1, 5);

        int idJogador = Convert.ToInt32(idSenhaJogador[0]);
        string senhaJogador = idSenhaJogador[1];

        if (rodada >= setor.Length)
        {
            rodada = 0;
        }

        string[] estadoTabuleiro = Jogo.VerificarVez(idpartida).Replace("\r", "").Split('\n');

        foreach (string linha in estadoTabuleiro)
        {
            string[] partes = linha.Split(',');

            if (partes.Length > 1)
            {
                string personagemJogado = partes[1];

                if (favoritosArray.Contains(personagemJogado))
                {
                    Jogo.ColocarPersonagem(idJogador, senhaJogador, numeroBaixo, listaPersonagens[listaAleatoria]);
                    rodada++;
                    return;
                }
            }
        }
        Jogo.ColocarPersonagem(idJogador, senhaJogador, setor[rodada], favoritosArray[personagem]);
        rodada++;
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

