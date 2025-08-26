namespace GerenciadorDeOVNI
{
    partial class Gerenciador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciador));
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.grbTripulantes = new System.Windows.Forms.GroupBox();
            this.btnRemoverTrip = new System.Windows.Forms.Button();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btnDesabduzir = new System.Windows.Forms.Button();
            this.btnAbduzir = new System.Windows.Forms.Button();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.txbPlaneta = new System.Windows.Forms.TextBox();
            this.lblPlanetaAtual = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnMudarPlaneta = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.pbAlienManager = new System.Windows.Forms.PictureBox();
            this.pbTerra = new System.Windows.Forms.PictureBox();
            this.grbInformacoes.SuspendLayout();
            this.grbTripulantes.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlienManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTerra)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.BackColor = System.Drawing.Color.Black;
            this.grbInformacoes.Controls.Add(this.btnDesligar);
            this.grbInformacoes.Controls.Add(this.btnLigar);
            this.grbInformacoes.Controls.Add(this.lblAbduzidos);
            this.grbInformacoes.Controls.Add(this.lblTripulantes);
            this.grbInformacoes.Controls.Add(this.lblSituacao);
            this.grbInformacoes.ForeColor = System.Drawing.Color.White;
            this.grbInformacoes.Location = new System.Drawing.Point(12, 12);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(138, 210);
            this.grbInformacoes.TabIndex = 0;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // btnDesligar
            // 
            this.btnDesligar.ForeColor = System.Drawing.Color.Black;
            this.btnDesligar.Location = new System.Drawing.Point(33, 149);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(86, 33);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.ForeColor = System.Drawing.Color.Black;
            this.btnLigar.Location = new System.Drawing.Point(33, 110);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(86, 33);
            this.btnLigar.TabIndex = 3;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(7, 83);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(59, 13);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(7, 50);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(62, 13);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(7, 20);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // grbTripulantes
            // 
            this.grbTripulantes.BackColor = System.Drawing.Color.Black;
            this.grbTripulantes.Controls.Add(this.btnRemoverTrip);
            this.grbTripulantes.Controls.Add(this.btnAddTrip);
            this.grbTripulantes.ForeColor = System.Drawing.Color.White;
            this.grbTripulantes.Location = new System.Drawing.Point(156, 228);
            this.grbTripulantes.Name = "grbTripulantes";
            this.grbTripulantes.Size = new System.Drawing.Size(141, 100);
            this.grbTripulantes.TabIndex = 1;
            this.grbTripulantes.TabStop = false;
            this.grbTripulantes.Text = "Tripulantes";
            // 
            // btnRemoverTrip
            // 
            this.btnRemoverTrip.ForeColor = System.Drawing.Color.Black;
            this.btnRemoverTrip.Location = new System.Drawing.Point(15, 61);
            this.btnRemoverTrip.Name = "btnRemoverTrip";
            this.btnRemoverTrip.Size = new System.Drawing.Size(118, 23);
            this.btnRemoverTrip.TabIndex = 5;
            this.btnRemoverTrip.Text = "Excluir Tripulante";
            this.btnRemoverTrip.UseVisualStyleBackColor = true;
            this.btnRemoverTrip.Click += new System.EventHandler(this.btnRemoverTrip_Click);
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.ForeColor = System.Drawing.Color.Black;
            this.btnAddTrip.Location = new System.Drawing.Point(15, 20);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(118, 23);
            this.btnAddTrip.TabIndex = 5;
            this.btnAddTrip.Text = "Novo Tripulante";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // grbAbduzidos
            // 
            this.grbAbduzidos.BackColor = System.Drawing.Color.Black;
            this.grbAbduzidos.Controls.Add(this.btnDesabduzir);
            this.grbAbduzidos.Controls.Add(this.btnAbduzir);
            this.grbAbduzidos.ForeColor = System.Drawing.Color.White;
            this.grbAbduzidos.Location = new System.Drawing.Point(9, 228);
            this.grbAbduzidos.Name = "grbAbduzidos";
            this.grbAbduzidos.Size = new System.Drawing.Size(141, 100);
            this.grbAbduzidos.TabIndex = 6;
            this.grbAbduzidos.TabStop = false;
            this.grbAbduzidos.Text = "Abduzidos";
            // 
            // btnDesabduzir
            // 
            this.btnDesabduzir.ForeColor = System.Drawing.Color.Black;
            this.btnDesabduzir.Location = new System.Drawing.Point(15, 61);
            this.btnDesabduzir.Name = "btnDesabduzir";
            this.btnDesabduzir.Size = new System.Drawing.Size(118, 23);
            this.btnDesabduzir.TabIndex = 5;
            this.btnDesabduzir.Text = "Desabduzir";
            this.btnDesabduzir.UseVisualStyleBackColor = true;
            this.btnDesabduzir.Click += new System.EventHandler(this.btnDesabduzir_Click);
            // 
            // btnAbduzir
            // 
            this.btnAbduzir.ForeColor = System.Drawing.Color.Black;
            this.btnAbduzir.Location = new System.Drawing.Point(15, 20);
            this.btnAbduzir.Name = "btnAbduzir";
            this.btnAbduzir.Size = new System.Drawing.Size(118, 23);
            this.btnAbduzir.TabIndex = 5;
            this.btnAbduzir.Text = "Abduzir";
            this.btnAbduzir.UseVisualStyleBackColor = true;
            this.btnAbduzir.Click += new System.EventHandler(this.btnAbduzir_Click);
            // 
            // grbPlaneta
            // 
            this.grbPlaneta.Controls.Add(this.pbTerra);
            this.grbPlaneta.Controls.Add(this.txbPlaneta);
            this.grbPlaneta.Controls.Add(this.lblPlanetaAtual);
            this.grbPlaneta.Controls.Add(this.btnRetornar);
            this.grbPlaneta.Controls.Add(this.btnMudarPlaneta);
            this.grbPlaneta.Controls.Add(this.cmbPlanetas);
            this.grbPlaneta.ForeColor = System.Drawing.Color.White;
            this.grbPlaneta.Location = new System.Drawing.Point(156, 12);
            this.grbPlaneta.Name = "grbPlaneta";
            this.grbPlaneta.Size = new System.Drawing.Size(141, 210);
            this.grbPlaneta.TabIndex = 7;
            this.grbPlaneta.TabStop = false;
            this.grbPlaneta.Text = "Planeta";
            // 
            // txbPlaneta
            // 
            this.txbPlaneta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPlaneta.Location = new System.Drawing.Point(8, 57);
            this.txbPlaneta.Name = "txbPlaneta";
            this.txbPlaneta.ReadOnly = true;
            this.txbPlaneta.Size = new System.Drawing.Size(123, 20);
            this.txbPlaneta.TabIndex = 4;
            // 
            // lblPlanetaAtual
            // 
            this.lblPlanetaAtual.AutoSize = true;
            this.lblPlanetaAtual.Location = new System.Drawing.Point(6, 27);
            this.lblPlanetaAtual.Name = "lblPlanetaAtual";
            this.lblPlanetaAtual.Size = new System.Drawing.Size(70, 13);
            this.lblPlanetaAtual.TabIndex = 3;
            this.lblPlanetaAtual.Text = "Planeta Atual";
            // 
            // btnRetornar
            // 
            this.btnRetornar.ForeColor = System.Drawing.Color.Black;
            this.btnRetornar.Location = new System.Drawing.Point(10, 160);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(121, 32);
            this.btnRetornar.TabIndex = 2;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnMudarPlaneta
            // 
            this.btnMudarPlaneta.ForeColor = System.Drawing.Color.Black;
            this.btnMudarPlaneta.Location = new System.Drawing.Point(10, 122);
            this.btnMudarPlaneta.Name = "btnMudarPlaneta";
            this.btnMudarPlaneta.Size = new System.Drawing.Size(121, 32);
            this.btnMudarPlaneta.TabIndex = 1;
            this.btnMudarPlaneta.Text = "Mudar de planeta";
            this.btnMudarPlaneta.UseVisualStyleBackColor = true;
            this.btnMudarPlaneta.Click += new System.EventHandler(this.btnMudarPlaneta_Click);
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.ForeColor = System.Drawing.Color.Black;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(8, 95);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(121, 21);
            this.cmbPlanetas.TabIndex = 0;
            // 
            // pbAlienManager
            // 
            this.pbAlienManager.Image = global::GerenciadorDeOVNI.Properties.Resources.alien_2;
            this.pbAlienManager.Location = new System.Drawing.Point(315, 39);
            this.pbAlienManager.Name = "pbAlienManager";
            this.pbAlienManager.Size = new System.Drawing.Size(156, 232);
            this.pbAlienManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlienManager.TabIndex = 8;
            this.pbAlienManager.TabStop = false;
            // 
            // pbTerra
            // 
            this.pbTerra.Image = global::GerenciadorDeOVNI.Properties.Resources.terra;
            this.pbTerra.Location = new System.Drawing.Point(81, 12);
            this.pbTerra.Name = "pbTerra";
            this.pbTerra.Size = new System.Drawing.Size(50, 39);
            this.pbTerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTerra.TabIndex = 9;
            this.pbTerra.TabStop = false;
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(483, 336);
            this.Controls.Add(this.pbAlienManager);
            this.Controls.Add(this.grbPlaneta);
            this.Controls.Add(this.grbAbduzidos);
            this.Controls.Add(this.grbTripulantes);
            this.Controls.Add(this.grbInformacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbTripulantes.ResumeLayout(false);
            this.grbAbduzidos.ResumeLayout(false);
            this.grbPlaneta.ResumeLayout(false);
            this.grbPlaneta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlienManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTerra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.GroupBox grbTripulantes;
        private System.Windows.Forms.Button btnRemoverTrip;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.GroupBox grbAbduzidos;
        private System.Windows.Forms.Button btnDesabduzir;
        private System.Windows.Forms.Button btnAbduzir;
        private System.Windows.Forms.GroupBox grbPlaneta;
        private System.Windows.Forms.Button btnMudarPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.TextBox txbPlaneta;
        private System.Windows.Forms.Label lblPlanetaAtual;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.PictureBox pbAlienManager;
        private System.Windows.Forms.PictureBox pbTerra;
    }
}