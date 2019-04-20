namespace SimuladorDeVidaCutuquense
{
    partial class frmCotuca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotuca));
            this.bkwEstudar = new System.ComponentModel.BackgroundWorker();
            this.bkwJogar = new System.ComponentModel.BackgroundWorker();
            this.tabCotuca2 = new System.Windows.Forms.TabPage();
            this.lbPreco8 = new System.Windows.Forms.Label();
            this.btnSeije = new System.Windows.Forms.Button();
            this.lbPreco7 = new System.Windows.Forms.Label();
            this.btnChico = new System.Windows.Forms.Button();
            this.lbPreco6 = new System.Windows.Forms.Label();
            this.btnVeteranos = new System.Windows.Forms.Button();
            this.lbPreco5 = new System.Windows.Forms.Label();
            this.btnEnzo = new System.Windows.Forms.Button();
            this.lbPreco4 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbPreco3 = new System.Windows.Forms.Label();
            this.btnArruda = new System.Windows.Forms.Button();
            this.lbPreco2 = new System.Windows.Forms.Label();
            this.btnGuerra = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbQuantidadeDeMoedas2 = new System.Windows.Forms.Label();
            this.lbPreco1 = new System.Windows.Forms.Label();
            this.btnAngelo = new System.Windows.Forms.Button();
            this.tabEscola = new System.Windows.Forms.TabPage();
            this.pbDarAula = new System.Windows.Forms.ProgressBar();
            this.btnDarAula = new System.Windows.Forms.Button();
            this.pbInstalar = new System.Windows.Forms.ProgressBar();
            this.btnInstalar = new System.Windows.Forms.Button();
            this.pbChifre = new System.Windows.Forms.ProgressBar();
            this.pbAssistir = new System.Windows.Forms.ProgressBar();
            this.btnAssistir = new System.Windows.Forms.Button();
            this.pbGadiar = new System.Windows.Forms.ProgressBar();
            this.btnGadiar = new System.Windows.Forms.Button();
            this.pbMatar = new System.Windows.Forms.ProgressBar();
            this.btnMatar = new System.Windows.Forms.Button();
            this.lbHack = new System.Windows.Forms.Label();
            this.pbEstudar = new System.Windows.Forms.ProgressBar();
            this.pbJogar = new System.Windows.Forms.ProgressBar();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnEstudar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbQuantidadeDeMoedas = new System.Windows.Forms.Label();
            this.tabCotuca = new System.Windows.Forms.TabControl();
            this.bkwMatar = new System.ComponentModel.BackgroundWorker();
            this.bkwGadiar = new System.ComponentModel.BackgroundWorker();
            this.bkwAssistir = new System.ComponentModel.BackgroundWorker();
            this.bkwChifre = new System.ComponentModel.BackgroundWorker();
            this.btnChifre = new System.Windows.Forms.Button();
            this.bkwInstalar = new System.ComponentModel.BackgroundWorker();
            this.tabCotuca2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabEscola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCotuca.SuspendLayout();
            this.SuspendLayout();
            // 
            // bkwEstudar
            // 
            this.bkwEstudar.WorkerReportsProgress = true;
            this.bkwEstudar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.bkwEstudar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.bkwEstudar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // bkwJogar
            // 
            this.bkwJogar.WorkerReportsProgress = true;
            this.bkwJogar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwJogar_DoWork);
            this.bkwJogar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkwJogar_ProgressChanged);
            this.bkwJogar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkwJogar_RunWorkerCompleted);
            // 
            // tabCotuca2
            // 
            this.tabCotuca2.Controls.Add(this.lbPreco8);
            this.tabCotuca2.Controls.Add(this.btnSeije);
            this.tabCotuca2.Controls.Add(this.lbPreco7);
            this.tabCotuca2.Controls.Add(this.btnChico);
            this.tabCotuca2.Controls.Add(this.lbPreco6);
            this.tabCotuca2.Controls.Add(this.btnVeteranos);
            this.tabCotuca2.Controls.Add(this.lbPreco5);
            this.tabCotuca2.Controls.Add(this.btnEnzo);
            this.tabCotuca2.Controls.Add(this.lbPreco4);
            this.tabCotuca2.Controls.Add(this.btnGo);
            this.tabCotuca2.Controls.Add(this.lbPreco3);
            this.tabCotuca2.Controls.Add(this.btnArruda);
            this.tabCotuca2.Controls.Add(this.lbPreco2);
            this.tabCotuca2.Controls.Add(this.btnGuerra);
            this.tabCotuca2.Controls.Add(this.pictureBox3);
            this.tabCotuca2.Controls.Add(this.lbQuantidadeDeMoedas2);
            this.tabCotuca2.Controls.Add(this.lbPreco1);
            this.tabCotuca2.Controls.Add(this.btnAngelo);
            this.tabCotuca2.Location = new System.Drawing.Point(4, 22);
            this.tabCotuca2.Name = "tabCotuca2";
            this.tabCotuca2.Padding = new System.Windows.Forms.Padding(3);
            this.tabCotuca2.Size = new System.Drawing.Size(846, 464);
            this.tabCotuca2.TabIndex = 1;
            this.tabCotuca2.Text = "Dompas";
            this.tabCotuca2.UseVisualStyleBackColor = true;
            // 
            // lbPreco8
            // 
            this.lbPreco8.AutoSize = true;
            this.lbPreco8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco8.Location = new System.Drawing.Point(549, 304);
            this.lbPreco8.Name = "lbPreco8";
            this.lbPreco8.Size = new System.Drawing.Size(158, 18);
            this.lbPreco8.TabIndex = 24;
            this.lbPreco8.Text = "100000 Cotucoin";
            this.lbPreco8.Visible = false;
            // 
            // btnSeije
            // 
            this.btnSeije.Location = new System.Drawing.Point(34, 115);
            this.btnSeije.Name = "btnSeije";
            this.btnSeije.Size = new System.Drawing.Size(91, 41);
            this.btnSeije.TabIndex = 23;
            this.btnSeije.Text = "Virar amigo do Seide";
            this.btnSeije.UseVisualStyleBackColor = true;
            this.btnSeije.Click += new System.EventHandler(this.btnSeije_Click);
            // 
            // lbPreco7
            // 
            this.lbPreco7.AutoSize = true;
            this.lbPreco7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco7.Location = new System.Drawing.Point(549, 245);
            this.lbPreco7.Name = "lbPreco7";
            this.lbPreco7.Size = new System.Drawing.Size(148, 18);
            this.lbPreco7.TabIndex = 22;
            this.lbPreco7.Text = "20000 Cotucoin";
            this.lbPreco7.Visible = false;
            // 
            // btnChico
            // 
            this.btnChico.Enabled = false;
            this.btnChico.Location = new System.Drawing.Point(452, 292);
            this.btnChico.Name = "btnChico";
            this.btnChico.Size = new System.Drawing.Size(91, 41);
            this.btnChico.TabIndex = 21;
            this.btnChico.Text = "Virar Amigo do Chico";
            this.btnChico.UseVisualStyleBackColor = true;
            this.btnChico.Visible = false;
            this.btnChico.Click += new System.EventHandler(this.btnChico_Click);
            // 
            // lbPreco6
            // 
            this.lbPreco6.AutoSize = true;
            this.lbPreco6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco6.Location = new System.Drawing.Point(549, 186);
            this.lbPreco6.Name = "lbPreco6";
            this.lbPreco6.Size = new System.Drawing.Size(138, 18);
            this.lbPreco6.TabIndex = 20;
            this.lbPreco6.Text = "5000 Cotucoin";
            this.lbPreco6.Visible = false;
            // 
            // btnVeteranos
            // 
            this.btnVeteranos.Enabled = false;
            this.btnVeteranos.Location = new System.Drawing.Point(452, 233);
            this.btnVeteranos.Name = "btnVeteranos";
            this.btnVeteranos.Size = new System.Drawing.Size(91, 41);
            this.btnVeteranos.TabIndex = 19;
            this.btnVeteranos.Text = "Virar Amigo dos veteranos";
            this.btnVeteranos.UseVisualStyleBackColor = true;
            this.btnVeteranos.Visible = false;
            this.btnVeteranos.Click += new System.EventHandler(this.btnVeteranos_Click);
            // 
            // lbPreco5
            // 
            this.lbPreco5.AutoSize = true;
            this.lbPreco5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco5.Location = new System.Drawing.Point(549, 127);
            this.lbPreco5.Name = "lbPreco5";
            this.lbPreco5.Size = new System.Drawing.Size(138, 18);
            this.lbPreco5.TabIndex = 18;
            this.lbPreco5.Text = "1000 Cotucoin";
            this.lbPreco5.Visible = false;
            // 
            // btnEnzo
            // 
            this.btnEnzo.Enabled = false;
            this.btnEnzo.Location = new System.Drawing.Point(452, 174);
            this.btnEnzo.Name = "btnEnzo";
            this.btnEnzo.Size = new System.Drawing.Size(91, 41);
            this.btnEnzo.TabIndex = 17;
            this.btnEnzo.Text = "Virar Amigo do Enzo";
            this.btnEnzo.UseVisualStyleBackColor = true;
            this.btnEnzo.Visible = false;
            this.btnEnzo.Click += new System.EventHandler(this.btnEnzo_Click);
            // 
            // lbPreco4
            // 
            this.lbPreco4.AutoSize = true;
            this.lbPreco4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco4.Location = new System.Drawing.Point(143, 304);
            this.lbPreco4.Name = "lbPreco4";
            this.lbPreco4.Size = new System.Drawing.Size(128, 18);
            this.lbPreco4.TabIndex = 16;
            this.lbPreco4.Text = "500 Cotucoin";
            this.lbPreco4.Visible = false;
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(452, 115);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(91, 41);
            this.btnGo.TabIndex = 15;
            this.btnGo.Text = "Virar Amigo do Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Visible = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbPreco3
            // 
            this.lbPreco3.AutoSize = true;
            this.lbPreco3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco3.Location = new System.Drawing.Point(143, 245);
            this.lbPreco3.Name = "lbPreco3";
            this.lbPreco3.Size = new System.Drawing.Size(128, 18);
            this.lbPreco3.TabIndex = 14;
            this.lbPreco3.Text = "100 Cotucoin";
            this.lbPreco3.Visible = false;
            // 
            // btnArruda
            // 
            this.btnArruda.Enabled = false;
            this.btnArruda.Location = new System.Drawing.Point(34, 292);
            this.btnArruda.Name = "btnArruda";
            this.btnArruda.Size = new System.Drawing.Size(91, 41);
            this.btnArruda.TabIndex = 13;
            this.btnArruda.Text = "Virar amigo do Arrudão";
            this.btnArruda.UseVisualStyleBackColor = true;
            this.btnArruda.Visible = false;
            this.btnArruda.Click += new System.EventHandler(this.btnArruda_Click);
            // 
            // lbPreco2
            // 
            this.lbPreco2.AutoSize = true;
            this.lbPreco2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco2.Location = new System.Drawing.Point(143, 186);
            this.lbPreco2.Name = "lbPreco2";
            this.lbPreco2.Size = new System.Drawing.Size(118, 18);
            this.lbPreco2.TabIndex = 12;
            this.lbPreco2.Text = "50 Cotucoin";
            this.lbPreco2.Visible = false;
            // 
            // btnGuerra
            // 
            this.btnGuerra.Enabled = false;
            this.btnGuerra.Location = new System.Drawing.Point(34, 233);
            this.btnGuerra.Name = "btnGuerra";
            this.btnGuerra.Size = new System.Drawing.Size(91, 41);
            this.btnGuerra.TabIndex = 11;
            this.btnGuerra.Text = "Virar amigo do Guerra";
            this.btnGuerra.UseVisualStyleBackColor = true;
            this.btnGuerra.Visible = false;
            this.btnGuerra.Click += new System.EventHandler(this.btnGuerra_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(161, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // lbQuantidadeDeMoedas2
            // 
            this.lbQuantidadeDeMoedas2.AutoSize = true;
            this.lbQuantidadeDeMoedas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeDeMoedas2.Location = new System.Drawing.Point(105, 39);
            this.lbQuantidadeDeMoedas2.Name = "lbQuantidadeDeMoedas2";
            this.lbQuantidadeDeMoedas2.Size = new System.Drawing.Size(20, 24);
            this.lbQuantidadeDeMoedas2.TabIndex = 9;
            this.lbQuantidadeDeMoedas2.Text = "0";
            // 
            // lbPreco1
            // 
            this.lbPreco1.AutoSize = true;
            this.lbPreco1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco1.Location = new System.Drawing.Point(143, 127);
            this.lbPreco1.Name = "lbPreco1";
            this.lbPreco1.Size = new System.Drawing.Size(118, 18);
            this.lbPreco1.TabIndex = 8;
            this.lbPreco1.Text = "10 Cotucoin";
            // 
            // btnAngelo
            // 
            this.btnAngelo.Enabled = false;
            this.btnAngelo.Location = new System.Drawing.Point(34, 174);
            this.btnAngelo.Name = "btnAngelo";
            this.btnAngelo.Size = new System.Drawing.Size(91, 41);
            this.btnAngelo.TabIndex = 7;
            this.btnAngelo.Text = "Virar amigo do Ângelo";
            this.btnAngelo.UseVisualStyleBackColor = true;
            this.btnAngelo.Visible = false;
            this.btnAngelo.Click += new System.EventHandler(this.VirarAmigo1_Click);
            // 
            // tabEscola
            // 
            this.tabEscola.Controls.Add(this.pbDarAula);
            this.tabEscola.Controls.Add(this.btnDarAula);
            this.tabEscola.Controls.Add(this.pbInstalar);
            this.tabEscola.Controls.Add(this.btnInstalar);
            this.tabEscola.Controls.Add(this.pbChifre);
            this.tabEscola.Controls.Add(this.btnChifre);
            this.tabEscola.Controls.Add(this.pbAssistir);
            this.tabEscola.Controls.Add(this.btnAssistir);
            this.tabEscola.Controls.Add(this.pbGadiar);
            this.tabEscola.Controls.Add(this.btnGadiar);
            this.tabEscola.Controls.Add(this.pbMatar);
            this.tabEscola.Controls.Add(this.btnMatar);
            this.tabEscola.Controls.Add(this.lbHack);
            this.tabEscola.Controls.Add(this.pbEstudar);
            this.tabEscola.Controls.Add(this.pbJogar);
            this.tabEscola.Controls.Add(this.btnJogar);
            this.tabEscola.Controls.Add(this.btnEstudar);
            this.tabEscola.Controls.Add(this.pictureBox1);
            this.tabEscola.Controls.Add(this.lbQuantidadeDeMoedas);
            this.tabEscola.Location = new System.Drawing.Point(4, 22);
            this.tabEscola.Name = "tabEscola";
            this.tabEscola.Padding = new System.Windows.Forms.Padding(3);
            this.tabEscola.Size = new System.Drawing.Size(846, 464);
            this.tabEscola.TabIndex = 0;
            this.tabEscola.Text = "Cotuca";
            this.tabEscola.UseVisualStyleBackColor = true;
            // 
            // pbDarAula
            // 
            this.pbDarAula.Enabled = false;
            this.pbDarAula.Location = new System.Drawing.Point(540, 312);
            this.pbDarAula.Maximum = 35;
            this.pbDarAula.Name = "pbDarAula";
            this.pbDarAula.Size = new System.Drawing.Size(192, 48);
            this.pbDarAula.TabIndex = 23;
            this.pbDarAula.Visible = false;
            // 
            // btnDarAula
            // 
            this.btnDarAula.Enabled = false;
            this.btnDarAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarAula.Location = new System.Drawing.Point(445, 312);
            this.btnDarAula.Name = "btnDarAula";
            this.btnDarAula.Size = new System.Drawing.Size(89, 48);
            this.btnDarAula.TabIndex = 22;
            this.btnDarAula.Text = "Dar Aula";
            this.btnDarAula.UseVisualStyleBackColor = true;
            this.btnDarAula.Visible = false;
            // 
            // pbInstalar
            // 
            this.pbInstalar.Enabled = false;
            this.pbInstalar.Location = new System.Drawing.Point(540, 244);
            this.pbInstalar.Maximum = 90;
            this.pbInstalar.Name = "pbInstalar";
            this.pbInstalar.Size = new System.Drawing.Size(192, 48);
            this.pbInstalar.TabIndex = 21;
            this.pbInstalar.Visible = false;
            // 
            // btnInstalar
            // 
            this.btnInstalar.Enabled = false;
            this.btnInstalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstalar.Location = new System.Drawing.Point(445, 244);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(89, 48);
            this.btnInstalar.TabIndex = 20;
            this.btnInstalar.Text = "Instalar LUL na pública";
            this.btnInstalar.UseVisualStyleBackColor = true;
            this.btnInstalar.Visible = false;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // pbChifre
            // 
            this.pbChifre.Enabled = false;
            this.pbChifre.Location = new System.Drawing.Point(540, 176);
            this.pbChifre.Maximum = 60;
            this.pbChifre.Name = "pbChifre";
            this.pbChifre.Size = new System.Drawing.Size(192, 48);
            this.pbChifre.TabIndex = 19;
            this.pbChifre.Visible = false;
            // 
            // pbAssistir
            // 
            this.pbAssistir.Enabled = false;
            this.pbAssistir.Location = new System.Drawing.Point(540, 108);
            this.pbAssistir.Maximum = 45;
            this.pbAssistir.Name = "pbAssistir";
            this.pbAssistir.Size = new System.Drawing.Size(192, 48);
            this.pbAssistir.TabIndex = 17;
            this.pbAssistir.Visible = false;
            // 
            // btnAssistir
            // 
            this.btnAssistir.Enabled = false;
            this.btnAssistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssistir.Location = new System.Drawing.Point(445, 108);
            this.btnAssistir.Name = "btnAssistir";
            this.btnAssistir.Size = new System.Drawing.Size(89, 48);
            this.btnAssistir.TabIndex = 16;
            this.btnAssistir.Text = "Assistir hentai dorante a aula";
            this.btnAssistir.UseVisualStyleBackColor = true;
            this.btnAssistir.Visible = false;
            this.btnAssistir.Click += new System.EventHandler(this.btnAssistir_Click);
            // 
            // pbGadiar
            // 
            this.pbGadiar.Enabled = false;
            this.pbGadiar.Location = new System.Drawing.Point(134, 312);
            this.pbGadiar.Maximum = 35;
            this.pbGadiar.Name = "pbGadiar";
            this.pbGadiar.Size = new System.Drawing.Size(192, 48);
            this.pbGadiar.TabIndex = 15;
            this.pbGadiar.Visible = false;
            // 
            // btnGadiar
            // 
            this.btnGadiar.Enabled = false;
            this.btnGadiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGadiar.Location = new System.Drawing.Point(39, 312);
            this.btnGadiar.Name = "btnGadiar";
            this.btnGadiar.Size = new System.Drawing.Size(89, 48);
            this.btnGadiar.TabIndex = 14;
            this.btnGadiar.Text = "Gadiar em horário de aula";
            this.btnGadiar.UseVisualStyleBackColor = true;
            this.btnGadiar.Visible = false;
            this.btnGadiar.Click += new System.EventHandler(this.btnGadiar_Click);
            // 
            // pbMatar
            // 
            this.pbMatar.Enabled = false;
            this.pbMatar.Location = new System.Drawing.Point(134, 244);
            this.pbMatar.Maximum = 20;
            this.pbMatar.Name = "pbMatar";
            this.pbMatar.Size = new System.Drawing.Size(192, 48);
            this.pbMatar.TabIndex = 13;
            this.pbMatar.Visible = false;
            // 
            // btnMatar
            // 
            this.btnMatar.Enabled = false;
            this.btnMatar.Location = new System.Drawing.Point(39, 244);
            this.btnMatar.Name = "btnMatar";
            this.btnMatar.Size = new System.Drawing.Size(89, 48);
            this.btnMatar.TabIndex = 12;
            this.btnMatar.Text = "Matar Aula";
            this.btnMatar.UseVisualStyleBackColor = true;
            this.btnMatar.Visible = false;
            this.btnMatar.Click += new System.EventHandler(this.btnMatar_Click);
            // 
            // lbHack
            // 
            this.lbHack.AutoSize = true;
            this.lbHack.Location = new System.Drawing.Point(773, 3);
            this.lbHack.Name = "lbHack";
            this.lbHack.Size = new System.Drawing.Size(73, 13);
            this.lbHack.TabIndex = 11;
            this.lbHack.Text = "                      ";
            this.lbHack.Click += new System.EventHandler(this.lbHack_Click);
            // 
            // pbEstudar
            // 
            this.pbEstudar.Location = new System.Drawing.Point(134, 108);
            this.pbEstudar.Maximum = 10;
            this.pbEstudar.Name = "pbEstudar";
            this.pbEstudar.Size = new System.Drawing.Size(192, 48);
            this.pbEstudar.TabIndex = 9;
            // 
            // pbJogar
            // 
            this.pbJogar.Enabled = false;
            this.pbJogar.Location = new System.Drawing.Point(134, 176);
            this.pbJogar.Maximum = 15;
            this.pbJogar.Name = "pbJogar";
            this.pbJogar.Size = new System.Drawing.Size(192, 48);
            this.pbJogar.TabIndex = 8;
            this.pbJogar.Visible = false;
            // 
            // btnJogar
            // 
            this.btnJogar.Enabled = false;
            this.btnJogar.Location = new System.Drawing.Point(39, 176);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(89, 48);
            this.btnJogar.TabIndex = 7;
            this.btnJogar.Text = "Jogar na Aula";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Visible = false;
            this.btnJogar.Click += new System.EventHandler(this.btnDormir_Click);
            // 
            // btnEstudar
            // 
            this.btnEstudar.Location = new System.Drawing.Point(39, 108);
            this.btnEstudar.Name = "btnEstudar";
            this.btnEstudar.Size = new System.Drawing.Size(89, 48);
            this.btnEstudar.TabIndex = 5;
            this.btnEstudar.TabStop = false;
            this.btnEstudar.Text = "Estudar";
            this.btnEstudar.UseVisualStyleBackColor = true;
            this.btnEstudar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbQuantidadeDeMoedas
            // 
            this.lbQuantidadeDeMoedas.AutoSize = true;
            this.lbQuantidadeDeMoedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeDeMoedas.Location = new System.Drawing.Point(105, 40);
            this.lbQuantidadeDeMoedas.Name = "lbQuantidadeDeMoedas";
            this.lbQuantidadeDeMoedas.Size = new System.Drawing.Size(20, 24);
            this.lbQuantidadeDeMoedas.TabIndex = 3;
            this.lbQuantidadeDeMoedas.Text = "0";
            // 
            // tabCotuca
            // 
            this.tabCotuca.AccessibleName = "";
            this.tabCotuca.Controls.Add(this.tabEscola);
            this.tabCotuca.Controls.Add(this.tabCotuca2);
            this.tabCotuca.Location = new System.Drawing.Point(0, 1);
            this.tabCotuca.Name = "tabCotuca";
            this.tabCotuca.SelectedIndex = 0;
            this.tabCotuca.Size = new System.Drawing.Size(854, 490);
            this.tabCotuca.TabIndex = 2;
            this.tabCotuca.SelectedIndexChanged += new System.EventHandler(this.l_SelectedIndexChanged);
            // 
            // bkwMatar
            // 
            this.bkwMatar.WorkerReportsProgress = true;
            this.bkwMatar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwMatar_DoWork);
            this.bkwMatar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkwMatar_ProgressChanged);
            this.bkwMatar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkwMatar_RunWorkerCompleted);
            // 
            // bkwGadiar
            // 
            this.bkwGadiar.WorkerReportsProgress = true;
            this.bkwGadiar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwGadiar_DoWork);
            this.bkwGadiar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkwGadiar_ProgressChanged);
            this.bkwGadiar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkwGadiar_RunWorkerCompleted);
            // 
            // bkwAssistir
            // 
            this.bkwAssistir.WorkerReportsProgress = true;
            this.bkwAssistir.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwAssistir_DoWork);
            this.bkwAssistir.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkwAssistir_ProgressChanged);
            this.bkwAssistir.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkwAssistir_RunWorkerCompleted);
            // 
            // bkwChifre
            // 
            this.bkwChifre.WorkerReportsProgress = true;
            this.bkwChifre.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwChifre_DoWork);
            this.bkwChifre.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkwChifre_ProgressChanged);
            this.bkwChifre.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkwChifre_RunWorkerCompleted);
            // 
            // btnChifre
            // 
            this.btnChifre.Enabled = false;
            this.btnChifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChifre.Location = new System.Drawing.Point(445, 176);
            this.btnChifre.Name = "btnChifre";
            this.btnChifre.Size = new System.Drawing.Size(89, 48);
            this.btnChifre.TabIndex = 18;
            this.btnChifre.Text = "Ser chifrado durante a aula";
            this.btnChifre.UseVisualStyleBackColor = true;
            this.btnChifre.Visible = false;
            this.btnChifre.Click += new System.EventHandler(this.btnChifre_Click);
            // 
            // bkwInstalar
            // 
            this.bkwInstalar.WorkerReportsProgress = true;
            this.bkwInstalar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkwInstalar_DoWork);
            this.bkwInstalar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkwInstalar_ProgressChanged);
            this.bkwInstalar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkwInstalar_RunWorkerCompleted);
            // 
            // frmCotuca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCotuca);
            this.Name = "frmCotuca";
            this.Text = "Simulador";
            this.tabCotuca2.ResumeLayout(false);
            this.tabCotuca2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabEscola.ResumeLayout(false);
            this.tabEscola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCotuca.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bkwEstudar;
        private System.ComponentModel.BackgroundWorker bkwJogar;
        private System.Windows.Forms.TabPage tabCotuca2;
        private System.Windows.Forms.Label lbPreco2;
        private System.Windows.Forms.Button btnGuerra;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbQuantidadeDeMoedas2;
        private System.Windows.Forms.Label lbPreco1;
        private System.Windows.Forms.Button btnAngelo;
        private System.Windows.Forms.TabPage tabEscola;
        private System.Windows.Forms.ProgressBar pbMatar;
        private System.Windows.Forms.Button btnMatar;
        private System.Windows.Forms.Label lbHack;
        private System.Windows.Forms.ProgressBar pbEstudar;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnEstudar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbQuantidadeDeMoedas;
        private System.Windows.Forms.TabControl tabCotuca;
        private System.ComponentModel.BackgroundWorker bkwMatar;
        private System.Windows.Forms.ProgressBar pbJogar;
        private System.Windows.Forms.Label lbPreco3;
        private System.Windows.Forms.Button btnArruda;
        private System.Windows.Forms.ProgressBar pbGadiar;
        private System.Windows.Forms.Button btnGadiar;
        private System.ComponentModel.BackgroundWorker bkwGadiar;
        private System.Windows.Forms.Label lbPreco4;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ProgressBar pbAssistir;
        private System.Windows.Forms.Button btnAssistir;
        private System.ComponentModel.BackgroundWorker bkwAssistir;
        private System.Windows.Forms.Label lbPreco6;
        private System.Windows.Forms.Button btnVeteranos;
        private System.Windows.Forms.Label lbPreco5;
        private System.Windows.Forms.Button btnEnzo;
        private System.Windows.Forms.ProgressBar pbDarAula;
        private System.Windows.Forms.Button btnDarAula;
        private System.Windows.Forms.ProgressBar pbInstalar;
        private System.Windows.Forms.Button btnInstalar;
        private System.Windows.Forms.ProgressBar pbChifre;
        private System.Windows.Forms.Label lbPreco8;
        private System.Windows.Forms.Button btnSeije;
        private System.Windows.Forms.Label lbPreco7;
        private System.Windows.Forms.Button btnChico;
        private System.ComponentModel.BackgroundWorker bkwChifre;
        private System.Windows.Forms.Button btnChifre;
        private System.ComponentModel.BackgroundWorker bkwInstalar;
    }
}

