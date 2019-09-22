namespace NIvelman
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslVrstaIzjednacenja = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSigmaKvadrat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSigma = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSo2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssln = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslu = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssld = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslf = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslGlobalniTest = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbGlobalniAlfa = new System.Windows.Forms.TextBox();
            this.lblGlobalniAlfa = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbLokalniBeta = new System.Windows.Forms.TextBox();
            this.tbLokalniAlfa = new System.Windows.Forms.TextBox();
            this.lblLokalniBeta = new System.Windows.Forms.Label();
            this.lblLokalniAlfa = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnIzjednaci = new System.Windows.Forms.Button();
            this.btnFormirajMatrice = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbTolerancija = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSigmaNulaKvadrat = new System.Windows.Forms.TextBox();
            this.tbSigmaNula = new System.Windows.Forms.TextBox();
            this.lblSigmaNulaKvadrat = new System.Windows.Forms.Label();
            this.lblSigmaNula = new System.Windows.Forms.Label();
            this.gbVrstaIzjednacenja = new System.Windows.Forms.GroupBox();
            this.rbIzjednacenjePrisila = new System.Windows.Forms.RadioButton();
            this.rbKlasicanNacin = new System.Windows.Forms.RadioButton();
            this.rbParcijalniMinimalniTrag = new System.Windows.Forms.RadioButton();
            this.rbMinimalniTrag = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpOsnovno = new System.Windows.Forms.TabPage();
            this.scOsnovno = new System.Windows.Forms.SplitContainer();
            this.gbTocke = new System.Windows.Forms.GroupBox();
            this.lvTocke = new System.Windows.Forms.ListView();
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tocka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.visina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbUnosTocke = new System.Windows.Forms.GroupBox();
            this.btnDodajTocku = new System.Windows.Forms.Button();
            this.tbVisina = new System.Windows.Forms.TextBox();
            this.tbTocka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvMjerenje = new System.Windows.Forms.ListView();
            this.kontrola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.od = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.do1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.f = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tezina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mjerenje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.izracunato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.udaljenost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.varijanca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDodajMjerenje = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTezina = new System.Windows.Forms.TextBox();
            this.tbPPM = new System.Windows.Forms.TextBox();
            this.tbMM = new System.Windows.Forms.TextBox();
            this.rbTezina = new System.Windows.Forms.RadioButton();
            this.rbTezinaPpm = new System.Windows.Forms.RadioButton();
            this.rbTezinaSqrtD = new System.Windows.Forms.RadioButton();
            this.rbTezinaD = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUdaljenost = new System.Windows.Forms.TextBox();
            this.tbMjerenje = new System.Windows.Forms.TextBox();
            this.cmbDo = new System.Windows.Forms.ComboBox();
            this.cmbOd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvA = new System.Windows.Forms.ListView();
            this.tpP = new System.Windows.Forms.TabPage();
            this.lvP = new System.Windows.Forms.ListView();
            this.tpF = new System.Windows.Forms.TabPage();
            this.lvF = new System.Windows.Forms.ListView();
            this.tpG = new System.Windows.Forms.TabPage();
            this.lvG = new System.Windows.Forms.ListView();
            this.tpIzjednacenje = new System.Windows.Forms.TabPage();
            this.tcIzjednacenje = new System.Windows.Forms.TabControl();
            this.tpOcjenaFunkcija = new System.Windows.Forms.TabPage();
            this.lvOcjenaFunkcija = new System.Windows.Forms.ListView();
            this.funkcija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ocjeniva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.var = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stDev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpIzjednaceneVelicine = new System.Windows.Forms.TabPage();
            this.tcIzjednaceneVrijednosti = new System.Windows.Forms.TabControl();
            this.tpMjerenja = new System.Windows.Forms.TabPage();
            this.lvIzjednacenaMjerenja = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpReperi = new System.Windows.Forms.TabPage();
            this.lvReperi = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpStatistika = new System.Windows.Forms.TabPage();
            this.lvStatistika = new System.Windows.Forms.ListView();
            this.izmjeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLvTocke = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsLvMjerenje = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.izmjeniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrisiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbVrstaIzjednacenja.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpOsnovno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scOsnovno)).BeginInit();
            this.scOsnovno.Panel1.SuspendLayout();
            this.scOsnovno.Panel2.SuspendLayout();
            this.scOsnovno.SuspendLayout();
            this.gbTocke.SuspendLayout();
            this.gbUnosTocke.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tpP.SuspendLayout();
            this.tpF.SuspendLayout();
            this.tpG.SuspendLayout();
            this.tpIzjednacenje.SuspendLayout();
            this.tpOcjenaFunkcija.SuspendLayout();
            this.tpIzjednaceneVelicine.SuspendLayout();
            this.tcIzjednaceneVrijednosti.SuspendLayout();
            this.tpMjerenja.SuspendLayout();
            this.tpReperi.SuspendLayout();
            this.tpStatistika.SuspendLayout();
            this.cmsLvTocke.SuspendLayout();
            this.cmsLvMjerenje.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVrstaIzjednacenja,
            this.tsslSigmaKvadrat,
            this.tsslSigma,
            this.tsslSo2,
            this.tsslSo,
            this.tssln,
            this.tsslu,
            this.tssld,
            this.tsslf,
            this.tsslGlobalniTest});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(884, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslVrstaIzjednacenja
            // 
            this.tsslVrstaIzjednacenja.Name = "tsslVrstaIzjednacenja";
            this.tsslVrstaIzjednacenja.Size = new System.Drawing.Size(101, 17);
            this.tsslVrstaIzjednacenja.Text = "Vrsta izjednacenja";
            // 
            // tsslSigmaKvadrat
            // 
            this.tsslSigmaKvadrat.Name = "tsslSigmaKvadrat";
            this.tsslSigmaKvadrat.Size = new System.Drawing.Size(80, 17);
            this.tsslSigmaKvadrat.Text = "SigmaKvadrat";
            // 
            // tsslSigma
            // 
            this.tsslSigma.Name = "tsslSigma";
            this.tsslSigma.Size = new System.Drawing.Size(39, 17);
            this.tsslSigma.Text = "sigma";
            // 
            // tsslSo2
            // 
            this.tsslSo2.Name = "tsslSo2";
            this.tsslSo2.Size = new System.Drawing.Size(26, 17);
            this.tsslSo2.Text = "So2";
            // 
            // tsslSo
            // 
            this.tsslSo.Name = "tsslSo";
            this.tsslSo.Size = new System.Drawing.Size(20, 17);
            this.tsslSo.Text = "So";
            // 
            // tssln
            // 
            this.tssln.Name = "tssln";
            this.tssln.Size = new System.Drawing.Size(14, 17);
            this.tssln.Text = "n";
            // 
            // tsslu
            // 
            this.tsslu.Name = "tsslu";
            this.tsslu.Size = new System.Drawing.Size(14, 17);
            this.tsslu.Text = "u";
            // 
            // tssld
            // 
            this.tssld.Name = "tssld";
            this.tssld.Size = new System.Drawing.Size(14, 17);
            this.tssld.Text = "d";
            // 
            // tsslf
            // 
            this.tsslf.Name = "tsslf";
            this.tsslf.Size = new System.Drawing.Size(11, 17);
            this.tsslf.Text = "f";
            // 
            // tsslGlobalniTest
            // 
            this.tsslGlobalniTest.Name = "tsslGlobalniTest";
            this.tsslGlobalniTest.Size = new System.Drawing.Size(73, 17);
            this.tsslGlobalniTest.Text = "Globalni test";
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBox9);
            this.splitContainer.Panel1.Controls.Add(this.groupBox8);
            this.splitContainer.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer.Panel1.Controls.Add(this.gbVrstaIzjednacenja);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            this.splitContainer.Size = new System.Drawing.Size(884, 516);
            this.splitContainer.SplitterDistance = 197;
            this.splitContainer.TabIndex = 2;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox9.Controls.Add(this.tbGlobalniAlfa);
            this.groupBox9.Controls.Add(this.lblGlobalniAlfa);
            this.groupBox9.Location = new System.Drawing.Point(12, 309);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(163, 48);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Globalni test";
            // 
            // tbGlobalniAlfa
            // 
            this.tbGlobalniAlfa.Location = new System.Drawing.Point(50, 19);
            this.tbGlobalniAlfa.Name = "tbGlobalniAlfa";
            this.tbGlobalniAlfa.Size = new System.Drawing.Size(53, 20);
            this.tbGlobalniAlfa.TabIndex = 0;
            this.tbGlobalniAlfa.Text = "5";
            this.tbGlobalniAlfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGlobalniAlfa_KeyPress);
            // 
            // lblGlobalniAlfa
            // 
            this.lblGlobalniAlfa.AutoSize = true;
            this.lblGlobalniAlfa.Location = new System.Drawing.Point(28, 22);
            this.lblGlobalniAlfa.Name = "lblGlobalniAlfa";
            this.lblGlobalniAlfa.Size = new System.Drawing.Size(16, 13);
            this.lblGlobalniAlfa.TabIndex = 0;
            this.lblGlobalniAlfa.Text = "a:";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox8.Controls.Add(this.tbLokalniBeta);
            this.groupBox8.Controls.Add(this.tbLokalniAlfa);
            this.groupBox8.Controls.Add(this.lblLokalniBeta);
            this.groupBox8.Controls.Add(this.lblLokalniAlfa);
            this.groupBox8.Location = new System.Drawing.Point(12, 363);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(163, 48);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Lokalni test";
            // 
            // tbLokalniBeta
            // 
            this.tbLokalniBeta.Location = new System.Drawing.Point(109, 19);
            this.tbLokalniBeta.Name = "tbLokalniBeta";
            this.tbLokalniBeta.Size = new System.Drawing.Size(33, 20);
            this.tbLokalniBeta.TabIndex = 2;
            this.tbLokalniBeta.Text = "80";
            this.tbLokalniBeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLokalniBeta_KeyPress);
            // 
            // tbLokalniAlfa
            // 
            this.tbLokalniAlfa.Location = new System.Drawing.Point(47, 19);
            this.tbLokalniAlfa.Name = "tbLokalniAlfa";
            this.tbLokalniAlfa.Size = new System.Drawing.Size(33, 20);
            this.tbLokalniAlfa.TabIndex = 0;
            this.tbLokalniAlfa.Text = "5";
            this.tbLokalniAlfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLokalniAlfa_KeyPress);
            // 
            // lblLokalniBeta
            // 
            this.lblLokalniBeta.AutoSize = true;
            this.lblLokalniBeta.Location = new System.Drawing.Point(87, 22);
            this.lblLokalniBeta.Name = "lblLokalniBeta";
            this.lblLokalniBeta.Size = new System.Drawing.Size(16, 13);
            this.lblLokalniBeta.TabIndex = 1;
            this.lblLokalniBeta.Text = "b:";
            // 
            // lblLokalniAlfa
            // 
            this.lblLokalniAlfa.AutoSize = true;
            this.lblLokalniAlfa.Location = new System.Drawing.Point(25, 22);
            this.lblLokalniAlfa.Name = "lblLokalniAlfa";
            this.lblLokalniAlfa.Size = new System.Drawing.Size(16, 13);
            this.lblLokalniAlfa.TabIndex = 0;
            this.lblLokalniAlfa.Text = "a:";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox7.Controls.Add(this.btnIzjednaci);
            this.groupBox7.Controls.Add(this.btnFormirajMatrice);
            this.groupBox7.Location = new System.Drawing.Point(12, 417);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 81);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Izjednačenje";
            // 
            // btnIzjednaci
            // 
            this.btnIzjednaci.Enabled = false;
            this.btnIzjednaci.Location = new System.Drawing.Point(6, 48);
            this.btnIzjednaci.Name = "btnIzjednaci";
            this.btnIzjednaci.Size = new System.Drawing.Size(151, 23);
            this.btnIzjednaci.TabIndex = 2;
            this.btnIzjednaci.Text = "Pokretanje izjednačenja";
            this.btnIzjednaci.UseVisualStyleBackColor = true;
            this.btnIzjednaci.Click += new System.EventHandler(this.btnIzjednaci_Click);
            // 
            // btnFormirajMatrice
            // 
            this.btnFormirajMatrice.Location = new System.Drawing.Point(6, 19);
            this.btnFormirajMatrice.Name = "btnFormirajMatrice";
            this.btnFormirajMatrice.Size = new System.Drawing.Size(151, 23);
            this.btnFormirajMatrice.TabIndex = 1;
            this.btnFormirajMatrice.Text = "Formiranje matrica";
            this.btnFormirajMatrice.UseVisualStyleBackColor = true;
            this.btnFormirajMatrice.Click += new System.EventHandler(this.btnFormirajMatrice_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.tbTolerancija);
            this.groupBox3.Location = new System.Drawing.Point(12, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 51);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tolerancija na grube greške";
            // 
            // tbTolerancija
            // 
            this.tbTolerancija.Location = new System.Drawing.Point(30, 19);
            this.tbTolerancija.Name = "tbTolerancija";
            this.tbTolerancija.Size = new System.Drawing.Size(100, 20);
            this.tbTolerancija.TabIndex = 1;
            this.tbTolerancija.Text = "5";
            this.tbTolerancija.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTolerancija_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.tbSigmaNulaKvadrat);
            this.groupBox2.Controls.Add(this.tbSigmaNula);
            this.groupBox2.Controls.Add(this.lblSigmaNulaKvadrat);
            this.groupBox2.Controls.Add(this.lblSigmaNula);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A priori";
            // 
            // tbSigmaNulaKvadrat
            // 
            this.tbSigmaNulaKvadrat.Location = new System.Drawing.Point(36, 51);
            this.tbSigmaNulaKvadrat.Name = "tbSigmaNulaKvadrat";
            this.tbSigmaNulaKvadrat.Size = new System.Drawing.Size(94, 20);
            this.tbSigmaNulaKvadrat.TabIndex = 2;
            this.tbSigmaNulaKvadrat.Text = "1";
            this.tbSigmaNulaKvadrat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSigmaNulaKvadrat_KeyPress);
            this.tbSigmaNulaKvadrat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSigmaNulaKvadrat_KeyUp);
            // 
            // tbSigmaNula
            // 
            this.tbSigmaNula.Location = new System.Drawing.Point(36, 25);
            this.tbSigmaNula.Name = "tbSigmaNula";
            this.tbSigmaNula.Size = new System.Drawing.Size(94, 20);
            this.tbSigmaNula.TabIndex = 0;
            this.tbSigmaNula.Text = "1";
            this.tbSigmaNula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSigmaNula_KeyPress);
            this.tbSigmaNula.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSigmaNula_KeyUp);
            // 
            // lblSigmaNulaKvadrat
            // 
            this.lblSigmaNulaKvadrat.AutoSize = true;
            this.lblSigmaNulaKvadrat.Location = new System.Drawing.Point(6, 54);
            this.lblSigmaNulaKvadrat.Name = "lblSigmaNulaKvadrat";
            this.lblSigmaNulaKvadrat.Size = new System.Drawing.Size(24, 13);
            this.lblSigmaNulaKvadrat.TabIndex = 1;
            this.lblSigmaNulaKvadrat.Text = "s02";
            // 
            // lblSigmaNula
            // 
            this.lblSigmaNula.AutoSize = true;
            this.lblSigmaNula.Location = new System.Drawing.Point(6, 28);
            this.lblSigmaNula.Name = "lblSigmaNula";
            this.lblSigmaNula.Size = new System.Drawing.Size(18, 13);
            this.lblSigmaNula.TabIndex = 0;
            this.lblSigmaNula.Text = "s0";
            // 
            // gbVrstaIzjednacenja
            // 
            this.gbVrstaIzjednacenja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbVrstaIzjednacenja.Controls.Add(this.rbIzjednacenjePrisila);
            this.gbVrstaIzjednacenja.Controls.Add(this.rbKlasicanNacin);
            this.gbVrstaIzjednacenja.Controls.Add(this.rbParcijalniMinimalniTrag);
            this.gbVrstaIzjednacenja.Controls.Add(this.rbMinimalniTrag);
            this.gbVrstaIzjednacenja.Location = new System.Drawing.Point(12, 15);
            this.gbVrstaIzjednacenja.Name = "gbVrstaIzjednacenja";
            this.gbVrstaIzjednacenja.Size = new System.Drawing.Size(163, 139);
            this.gbVrstaIzjednacenja.TabIndex = 0;
            this.gbVrstaIzjednacenja.TabStop = false;
            this.gbVrstaIzjednacenja.Text = "Vrsta izjednačenja";
            // 
            // rbIzjednacenjePrisila
            // 
            this.rbIzjednacenjePrisila.AutoSize = true;
            this.rbIzjednacenjePrisila.Location = new System.Drawing.Point(6, 97);
            this.rbIzjednacenjePrisila.Name = "rbIzjednacenjePrisila";
            this.rbIzjednacenjePrisila.Size = new System.Drawing.Size(124, 17);
            this.rbIzjednacenjePrisila.TabIndex = 2;
            this.rbIzjednacenjePrisila.Text = "Izjednačnje s prisilom";
            this.rbIzjednacenjePrisila.UseVisualStyleBackColor = true;
            this.rbIzjednacenjePrisila.CheckedChanged += new System.EventHandler(this.rbIzjednacenjePrisila_CheckedChanged);
            // 
            // rbKlasicanNacin
            // 
            this.rbKlasicanNacin.AutoSize = true;
            this.rbKlasicanNacin.Location = new System.Drawing.Point(6, 74);
            this.rbKlasicanNacin.Name = "rbKlasicanNacin";
            this.rbKlasicanNacin.Size = new System.Drawing.Size(94, 17);
            this.rbKlasicanNacin.TabIndex = 1;
            this.rbKlasicanNacin.Text = "Klasičan način";
            this.rbKlasicanNacin.UseVisualStyleBackColor = true;
            this.rbKlasicanNacin.CheckedChanged += new System.EventHandler(this.rbKlasicanNacin_CheckedChanged);
            // 
            // rbParcijalniMinimalniTrag
            // 
            this.rbParcijalniMinimalniTrag.AutoSize = true;
            this.rbParcijalniMinimalniTrag.Location = new System.Drawing.Point(6, 51);
            this.rbParcijalniMinimalniTrag.Name = "rbParcijalniMinimalniTrag";
            this.rbParcijalniMinimalniTrag.Size = new System.Drawing.Size(133, 17);
            this.rbParcijalniMinimalniTrag.TabIndex = 0;
            this.rbParcijalniMinimalniTrag.Text = "Parcijalni minimalni trag";
            this.rbParcijalniMinimalniTrag.UseVisualStyleBackColor = true;
            this.rbParcijalniMinimalniTrag.CheckedChanged += new System.EventHandler(this.rbParcijalniMinimalniTrag_CheckedChanged);
            // 
            // rbMinimalniTrag
            // 
            this.rbMinimalniTrag.AutoSize = true;
            this.rbMinimalniTrag.Checked = true;
            this.rbMinimalniTrag.Location = new System.Drawing.Point(6, 28);
            this.rbMinimalniTrag.Name = "rbMinimalniTrag";
            this.rbMinimalniTrag.Size = new System.Drawing.Size(89, 17);
            this.rbMinimalniTrag.TabIndex = 0;
            this.rbMinimalniTrag.TabStop = true;
            this.rbMinimalniTrag.Text = "Minimalni trag";
            this.rbMinimalniTrag.UseVisualStyleBackColor = true;
            this.rbMinimalniTrag.CheckedChanged += new System.EventHandler(this.rbMinimalniTrag_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpOsnovno);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tpP);
            this.tabControl.Controls.Add(this.tpF);
            this.tabControl.Controls.Add(this.tpG);
            this.tabControl.Controls.Add(this.tpIzjednacenje);
            this.tabControl.Controls.Add(this.tpOcjenaFunkcija);
            this.tabControl.Controls.Add(this.tpIzjednaceneVelicine);
            this.tabControl.Controls.Add(this.tpStatistika);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(683, 516);
            this.tabControl.TabIndex = 0;
            // 
            // tpOsnovno
            // 
            this.tpOsnovno.Controls.Add(this.scOsnovno);
            this.tpOsnovno.Location = new System.Drawing.Point(4, 22);
            this.tpOsnovno.Name = "tpOsnovno";
            this.tpOsnovno.Padding = new System.Windows.Forms.Padding(3);
            this.tpOsnovno.Size = new System.Drawing.Size(675, 490);
            this.tpOsnovno.TabIndex = 0;
            this.tpOsnovno.Text = "Osnovno";
            this.tpOsnovno.UseVisualStyleBackColor = true;
            // 
            // scOsnovno
            // 
            this.scOsnovno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scOsnovno.Location = new System.Drawing.Point(3, 3);
            this.scOsnovno.Name = "scOsnovno";
            // 
            // scOsnovno.Panel1
            // 
            this.scOsnovno.Panel1.Controls.Add(this.gbTocke);
            this.scOsnovno.Panel1.Controls.Add(this.gbUnosTocke);
            // 
            // scOsnovno.Panel2
            // 
            this.scOsnovno.Panel2.Controls.Add(this.groupBox1);
            this.scOsnovno.Panel2.Controls.Add(this.groupBox4);
            this.scOsnovno.Size = new System.Drawing.Size(669, 484);
            this.scOsnovno.SplitterDistance = 223;
            this.scOsnovno.TabIndex = 0;
            // 
            // gbTocke
            // 
            this.gbTocke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTocke.Controls.Add(this.lvTocke);
            this.gbTocke.Location = new System.Drawing.Point(0, 124);
            this.gbTocke.Name = "gbTocke";
            this.gbTocke.Size = new System.Drawing.Size(217, 357);
            this.gbTocke.TabIndex = 1;
            this.gbTocke.TabStop = false;
            this.gbTocke.Text = "Točke";
            // 
            // lvTocke
            // 
            this.lvTocke.CheckBoxes = true;
            this.lvTocke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.datum,
            this.tocka,
            this.visina});
            this.lvTocke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTocke.FullRowSelect = true;
            this.lvTocke.GridLines = true;
            this.lvTocke.Location = new System.Drawing.Point(3, 16);
            this.lvTocke.MultiSelect = false;
            this.lvTocke.Name = "lvTocke";
            this.lvTocke.Size = new System.Drawing.Size(211, 338);
            this.lvTocke.TabIndex = 0;
            this.lvTocke.UseCompatibleStateImageBehavior = false;
            this.lvTocke.View = System.Windows.Forms.View.Details;
            this.lvTocke.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvTocke_ItemCheck);
            this.lvTocke.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvTocke_MouseDown);
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 47;
            // 
            // tocka
            // 
            this.tocka.Text = "Reper";
            this.tocka.Width = 43;
            // 
            // visina
            // 
            this.visina.Text = "Visina";
            this.visina.Width = 117;
            // 
            // gbUnosTocke
            // 
            this.gbUnosTocke.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUnosTocke.Controls.Add(this.btnDodajTocku);
            this.gbUnosTocke.Controls.Add(this.tbVisina);
            this.gbUnosTocke.Controls.Add(this.tbTocka);
            this.gbUnosTocke.Controls.Add(this.label2);
            this.gbUnosTocke.Controls.Add(this.label1);
            this.gbUnosTocke.Location = new System.Drawing.Point(3, 4);
            this.gbUnosTocke.Name = "gbUnosTocke";
            this.gbUnosTocke.Size = new System.Drawing.Size(214, 114);
            this.gbUnosTocke.TabIndex = 0;
            this.gbUnosTocke.TabStop = false;
            this.gbUnosTocke.Text = "Unos repera";
            // 
            // btnDodajTocku
            // 
            this.btnDodajTocku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajTocku.Location = new System.Drawing.Point(133, 77);
            this.btnDodajTocku.Name = "btnDodajTocku";
            this.btnDodajTocku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajTocku.TabIndex = 4;
            this.btnDodajTocku.Text = "Dodaj";
            this.btnDodajTocku.UseVisualStyleBackColor = true;
            this.btnDodajTocku.Click += new System.EventHandler(this.btnDodajTocku_Click);
            // 
            // tbVisina
            // 
            this.tbVisina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVisina.Location = new System.Drawing.Point(53, 51);
            this.tbVisina.Name = "tbVisina";
            this.tbVisina.Size = new System.Drawing.Size(155, 20);
            this.tbVisina.TabIndex = 3;
            this.tbVisina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVisina_KeyPress);
            this.tbVisina.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbVisina_KeyUp);
            // 
            // tbTocka
            // 
            this.tbTocka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTocka.Location = new System.Drawing.Point(53, 25);
            this.tbTocka.Name = "tbTocka";
            this.tbTocka.Size = new System.Drawing.Size(155, 20);
            this.tbTocka.TabIndex = 2;
            this.tbTocka.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTocka_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reper:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvMjerenje);
            this.groupBox1.Location = new System.Drawing.Point(3, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled podataka";
            // 
            // lvMjerenje
            // 
            this.lvMjerenje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kontrola,
            this.od,
            this.do1,
            this.f,
            this.tezina,
            this.mjerenje,
            this.izracunato,
            this.udaljenost,
            this.varijanca});
            this.lvMjerenje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMjerenje.FullRowSelect = true;
            this.lvMjerenje.GridLines = true;
            this.lvMjerenje.Location = new System.Drawing.Point(3, 16);
            this.lvMjerenje.MultiSelect = false;
            this.lvMjerenje.Name = "lvMjerenje";
            this.lvMjerenje.Size = new System.Drawing.Size(428, 243);
            this.lvMjerenje.TabIndex = 0;
            this.lvMjerenje.UseCompatibleStateImageBehavior = false;
            this.lvMjerenje.View = System.Windows.Forms.View.Details;
            this.lvMjerenje.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvMjerenje_MouseDown);
            // 
            // kontrola
            // 
            this.kontrola.Text = "Kontrola";
            // 
            // od
            // 
            this.od.Text = "Od";
            this.od.Width = 35;
            // 
            // do1
            // 
            this.do1.Text = "Do";
            this.do1.Width = 33;
            // 
            // f
            // 
            this.f.Text = "    f";
            this.f.Width = 41;
            // 
            // tezina
            // 
            this.tezina.Text = "Težina";
            // 
            // mjerenje
            // 
            this.mjerenje.Text = "Mjerenje";
            // 
            // izracunato
            // 
            this.izracunato.Text = "Izračunata dH";
            this.izracunato.Width = 83;
            // 
            // udaljenost
            // 
            this.udaljenost.Text = "Udaljenost";
            this.udaljenost.Width = 65;
            // 
            // varijanca
            // 
            this.varijanca.Text = "Varijanca";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDodajMjerenje);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 198);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Podaci za izjednačenje";
            // 
            // btnDodajMjerenje
            // 
            this.btnDodajMjerenje.Location = new System.Drawing.Point(353, 165);
            this.btnDodajMjerenje.Name = "btnDodajMjerenje";
            this.btnDodajMjerenje.Size = new System.Drawing.Size(75, 23);
            this.btnDodajMjerenje.TabIndex = 3;
            this.btnDodajMjerenje.Text = "Dodaj";
            this.btnDodajMjerenje.UseVisualStyleBackColor = true;
            this.btnDodajMjerenje.Click += new System.EventHandler(this.btnDodajMjerenje_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.tbTezina);
            this.groupBox6.Controls.Add(this.tbPPM);
            this.groupBox6.Controls.Add(this.tbMM);
            this.groupBox6.Controls.Add(this.rbTezina);
            this.groupBox6.Controls.Add(this.rbTezinaPpm);
            this.groupBox6.Controls.Add(this.rbTezinaSqrtD);
            this.groupBox6.Controls.Add(this.rbTezinaD);
            this.groupBox6.Location = new System.Drawing.Point(221, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(209, 131);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Težina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "ppm";
            // 
            // tbTezina
            // 
            this.tbTezina.Location = new System.Drawing.Point(69, 99);
            this.tbTezina.Name = "tbTezina";
            this.tbTezina.Size = new System.Drawing.Size(93, 20);
            this.tbTezina.TabIndex = 6;
            this.tbTezina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTezina_KeyPress);
            // 
            // tbPPM
            // 
            this.tbPPM.Location = new System.Drawing.Point(127, 73);
            this.tbPPM.Name = "tbPPM";
            this.tbPPM.Size = new System.Drawing.Size(35, 20);
            this.tbPPM.TabIndex = 5;
            this.tbPPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPPM_KeyPress);
            // 
            // tbMM
            // 
            this.tbMM.Location = new System.Drawing.Point(53, 73);
            this.tbMM.Name = "tbMM";
            this.tbMM.Size = new System.Drawing.Size(35, 20);
            this.tbMM.TabIndex = 4;
            this.tbMM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMM_KeyPress);
            // 
            // rbTezina
            // 
            this.rbTezina.AutoSize = true;
            this.rbTezina.Location = new System.Drawing.Point(6, 100);
            this.rbTezina.Name = "rbTezina";
            this.rbTezina.Size = new System.Drawing.Size(57, 17);
            this.rbTezina.TabIndex = 3;
            this.rbTezina.Text = "Težina";
            this.rbTezina.UseVisualStyleBackColor = true;
            this.rbTezina.CheckedChanged += new System.EventHandler(this.rbTezina_CheckedChanged);
            // 
            // rbTezinaPpm
            // 
            this.rbTezinaPpm.AutoSize = true;
            this.rbTezinaPpm.Location = new System.Drawing.Point(6, 74);
            this.rbTezinaPpm.Name = "rbTezinaPpm";
            this.rbTezinaPpm.Size = new System.Drawing.Size(41, 17);
            this.rbTezinaPpm.TabIndex = 2;
            this.rbTezinaPpm.Text = "mm";
            this.rbTezinaPpm.UseVisualStyleBackColor = true;
            this.rbTezinaPpm.CheckedChanged += new System.EventHandler(this.rbTezinaPpm_CheckedChanged);
            // 
            // rbTezinaSqrtD
            // 
            this.rbTezinaSqrtD.AutoSize = true;
            this.rbTezinaSqrtD.Location = new System.Drawing.Point(6, 47);
            this.rbTezinaSqrtD.Name = "rbTezinaSqrtD";
            this.rbTezinaSqrtD.Size = new System.Drawing.Size(42, 17);
            this.rbTezinaSqrtD.TabIndex = 1;
            this.rbTezinaSqrtD.Text = "1/d";
            this.rbTezinaSqrtD.UseVisualStyleBackColor = true;
            this.rbTezinaSqrtD.CheckedChanged += new System.EventHandler(this.rbTezinaSqrtD_CheckedChanged);
            // 
            // rbTezinaD
            // 
            this.rbTezinaD.AutoSize = true;
            this.rbTezinaD.Checked = true;
            this.rbTezinaD.Location = new System.Drawing.Point(6, 24);
            this.rbTezinaD.Name = "rbTezinaD";
            this.rbTezinaD.Size = new System.Drawing.Size(42, 17);
            this.rbTezinaD.TabIndex = 0;
            this.rbTezinaD.TabStop = true;
            this.rbTezinaD.Text = "1/d";
            this.rbTezinaD.UseVisualStyleBackColor = true;
            this.rbTezinaD.CheckedChanged += new System.EventHandler(this.rbTezinaD_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tbUdaljenost);
            this.groupBox5.Controls.Add(this.tbMjerenje);
            this.groupBox5.Controls.Add(this.cmbDo);
            this.groupBox5.Controls.Add(this.cmbOd);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(6, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 131);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mjerenje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Udaljenost [km]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mjerenje (Δh) [m]";
            // 
            // tbUdaljenost
            // 
            this.tbUdaljenost.Location = new System.Drawing.Point(99, 99);
            this.tbUdaljenost.Name = "tbUdaljenost";
            this.tbUdaljenost.Size = new System.Drawing.Size(83, 20);
            this.tbUdaljenost.TabIndex = 5;
            this.tbUdaljenost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUdaljenost_KeyPress);
            this.tbUdaljenost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbUdaljenost_KeyUp);
            // 
            // tbMjerenje
            // 
            this.tbMjerenje.Location = new System.Drawing.Point(99, 73);
            this.tbMjerenje.Name = "tbMjerenje";
            this.tbMjerenje.Size = new System.Drawing.Size(83, 20);
            this.tbMjerenje.TabIndex = 4;
            this.tbMjerenje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMjerenje_KeyPress);
            this.tbMjerenje.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbMjerenje_KeyUp);
            // 
            // cmbDo
            // 
            this.cmbDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDo.FormattingEnabled = true;
            this.cmbDo.Location = new System.Drawing.Point(54, 46);
            this.cmbDo.Name = "cmbDo";
            this.cmbDo.Size = new System.Drawing.Size(149, 21);
            this.cmbDo.TabIndex = 3;
            // 
            // cmbOd
            // 
            this.cmbOd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOd.FormattingEnabled = true;
            this.cmbOd.Location = new System.Drawing.Point(54, 19);
            this.cmbOd.Name = "cmbOd";
            this.cmbOd.Size = new System.Drawing.Size(149, 21);
            this.cmbOd.TabIndex = 2;
            this.cmbOd.SelectedIndexChanged += new System.EventHandler(this.cmbOd_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Od";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvA);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "A";
            this.tabPage2.ToolTipText = "Matrica koeficijenata normalnih jednadžbi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvA
            // 
            this.lvA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvA.GridLines = true;
            this.lvA.Location = new System.Drawing.Point(3, 3);
            this.lvA.MultiSelect = false;
            this.lvA.Name = "lvA";
            this.lvA.Size = new System.Drawing.Size(669, 484);
            this.lvA.TabIndex = 0;
            this.lvA.UseCompatibleStateImageBehavior = false;
            this.lvA.View = System.Windows.Forms.View.Details;
            // 
            // tpP
            // 
            this.tpP.Controls.Add(this.lvP);
            this.tpP.Location = new System.Drawing.Point(4, 22);
            this.tpP.Name = "tpP";
            this.tpP.Padding = new System.Windows.Forms.Padding(3);
            this.tpP.Size = new System.Drawing.Size(675, 490);
            this.tpP.TabIndex = 2;
            this.tpP.Text = "P";
            this.tpP.UseVisualStyleBackColor = true;
            // 
            // lvP
            // 
            this.lvP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvP.GridLines = true;
            this.lvP.Location = new System.Drawing.Point(3, 3);
            this.lvP.MultiSelect = false;
            this.lvP.Name = "lvP";
            this.lvP.Size = new System.Drawing.Size(669, 484);
            this.lvP.TabIndex = 1;
            this.lvP.UseCompatibleStateImageBehavior = false;
            this.lvP.View = System.Windows.Forms.View.Details;
            // 
            // tpF
            // 
            this.tpF.Controls.Add(this.lvF);
            this.tpF.Location = new System.Drawing.Point(4, 22);
            this.tpF.Name = "tpF";
            this.tpF.Padding = new System.Windows.Forms.Padding(3);
            this.tpF.Size = new System.Drawing.Size(675, 490);
            this.tpF.TabIndex = 3;
            this.tpF.Text = "f";
            this.tpF.UseVisualStyleBackColor = true;
            // 
            // lvF
            // 
            this.lvF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvF.GridLines = true;
            this.lvF.Location = new System.Drawing.Point(3, 3);
            this.lvF.MultiSelect = false;
            this.lvF.Name = "lvF";
            this.lvF.Size = new System.Drawing.Size(669, 484);
            this.lvF.TabIndex = 1;
            this.lvF.UseCompatibleStateImageBehavior = false;
            this.lvF.View = System.Windows.Forms.View.Details;
            // 
            // tpG
            // 
            this.tpG.Controls.Add(this.lvG);
            this.tpG.Location = new System.Drawing.Point(4, 22);
            this.tpG.Name = "tpG";
            this.tpG.Padding = new System.Windows.Forms.Padding(3);
            this.tpG.Size = new System.Drawing.Size(675, 490);
            this.tpG.TabIndex = 4;
            this.tpG.Text = "G";
            this.tpG.UseVisualStyleBackColor = true;
            // 
            // lvG
            // 
            this.lvG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvG.GridLines = true;
            this.lvG.Location = new System.Drawing.Point(3, 3);
            this.lvG.MultiSelect = false;
            this.lvG.Name = "lvG";
            this.lvG.Size = new System.Drawing.Size(669, 484);
            this.lvG.TabIndex = 1;
            this.lvG.UseCompatibleStateImageBehavior = false;
            this.lvG.View = System.Windows.Forms.View.Details;
            // 
            // tpIzjednacenje
            // 
            this.tpIzjednacenje.Controls.Add(this.tcIzjednacenje);
            this.tpIzjednacenje.Location = new System.Drawing.Point(4, 22);
            this.tpIzjednacenje.Name = "tpIzjednacenje";
            this.tpIzjednacenje.Padding = new System.Windows.Forms.Padding(3);
            this.tpIzjednacenje.Size = new System.Drawing.Size(675, 490);
            this.tpIzjednacenje.TabIndex = 5;
            this.tpIzjednacenje.Text = "Izjednačenje";
            this.tpIzjednacenje.UseVisualStyleBackColor = true;
            // 
            // tcIzjednacenje
            // 
            this.tcIzjednacenje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcIzjednacenje.Location = new System.Drawing.Point(3, 3);
            this.tcIzjednacenje.Name = "tcIzjednacenje";
            this.tcIzjednacenje.SelectedIndex = 0;
            this.tcIzjednacenje.Size = new System.Drawing.Size(669, 484);
            this.tcIzjednacenje.TabIndex = 0;
            // 
            // tpOcjenaFunkcija
            // 
            this.tpOcjenaFunkcija.Controls.Add(this.lvOcjenaFunkcija);
            this.tpOcjenaFunkcija.Location = new System.Drawing.Point(4, 22);
            this.tpOcjenaFunkcija.Name = "tpOcjenaFunkcija";
            this.tpOcjenaFunkcija.Padding = new System.Windows.Forms.Padding(3);
            this.tpOcjenaFunkcija.Size = new System.Drawing.Size(675, 490);
            this.tpOcjenaFunkcija.TabIndex = 6;
            this.tpOcjenaFunkcija.Text = "Ocjena funkcija";
            this.tpOcjenaFunkcija.UseVisualStyleBackColor = true;
            // 
            // lvOcjenaFunkcija
            // 
            this.lvOcjenaFunkcija.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.funkcija,
            this.ocjeniva,
            this.var,
            this.stDev});
            this.lvOcjenaFunkcija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOcjenaFunkcija.GridLines = true;
            this.lvOcjenaFunkcija.Location = new System.Drawing.Point(3, 3);
            this.lvOcjenaFunkcija.Name = "lvOcjenaFunkcija";
            this.lvOcjenaFunkcija.Size = new System.Drawing.Size(669, 484);
            this.lvOcjenaFunkcija.TabIndex = 2;
            this.lvOcjenaFunkcija.UseCompatibleStateImageBehavior = false;
            this.lvOcjenaFunkcija.View = System.Windows.Forms.View.Details;
            // 
            // funkcija
            // 
            this.funkcija.Text = "Funkcija";
            // 
            // ocjeniva
            // 
            this.ocjeniva.Text = "Ocjenjiva";
            // 
            // var
            // 
            this.var.Text = "Varijanca";
            // 
            // stDev
            // 
            this.stDev.Text = "St. dev.";
            // 
            // tpIzjednaceneVelicine
            // 
            this.tpIzjednaceneVelicine.Controls.Add(this.tcIzjednaceneVrijednosti);
            this.tpIzjednaceneVelicine.Location = new System.Drawing.Point(4, 22);
            this.tpIzjednaceneVelicine.Name = "tpIzjednaceneVelicine";
            this.tpIzjednaceneVelicine.Padding = new System.Windows.Forms.Padding(3);
            this.tpIzjednaceneVelicine.Size = new System.Drawing.Size(675, 490);
            this.tpIzjednaceneVelicine.TabIndex = 7;
            this.tpIzjednaceneVelicine.Text = "Izjednačene veličine";
            this.tpIzjednaceneVelicine.UseVisualStyleBackColor = true;
            // 
            // tcIzjednaceneVrijednosti
            // 
            this.tcIzjednaceneVrijednosti.Controls.Add(this.tpMjerenja);
            this.tcIzjednaceneVrijednosti.Controls.Add(this.tpReperi);
            this.tcIzjednaceneVrijednosti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcIzjednaceneVrijednosti.Location = new System.Drawing.Point(3, 3);
            this.tcIzjednaceneVrijednosti.Name = "tcIzjednaceneVrijednosti";
            this.tcIzjednaceneVrijednosti.SelectedIndex = 0;
            this.tcIzjednaceneVrijednosti.Size = new System.Drawing.Size(669, 484);
            this.tcIzjednaceneVrijednosti.TabIndex = 0;
            // 
            // tpMjerenja
            // 
            this.tpMjerenja.Controls.Add(this.lvIzjednacenaMjerenja);
            this.tpMjerenja.Location = new System.Drawing.Point(4, 22);
            this.tpMjerenja.Name = "tpMjerenja";
            this.tpMjerenja.Padding = new System.Windows.Forms.Padding(3);
            this.tpMjerenja.Size = new System.Drawing.Size(661, 458);
            this.tpMjerenja.TabIndex = 0;
            this.tpMjerenja.Text = "Mjerenja";
            this.tpMjerenja.UseVisualStyleBackColor = true;
            // 
            // lvIzjednacenaMjerenja
            // 
            this.lvIzjednacenaMjerenja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvIzjednacenaMjerenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIzjednacenaMjerenja.Location = new System.Drawing.Point(3, 3);
            this.lvIzjednacenaMjerenja.Name = "lvIzjednacenaMjerenja";
            this.lvIzjednacenaMjerenja.Size = new System.Drawing.Size(655, 452);
            this.lvIzjednacenaMjerenja.TabIndex = 0;
            this.lvIzjednacenaMjerenja.UseCompatibleStateImageBehavior = false;
            this.lvIzjednacenaMjerenja.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mjerenje";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Izmjereno";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Popravka";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Izjednačeno mjerenje";
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "q";
            this.columnHeader5.Width = 26;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "[A priori] s0^2 q";
            this.columnHeader6.Width = 63;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "[A priori] s0 q";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "[A posteriori] s0^2 q";
            this.columnHeader8.Width = 82;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "[A posteriori] s0 q";
            this.columnHeader9.Width = 85;
            // 
            // tpReperi
            // 
            this.tpReperi.Controls.Add(this.lvReperi);
            this.tpReperi.Location = new System.Drawing.Point(4, 22);
            this.tpReperi.Name = "tpReperi";
            this.tpReperi.Padding = new System.Windows.Forms.Padding(3);
            this.tpReperi.Size = new System.Drawing.Size(661, 458);
            this.tpReperi.TabIndex = 1;
            this.tpReperi.Text = "Reperi";
            this.tpReperi.UseVisualStyleBackColor = true;
            // 
            // lvReperi
            // 
            this.lvReperi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvReperi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvReperi.Location = new System.Drawing.Point(3, 3);
            this.lvReperi.Name = "lvReperi";
            this.lvReperi.Size = new System.Drawing.Size(655, 452);
            this.lvReperi.TabIndex = 1;
            this.lvReperi.UseCompatibleStateImageBehavior = false;
            this.lvReperi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mjerenje";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Izmjereno";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Popravka";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Izjednačeno mjerenje";
            this.columnHeader13.Width = 116;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "q";
            this.columnHeader14.Width = 26;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "[A priori] s0^2 q";
            this.columnHeader15.Width = 63;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "[A priori] s0 q";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "[A posteriori] s0^2 q";
            this.columnHeader17.Width = 82;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "[A posteriori] s0 q";
            this.columnHeader18.Width = 85;
            // 
            // tpStatistika
            // 
            this.tpStatistika.Controls.Add(this.lvStatistika);
            this.tpStatistika.Location = new System.Drawing.Point(4, 22);
            this.tpStatistika.Name = "tpStatistika";
            this.tpStatistika.Padding = new System.Windows.Forms.Padding(3);
            this.tpStatistika.Size = new System.Drawing.Size(675, 490);
            this.tpStatistika.TabIndex = 8;
            this.tpStatistika.Text = "Statističko testiranje";
            this.tpStatistika.UseVisualStyleBackColor = true;
            // 
            // lvStatistika
            // 
            this.lvStatistika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvStatistika.Location = new System.Drawing.Point(3, 3);
            this.lvStatistika.Name = "lvStatistika";
            this.lvStatistika.Size = new System.Drawing.Size(669, 484);
            this.lvStatistika.TabIndex = 1;
            this.lvStatistika.UseCompatibleStateImageBehavior = false;
            this.lvStatistika.View = System.Windows.Forms.View.Details;
            // 
            // izmjeniToolStripMenuItem
            // 
            this.izmjeniToolStripMenuItem.Name = "izmjeniToolStripMenuItem";
            this.izmjeniToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.izmjeniToolStripMenuItem.Text = "Izmjeni";
            this.izmjeniToolStripMenuItem.Click += new System.EventHandler(this.izmjeniToolStripMenuItem_Click);
            // 
            // izbrisiToolStripMenuItem
            // 
            this.izbrisiToolStripMenuItem.Name = "izbrisiToolStripMenuItem";
            this.izbrisiToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.izbrisiToolStripMenuItem.Text = "Izbrisi";
            this.izbrisiToolStripMenuItem.Click += new System.EventHandler(this.izbrisiToolStripMenuItem_Click);
            // 
            // cmsLvTocke
            // 
            this.cmsLvTocke.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izmjeniToolStripMenuItem,
            this.izbrisiToolStripMenuItem});
            this.cmsLvTocke.Name = "cmsLvTocke";
            this.cmsLvTocke.Size = new System.Drawing.Size(113, 48);
            // 
            // cmsLvMjerenje
            // 
            this.cmsLvMjerenje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izmjeniToolStripMenuItem1,
            this.izbrisiToolStripMenuItem1});
            this.cmsLvMjerenje.Name = "cmsLvMjerenje";
            this.cmsLvMjerenje.Size = new System.Drawing.Size(113, 48);
            // 
            // izmjeniToolStripMenuItem1
            // 
            this.izmjeniToolStripMenuItem1.Enabled = false;
            this.izmjeniToolStripMenuItem1.Name = "izmjeniToolStripMenuItem1";
            this.izmjeniToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.izmjeniToolStripMenuItem1.Text = "Izmjeni";
            // 
            // izbrisiToolStripMenuItem1
            // 
            this.izbrisiToolStripMenuItem1.Name = "izbrisiToolStripMenuItem1";
            this.izbrisiToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.izbrisiToolStripMenuItem1.Text = "Izbrisi";
            this.izbrisiToolStripMenuItem1.Click += new System.EventHandler(this.izbrisiToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nivelman";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbVrstaIzjednacenja.ResumeLayout(false);
            this.gbVrstaIzjednacenja.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpOsnovno.ResumeLayout(false);
            this.scOsnovno.Panel1.ResumeLayout(false);
            this.scOsnovno.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scOsnovno)).EndInit();
            this.scOsnovno.ResumeLayout(false);
            this.gbTocke.ResumeLayout(false);
            this.gbUnosTocke.ResumeLayout(false);
            this.gbUnosTocke.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tpP.ResumeLayout(false);
            this.tpF.ResumeLayout(false);
            this.tpG.ResumeLayout(false);
            this.tpIzjednacenje.ResumeLayout(false);
            this.tpOcjenaFunkcija.ResumeLayout(false);
            this.tpIzjednaceneVelicine.ResumeLayout(false);
            this.tcIzjednaceneVrijednosti.ResumeLayout(false);
            this.tpMjerenja.ResumeLayout(false);
            this.tpReperi.ResumeLayout(false);
            this.tpStatistika.ResumeLayout(false);
            this.cmsLvTocke.ResumeLayout(false);
            this.cmsLvMjerenje.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbSigmaNulaKvadrat;
        private System.Windows.Forms.TextBox tbSigmaNula;
        private System.Windows.Forms.Label lblSigmaNulaKvadrat;
        private System.Windows.Forms.Label lblSigmaNula;
        private System.Windows.Forms.GroupBox gbVrstaIzjednacenja;
        private System.Windows.Forms.RadioButton rbIzjednacenjePrisila;
        private System.Windows.Forms.RadioButton rbKlasicanNacin;
        private System.Windows.Forms.RadioButton rbParcijalniMinimalniTrag;
        private System.Windows.Forms.RadioButton rbMinimalniTrag;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpOsnovno;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tpP;
        private System.Windows.Forms.TabPage tpF;
        private System.Windows.Forms.TabPage tpG;
        private System.Windows.Forms.TabPage tpIzjednacenje;
        private System.Windows.Forms.SplitContainer scOsnovno;
        private System.Windows.Forms.GroupBox gbTocke;
        private System.Windows.Forms.ListView lvTocke;
        private System.Windows.Forms.ColumnHeader tocka;
        private System.Windows.Forms.ColumnHeader visina;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.GroupBox gbUnosTocke;
        private System.Windows.Forms.Button btnDodajTocku;
        private System.Windows.Forms.TextBox tbVisina;
        private System.Windows.Forms.TextBox tbTocka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ContextMenuStrip cmsLvTocke;
        private System.Windows.Forms.ToolStripMenuItem izmjeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbrisiToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbTezina;
        private System.Windows.Forms.RadioButton rbTezinaPpm;
        private System.Windows.Forms.RadioButton rbTezinaSqrtD;
        private System.Windows.Forms.RadioButton rbTezinaD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUdaljenost;
        private System.Windows.Forms.TextBox tbMjerenje;
        private System.Windows.Forms.ComboBox cmbDo;
        private System.Windows.Forms.ComboBox cmbOd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvMjerenje;
        private System.Windows.Forms.ColumnHeader kontrola;
        private System.Windows.Forms.ColumnHeader od;
        private System.Windows.Forms.ColumnHeader do1;
        private System.Windows.Forms.ColumnHeader mjerenje;
        private System.Windows.Forms.ColumnHeader udaljenost;
        private System.Windows.Forms.ColumnHeader varijanca;
        private System.Windows.Forms.ColumnHeader tezina;
        private System.Windows.Forms.Button btnDodajMjerenje;
        private System.Windows.Forms.ColumnHeader f;
        private System.Windows.Forms.ColumnHeader izracunato;
        private System.Windows.Forms.TextBox tbTezina;
        private System.Windows.Forms.TextBox tbPPM;
        private System.Windows.Forms.TextBox tbMM;
        private System.Windows.Forms.TabPage tpOcjenaFunkcija;
        private System.Windows.Forms.TextBox tbTolerancija;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnIzjednaci;
        private System.Windows.Forms.Button btnFormirajMatrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip cmsLvMjerenje;
        private System.Windows.Forms.ToolStripMenuItem izbrisiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izmjeniToolStripMenuItem1;
        private System.Windows.Forms.ListView lvA;
        private System.Windows.Forms.ListView lvP;
        private System.Windows.Forms.ListView lvF;
        private System.Windows.Forms.ListView lvG;
        private System.Windows.Forms.TabControl tcIzjednacenje;
        private System.Windows.Forms.ListView lvOcjenaFunkcija;
        private System.Windows.Forms.ColumnHeader funkcija;
        private System.Windows.Forms.ColumnHeader ocjeniva;
        private System.Windows.Forms.ColumnHeader var;
        private System.Windows.Forms.ColumnHeader stDev;
        private System.Windows.Forms.TabPage tpIzjednaceneVelicine;
        private System.Windows.Forms.ToolStripStatusLabel tsslVrstaIzjednacenja;
        private System.Windows.Forms.ToolStripStatusLabel tsslSigmaKvadrat;
        private System.Windows.Forms.ToolStripStatusLabel tsslSigma;
        private System.Windows.Forms.TabControl tcIzjednaceneVrijednosti;
        private System.Windows.Forms.TabPage tpMjerenja;
        private System.Windows.Forms.ListView lvIzjednacenaMjerenja;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TabPage tpReperi;
        private System.Windows.Forms.ToolStripStatusLabel tsslSo2;
        private System.Windows.Forms.ToolStripStatusLabel tsslSo;
        private System.Windows.Forms.ToolStripStatusLabel tssln;
        private System.Windows.Forms.ToolStripStatusLabel tsslu;
        private System.Windows.Forms.ToolStripStatusLabel tssld;
        private System.Windows.Forms.ToolStripStatusLabel tsslf;
        private System.Windows.Forms.ListView lvReperi;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.TabPage tpStatistika;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tbGlobalniAlfa;
        private System.Windows.Forms.Label lblGlobalniAlfa;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbLokalniBeta;
        private System.Windows.Forms.TextBox tbLokalniAlfa;
        private System.Windows.Forms.Label lblLokalniBeta;
        private System.Windows.Forms.Label lblLokalniAlfa;
        private System.Windows.Forms.ListView lvStatistika;
        private System.Windows.Forms.ToolStripStatusLabel tsslGlobalniTest;
    }
}

