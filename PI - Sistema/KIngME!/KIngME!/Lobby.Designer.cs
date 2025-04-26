using KingMeServer;

namespace KIngME_
{
    partial class Lobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lbPartidas = new System.Windows.Forms.ListBox();
            this.cbStatusPartidas = new System.Windows.Forms.ComboBox();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lbJogadores = new System.Windows.Forms.ListBox();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(26, 21);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(85, 13);
            this.lblNomePartida.TabIndex = 0;
            this.lblNomePartida.Text = "Noma da partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Location = new System.Drawing.Point(26, 55);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(88, 13);
            this.lblSenhaPartida.TabIndex = 1;
            this.lblSenhaPartida.Text = "Senha da partida";
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(26, 91);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(66, 13);
            this.lblIdPartida.TabIndex = 2;
            this.lblIdPartida.Text = "Id da partida";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(26, 127);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(88, 13);
            this.lblNomeJogador.TabIndex = 3;
            this.lblNomeJogador.Text = "Nome do jogador";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(127, 18);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(100, 20);
            this.txtNomePartida.TabIndex = 4;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(127, 52);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaPartida.TabIndex = 5;
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(127, 88);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(100, 20);
            this.txtIdPartida.TabIndex = 6;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(127, 124);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(100, 20);
            this.txtNomeJogador.TabIndex = 7;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(29, 166);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(75, 23);
            this.btnCriarPartida.TabIndex = 8;
            this.btnCriarPartida.Text = "Criar partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lbPartidas
            // 
            this.lbPartidas.FormattingEnabled = true;
            this.lbPartidas.Location = new System.Drawing.Point(247, 55);
            this.lbPartidas.Name = "lbPartidas";
            this.lbPartidas.Size = new System.Drawing.Size(220, 134);
            this.lbPartidas.TabIndex = 9;
            this.lbPartidas.SelectedIndexChanged += new System.EventHandler(this.lbPartidas_SelectedIndexChanged);
            // 
            // cbStatusPartidas
            // 
            this.cbStatusPartidas.FormattingEnabled = true;
            this.cbStatusPartidas.Items.AddRange(new object[] {
            "Todas",
            "Abertas",
            "Jogando",
            "Encerradas"});
            this.cbStatusPartidas.Location = new System.Drawing.Point(247, 17);
            this.cbStatusPartidas.Name = "cbStatusPartidas";
            this.cbStatusPartidas.Size = new System.Drawing.Size(133, 21);
            this.cbStatusPartidas.TabIndex = 10;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(386, 16);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(81, 23);
            this.btnListarPartidas.TabIndex = 11;
            this.btnListarPartidas.Text = "Listar partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(152, 166);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(75, 23);
            this.btnEntrarPartida.TabIndex = 12;
            this.btnEntrarPartida.Text = "Entrar";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(88, 241);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(85, 23);
            this.btnIniciarPartida.TabIndex = 13;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(26, 292);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(43, 13);
            this.lblVersao.TabIndex = 14;
            this.lblVersao.Text = "Versão ";
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Location = new System.Drawing.Point(26, 329);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(10, 13);
            this.lblNomeGrupo.TabIndex = 15;
            this.lblNomeGrupo.Text = ".";
            // 
            // lbJogadores
            // 
            this.lbJogadores.FormattingEnabled = true;
            this.lbJogadores.Location = new System.Drawing.Point(347, 192);
            this.lbJogadores.Name = "lbJogadores";
            this.lbJogadores.Size = new System.Drawing.Size(120, 69);
            this.lbJogadores.TabIndex = 16;
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(244, 235);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(58, 13);
            this.lblSenhaJogador.TabIndex = 17;
            this.lblSenhaJogador.Text = "Sua senha";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(244, 192);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(40, 13);
            this.lblIdJogador.TabIndex = 18;
            this.lblIdJogador.Text = "Seu ID";
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Location = new System.Drawing.Point(26, 210);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(204, 13);
            this.lblErros.TabIndex = 19;
            this.lblErros.Text = "Caso tenha algum erro ele aparecerá aqui";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 367);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lbJogadores);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.cbStatusPartidas);
            this.Controls.Add(this.lbPartidas);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.ListBox lbPartidas;
        private System.Windows.Forms.ComboBox cbStatusPartidas;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.ListBox lbJogadores;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblErros;
    }
}