namespace KIngME_
{
    partial class btnfavoritos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label13 = new System.Windows.Forms.Label();
            this.lbListaDePersonagens = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.lbPartidasListadas = new System.Windows.Forms.ListBox();
            this.lblidPartida = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbListarJogadores = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblgrupo = new System.Windows.Forms.Label();
            this.lblversao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lblPartida = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.txtJogadorNome = new System.Windows.Forms.TextBox();
            this.txtSenhaEntrarPartida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEntrarNaPartida = new System.Windows.Forms.Button();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFavoritos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbListarOpcoes = new System.Windows.Forms.ComboBox();
            this.lblErroIniciar = new System.Windows.Forms.Label();
            this.lblPersonagem = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.txtPosicionarPersonagem = new System.Windows.Forms.TextBox();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.btnPosicionar = new System.Windows.Forms.Button();
            this.lblIdVez = new System.Windows.Forms.Label();
            this.lblJogadorVez = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblJogadorDaVez = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblerros = new System.Windows.Forms.Label();
            this.lblErroposicao = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 688);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "LOBBY";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // lbListaDePersonagens
            // 
            this.lbListaDePersonagens.Enabled = false;
            this.lbListaDePersonagens.FormattingEnabled = true;
            this.lbListaDePersonagens.Items.AddRange(new object[] {
            "Adilson Konrad",
            "Beatriz Paiva",
            "Claro",
            "Douglas Baquiao",
            "Eduardo Takeo",
            "Guilherme Rey",
            "Heredia",
            "Karin",
            "Leonardo Takuno",
            "Mario Toledo",
            "Quintas",
            "Ranulfo",
            "Toshio"});
            this.lbListaDePersonagens.Location = new System.Drawing.Point(1063, 340);
            this.lbListaDePersonagens.Name = "lbListaDePersonagens";
            this.lbListaDePersonagens.Size = new System.Drawing.Size(114, 173);
            this.lbListaDePersonagens.TabIndex = 45;
            this.lbListaDePersonagens.SelectedIndexChanged += new System.EventHandler(this.lbListarPersonagem_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1091, 324);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "Personagens";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "10,Rei",
            "5,Nobres",
            "4,Dignatários",
            "3,Oficiais",
            "2,Mercadores",
            "1,Artesãos",
            "0,Plebeus"});
            this.listBox1.Location = new System.Drawing.Point(1072, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 121);
            this.listBox1.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1091, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Setores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Criar Partida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome da Partida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha da Partida";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(105, 6);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(125, 20);
            this.txtNomePartida.TabIndex = 9;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(105, 47);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(125, 20);
            this.txtSenhaPartida.TabIndex = 10;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(388, 12);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(124, 23);
            this.btnListarPartidas.TabIndex = 11;
            this.btnListarPartidas.Text = "Partidas Existentes";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lbPartidasListadas
            // 
            this.lbPartidasListadas.FormattingEnabled = true;
            this.lbPartidasListadas.Location = new System.Drawing.Point(272, 47);
            this.lbPartidasListadas.Name = "lbPartidasListadas";
            this.lbPartidasListadas.Size = new System.Drawing.Size(214, 368);
            this.lbPartidasListadas.TabIndex = 12;
            this.lbPartidasListadas.SelectedIndexChanged += new System.EventHandler(this.lbPartidasListadas_SelectedIndexChanged);
            // 
            // lblidPartida
            // 
            this.lblidPartida.AutoSize = true;
            this.lblidPartida.Location = new System.Drawing.Point(550, 83);
            this.lblidPartida.Name = "lblidPartida";
            this.lblidPartida.Size = new System.Drawing.Size(0, 13);
            this.lblidPartida.TabIndex = 13;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(584, 115);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(0, 13);
            this.lblNomePartida.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Id Partida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nome da Partida:";
            // 
            // lbListarJogadores
            // 
            this.lbListarJogadores.FormattingEnabled = true;
            this.lbListarJogadores.Location = new System.Drawing.Point(492, 179);
            this.lbListarJogadores.Name = "lbListarJogadores";
            this.lbListarJogadores.Size = new System.Drawing.Size(120, 95);
            this.lbListarJogadores.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 616);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Grupo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Versão:";
            // 
            // lblgrupo
            // 
            this.lblgrupo.AutoSize = true;
            this.lblgrupo.Location = new System.Drawing.Point(53, 588);
            this.lblgrupo.Name = "lblgrupo";
            this.lblgrupo.Size = new System.Drawing.Size(22, 13);
            this.lblgrupo.TabIndex = 22;
            this.lblgrupo.Text = "1.1";
            // 
            // lblversao
            // 
            this.lblversao.AutoSize = true;
            this.lblversao.Location = new System.Drawing.Point(53, 616);
            this.lblversao.Name = "lblversao";
            this.lblversao.Size = new System.Drawing.Size(102, 13);
            this.lblversao.TabIndex = 23;
            this.lblversao.Text = "Copistas de Durham";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nome do Grupo";
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Location = new System.Drawing.Point(105, 83);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(0, 13);
            this.lblNomeGrupo.TabIndex = 25;
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Location = new System.Drawing.Point(102, 142);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(0, 13);
            this.lblPartida.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Id Partida";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(105, 209);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(100, 20);
            this.txtIdPartida.TabIndex = 28;
            // 
            // txtJogadorNome
            // 
            this.txtJogadorNome.Location = new System.Drawing.Point(105, 298);
            this.txtJogadorNome.Name = "txtJogadorNome";
            this.txtJogadorNome.Size = new System.Drawing.Size(100, 20);
            this.txtJogadorNome.TabIndex = 29;
            // 
            // txtSenhaEntrarPartida
            // 
            this.txtSenhaEntrarPartida.Location = new System.Drawing.Point(105, 251);
            this.txtSenhaEntrarPartida.Name = "txtSenhaEntrarPartida";
            this.txtSenhaEntrarPartida.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaEntrarPartida.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Id da Partida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Nome de Jogador";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Senha da Partida";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Senha do Jogador:";
            // 
            // btnEntrarNaPartida
            // 
            this.btnEntrarNaPartida.Location = new System.Drawing.Point(105, 340);
            this.btnEntrarNaPartida.Name = "btnEntrarNaPartida";
            this.btnEntrarNaPartida.Size = new System.Drawing.Size(75, 23);
            this.btnEntrarNaPartida.TabIndex = 35;
            this.btnEntrarNaPartida.Text = "Entrar";
            this.btnEntrarNaPartida.UseVisualStyleBackColor = true;
            this.btnEntrarNaPartida.Click += new System.EventHandler(this.btnEntrarNaPartida_Click);
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(112, 417);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(0, 13);
            this.lblSenhaJogador.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 402);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "ID Jogador:";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(116, 394);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(0, 13);
            this.lblIdJogador.TabIndex = 38;
            this.lblIdJogador.Click += new System.EventHandler(this.lblIdJogador_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Iniciar Partida";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(646, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 730);
            this.textBox1.TabIndex = 40;
            // 
            // lblFavoritos
            // 
            this.lblFavoritos.AutoSize = true;
            this.lblFavoritos.Location = new System.Drawing.Point(855, 22);
            this.lblFavoritos.Name = "lblFavoritos";
            this.lblFavoritos.Size = new System.Drawing.Size(0, 13);
            this.lblFavoritos.TabIndex = 42;
            this.lblFavoritos.Click += new System.EventHandler(this.lblFavoritos_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(796, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Favoritos:";
            // 
            // cbListarOpcoes
            // 
            this.cbListarOpcoes.FormattingEnabled = true;
            this.cbListarOpcoes.Items.AddRange(new object[] {
            "Todos",
            "Abertas",
            "Jogando",
            "Encerradas"});
            this.cbListarOpcoes.Location = new System.Drawing.Point(257, 12);
            this.cbListarOpcoes.Name = "cbListarOpcoes";
            this.cbListarOpcoes.Size = new System.Drawing.Size(121, 21);
            this.cbListarOpcoes.TabIndex = 44;
            // 
            // lblErroIniciar
            // 
            this.lblErroIniciar.AutoSize = true;
            this.lblErroIniciar.Location = new System.Drawing.Point(15, 498);
            this.lblErroIniciar.Name = "lblErroIniciar";
            this.lblErroIniciar.Size = new System.Drawing.Size(0, 13);
            this.lblErroIniciar.TabIndex = 46;
            // 
            // lblPersonagem
            // 
            this.lblPersonagem.AutoSize = true;
            this.lblPersonagem.Location = new System.Drawing.Point(687, 82);
            this.lblPersonagem.Name = "lblPersonagem";
            this.lblPersonagem.Size = new System.Drawing.Size(69, 13);
            this.lblPersonagem.TabIndex = 50;
            this.lblPersonagem.Text = "Personagem:";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(711, 125);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(38, 13);
            this.lblSetor.TabIndex = 51;
            this.lblSetor.Text = "Setor: ";
            // 
            // txtPosicionarPersonagem
            // 
            this.txtPosicionarPersonagem.Location = new System.Drawing.Point(763, 83);
            this.txtPosicionarPersonagem.Name = "txtPosicionarPersonagem";
            this.txtPosicionarPersonagem.Size = new System.Drawing.Size(100, 20);
            this.txtPosicionarPersonagem.TabIndex = 52;
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(763, 125);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(100, 20);
            this.txtSetor.TabIndex = 53;
            // 
            // btnPosicionar
            // 
            this.btnPosicionar.Location = new System.Drawing.Point(892, 105);
            this.btnPosicionar.Name = "btnPosicionar";
            this.btnPosicionar.Size = new System.Drawing.Size(75, 23);
            this.btnPosicionar.TabIndex = 54;
            this.btnPosicionar.Text = "Posicionar";
            this.btnPosicionar.UseVisualStyleBackColor = true;
            this.btnPosicionar.Click += new System.EventHandler(this.btnPosicionar_Click);
            // 
            // lblIdVez
            // 
            this.lblIdVez.AutoSize = true;
            this.lblIdVez.Location = new System.Drawing.Point(690, 225);
            this.lblIdVez.Name = "lblIdVez";
            this.lblIdVez.Size = new System.Drawing.Size(96, 13);
            this.lblIdVez.TabIndex = 55;
            this.lblIdVez.Text = "Id Jogador da Vez:";
            // 
            // lblJogadorVez
            // 
            this.lblJogadorVez.AutoSize = true;
            this.lblJogadorVez.Location = new System.Drawing.Point(695, 270);
            this.lblJogadorVez.Name = "lblJogadorVez";
            this.lblJogadorVez.Size = new System.Drawing.Size(94, 13);
            this.lblJogadorVez.TabIndex = 56;
            this.lblJogadorVez.Text = "Nome do Jogador:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(714, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 57;
            this.button3.Text = "VerificarVez";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblJogadorDaVez
            // 
            this.lblJogadorDaVez.AutoSize = true;
            this.lblJogadorDaVez.Location = new System.Drawing.Point(793, 224);
            this.lblJogadorDaVez.Name = "lblJogadorDaVez";
            this.lblJogadorDaVez.Size = new System.Drawing.Size(0, 13);
            this.lblJogadorDaVez.TabIndex = 58;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(796, 269);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 59;
            // 
            // lblerros
            // 
            this.lblerros.AutoSize = true;
            this.lblerros.Location = new System.Drawing.Point(12, 369);
            this.lblerros.Name = "lblerros";
            this.lblerros.Size = new System.Drawing.Size(0, 13);
            this.lblerros.TabIndex = 60;
            // 
            // lblErroposicao
            // 
            this.lblErroposicao.AutoSize = true;
            this.lblErroposicao.Location = new System.Drawing.Point(763, 169);
            this.lblErroposicao.Name = "lblErroposicao";
            this.lblErroposicao.Size = new System.Drawing.Size(0, 13);
            this.lblErroposicao.TabIndex = 61;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(690, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 62;
            this.button4.Text = "Favorito";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnfavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 748);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblErroposicao);
            this.Controls.Add(this.lblerros);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblJogadorDaVez);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblJogadorVez);
            this.Controls.Add(this.lblIdVez);
            this.Controls.Add(this.btnPosicionar);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.txtPosicionarPersonagem);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.lblPersonagem);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblErroIniciar);
            this.Controls.Add(this.lbListaDePersonagens);
            this.Controls.Add(this.cbListarOpcoes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblFavoritos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.btnEntrarNaPartida);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSenhaEntrarPartida);
            this.Controls.Add(this.txtJogadorNome);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPartida);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblversao);
            this.Controls.Add(this.lblgrupo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbListarJogadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.lblidPartida);
            this.Controls.Add(this.lbPartidasListadas);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "btnfavoritos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbListaDePersonagens;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lbPartidasListadas;
        private System.Windows.Forms.Label lblidPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbListarJogadores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblgrupo;
        private System.Windows.Forms.Label lblversao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.TextBox txtJogadorNome;
        private System.Windows.Forms.TextBox txtSenhaEntrarPartida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEntrarNaPartida;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFavoritos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbListarOpcoes;
        private System.Windows.Forms.Label lblErroIniciar;
        private System.Windows.Forms.Label lblPersonagem;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.TextBox txtPosicionarPersonagem;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Button btnPosicionar;
        private System.Windows.Forms.Label lblIdVez;
        private System.Windows.Forms.Label lblJogadorVez;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblJogadorDaVez;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblerros;
        private System.Windows.Forms.Label lblErroposicao;
        private System.Windows.Forms.Button button4;
    }
}

