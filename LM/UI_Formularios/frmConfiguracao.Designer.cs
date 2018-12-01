namespace LM.UI_Formularios
{
    partial class frmConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracao));
            this.btnPadrao = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.rdbPadrao = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbEscuro = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbClaro = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.metroPanelSalvar = new MetroFramework.Controls.MetroPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnProcurarCor = new MaterialSkin.Controls.MaterialFlatButton();
            this.formaCorAtual = new MaterialSkin.Controls.MaterialDivider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCor_SemCor = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbCor_CorSolida = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAlterarFonte = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.lblFonteAtual = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.colorDialogGrid = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.metroPanelSalvar.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPadrao
            // 
            this.btnPadrao.AutoSize = true;
            this.btnPadrao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPadrao.Depth = 0;
            this.btnPadrao.Icon = null;
            this.btnPadrao.Location = new System.Drawing.Point(232, 519);
            this.btnPadrao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPadrao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPadrao.Name = "btnPadrao";
            this.btnPadrao.Primary = false;
            this.btnPadrao.Size = new System.Drawing.Size(156, 36);
            this.btnPadrao.TabIndex = 0;
            this.btnPadrao.Text = "Restaurar Padrão";
            this.btnPadrao.UseVisualStyleBackColor = true;
            this.btnPadrao.Click += new System.EventHandler(this.btnPadrao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(12, 519);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = false;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(92, 519);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(91, 3);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(23, 19);
            this.metroProgressSpinner1.TabIndex = 12;
            this.metroProgressSpinner1.UseCustomBackColor = true;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 30;
            // 
            // rdbPadrao
            // 
            this.rdbPadrao.AutoSize = true;
            this.rdbPadrao.BackColor = System.Drawing.SystemColors.Control;
            this.rdbPadrao.Depth = 0;
            this.rdbPadrao.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbPadrao.Location = new System.Drawing.Point(3, 3);
            this.rdbPadrao.Margin = new System.Windows.Forms.Padding(0);
            this.rdbPadrao.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbPadrao.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbPadrao.Name = "rdbPadrao";
            this.rdbPadrao.Ripple = true;
            this.rdbPadrao.Size = new System.Drawing.Size(111, 30);
            this.rdbPadrao.TabIndex = 3;
            this.rdbPadrao.Text = "Tema Padrão";
            this.rdbPadrao.UseVisualStyleBackColor = false;
            // 
            // rdbEscuro
            // 
            this.rdbEscuro.AutoSize = true;
            this.rdbEscuro.BackColor = System.Drawing.Color.Transparent;
            this.rdbEscuro.Depth = 0;
            this.rdbEscuro.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbEscuro.Location = new System.Drawing.Point(3, 45);
            this.rdbEscuro.Margin = new System.Windows.Forms.Padding(0);
            this.rdbEscuro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbEscuro.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbEscuro.Name = "rdbEscuro";
            this.rdbEscuro.Ripple = true;
            this.rdbEscuro.Size = new System.Drawing.Size(110, 30);
            this.rdbEscuro.TabIndex = 5;
            this.rdbEscuro.Text = "Tema Escuro";
            this.rdbEscuro.UseVisualStyleBackColor = false;
            // 
            // rdbClaro
            // 
            this.rdbClaro.AutoSize = true;
            this.rdbClaro.BackColor = System.Drawing.Color.Transparent;
            this.rdbClaro.Depth = 0;
            this.rdbClaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbClaro.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbClaro.Location = new System.Drawing.Point(3, 87);
            this.rdbClaro.Margin = new System.Windows.Forms.Padding(0);
            this.rdbClaro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbClaro.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbClaro.Name = "rdbClaro";
            this.rdbClaro.Ripple = true;
            this.rdbClaro.Size = new System.Drawing.Size(100, 30);
            this.rdbClaro.TabIndex = 6;
            this.rdbClaro.Text = "Tema Claro";
            this.rdbClaro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbClaro.UseVisualStyleBackColor = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 3);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "Salvando...";
            // 
            // metroPanelSalvar
            // 
            this.metroPanelSalvar.Controls.Add(this.materialLabel3);
            this.metroPanelSalvar.Controls.Add(this.metroProgressSpinner1);
            this.metroPanelSalvar.HorizontalScrollbarBarColor = true;
            this.metroPanelSalvar.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelSalvar.HorizontalScrollbarSize = 10;
            this.metroPanelSalvar.Location = new System.Drawing.Point(242, 341);
            this.metroPanelSalvar.Name = "metroPanelSalvar";
            this.metroPanelSalvar.Size = new System.Drawing.Size(117, 26);
            this.metroPanelSalvar.TabIndex = 19;
            this.metroPanelSalvar.UseCustomBackColor = true;
            this.metroPanelSalvar.VerticalScrollbarBarColor = true;
            this.metroPanelSalvar.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelSalvar.VerticalScrollbarSize = 10;
            this.metroPanelSalvar.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 111);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(376, 399);
            this.materialTabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnProcurarCor);
            this.tabPage1.Controls.Add(this.formaCorAtual);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialDivider1);
            this.tabPage1.Controls.Add(this.metroPanelSalvar);
            this.tabPage1.Controls.Add(this.rdbPadrao);
            this.tabPage1.Controls.Add(this.rdbEscuro);
            this.tabPage1.Controls.Add(this.rdbClaro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(368, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Temas";
            // 
            // btnProcurarCor
            // 
            this.btnProcurarCor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurarCor.AutoSize = true;
            this.btnProcurarCor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcurarCor.Depth = 0;
            this.btnProcurarCor.Enabled = false;
            this.btnProcurarCor.Icon = null;
            this.btnProcurarCor.Location = new System.Drawing.Point(264, 141);
            this.btnProcurarCor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProcurarCor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProcurarCor.Name = "btnProcurarCor";
            this.btnProcurarCor.Primary = false;
            this.btnProcurarCor.Size = new System.Drawing.Size(92, 36);
            this.btnProcurarCor.TabIndex = 26;
            this.btnProcurarCor.Text = "Procurar";
            this.btnProcurarCor.UseVisualStyleBackColor = true;
            this.btnProcurarCor.Visible = false;
            this.btnProcurarCor.Click += new System.EventHandler(this.btnProcurarCor_Click);
            // 
            // formaCorAtual
            // 
            this.formaCorAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.formaCorAtual.Depth = 0;
            this.formaCorAtual.Location = new System.Drawing.Point(153, 141);
            this.formaCorAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.formaCorAtual.Name = "formaCorAtual";
            this.formaCorAtual.Size = new System.Drawing.Size(58, 28);
            this.formaCorAtual.TabIndex = 31;
            this.formaCorAtual.Text = "materialDivider4";
            this.formaCorAtual.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdbCor_SemCor);
            this.groupBox1.Controls.Add(this.rdbCor_CorSolida);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(6, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 107);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // rdbCor_SemCor
            // 
            this.rdbCor_SemCor.AutoSize = true;
            this.rdbCor_SemCor.Checked = true;
            this.rdbCor_SemCor.Depth = 0;
            this.rdbCor_SemCor.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbCor_SemCor.Location = new System.Drawing.Point(3, 16);
            this.rdbCor_SemCor.Margin = new System.Windows.Forms.Padding(0);
            this.rdbCor_SemCor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbCor_SemCor.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbCor_SemCor.Name = "rdbCor_SemCor";
            this.rdbCor_SemCor.Ripple = true;
            this.rdbCor_SemCor.Size = new System.Drawing.Size(98, 30);
            this.rdbCor_SemCor.TabIndex = 28;
            this.rdbCor_SemCor.TabStop = true;
            this.rdbCor_SemCor.Text = "Cor Padrão";
            this.rdbCor_SemCor.UseVisualStyleBackColor = true;
            // 
            // rdbCor_CorSolida
            // 
            this.rdbCor_CorSolida.AutoSize = true;
            this.rdbCor_CorSolida.Depth = 0;
            this.rdbCor_CorSolida.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbCor_CorSolida.Location = new System.Drawing.Point(3, 65);
            this.rdbCor_CorSolida.Margin = new System.Windows.Forms.Padding(0);
            this.rdbCor_CorSolida.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbCor_CorSolida.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbCor_CorSolida.Name = "rdbCor_CorSolida";
            this.rdbCor_CorSolida.Ripple = true;
            this.rdbCor_CorSolida.Size = new System.Drawing.Size(92, 30);
            this.rdbCor_CorSolida.TabIndex = 29;
            this.rdbCor_CorSolida.Text = "Cor Sólida";
            this.rdbCor_CorSolida.UseVisualStyleBackColor = true;
            this.rdbCor_CorSolida.CheckedChanged += new System.EventHandler(this.rdbCor_CorSolida_CheckedChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 149);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(141, 19);
            this.materialLabel4.TabIndex = 24;
            this.materialLabel4.Text = "Cor de Fundo Atual:";
            this.materialLabel4.Visible = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(6, 132);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(357, 1);
            this.materialDivider1.TabIndex = 23;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAlterarFonte);
            this.tabPage2.Controls.Add(this.materialDivider2);
            this.tabPage2.Controls.Add(this.materialDivider3);
            this.tabPage2.Controls.Add(this.lblFonteAtual);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(368, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fontes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAlterarFonte
            // 
            this.btnAlterarFonte.AutoSize = true;
            this.btnAlterarFonte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlterarFonte.Depth = 0;
            this.btnAlterarFonte.Icon = null;
            this.btnAlterarFonte.Location = new System.Drawing.Point(236, 324);
            this.btnAlterarFonte.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterarFonte.Name = "btnAlterarFonte";
            this.btnAlterarFonte.Primary = true;
            this.btnAlterarFonte.Size = new System.Drawing.Size(126, 36);
            this.btnAlterarFonte.TabIndex = 8;
            this.btnAlterarFonte.Text = "Alterar Fonte";
            this.btnAlterarFonte.UseVisualStyleBackColor = true;
            this.btnAlterarFonte.Visible = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(10, 366);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(352, 1);
            this.materialDivider2.TabIndex = 7;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(10, 29);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(352, 1);
            this.materialDivider3.TabIndex = 2;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // lblFonteAtual
            // 
            this.lblFonteAtual.AutoSize = true;
            this.lblFonteAtual.Depth = 0;
            this.lblFonteAtual.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFonteAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFonteAtual.Location = new System.Drawing.Point(102, 7);
            this.lblFonteAtual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFonteAtual.Name = "lblFonteAtual";
            this.lblFonteAtual.Size = new System.Drawing.Size(58, 19);
            this.lblFonteAtual.TabIndex = 1;
            this.lblFonteAtual.Text = "Roboto";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 7);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(90, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Fonte Atual:";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(402, 42);
            this.materialTabSelector1.TabIndex = 21;
            this.materialTabSelector1.Text = "Consulta";
            // 
            // colorDialogGrid
            // 
            this.colorDialogGrid.AnyColor = true;
            this.colorDialogGrid.FullOpen = true;
            this.colorDialogGrid.ShowHelp = true;
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 570);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPadrao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 570);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 570);
            this.Name = "frmConfiguracao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmConfiguracao_Load);
            this.metroPanelSalvar.ResumeLayout(false);
            this.metroPanelSalvar.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnPadrao;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MaterialSkin.Controls.MaterialRadioButton rdbPadrao;
        private MaterialSkin.Controls.MaterialRadioButton rdbEscuro;
        private MaterialSkin.Controls.MaterialRadioButton rdbClaro;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MetroFramework.Controls.MetroPanel metroPanelSalvar;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton btnProcurarCor;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialLabel lblFonteAtual;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ColorDialog colorDialogGrid;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAlterarFonte;
        private MaterialSkin.Controls.MaterialRadioButton rdbCor_SemCor;
        private MaterialSkin.Controls.MaterialRadioButton rdbCor_CorSolida;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialDivider formaCorAtual;
    }
}