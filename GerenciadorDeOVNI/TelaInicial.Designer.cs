namespace GerenciadorDeOVNI
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.lbltTrip = new System.Windows.Forms.Label();
            this.txbTrip = new System.Windows.Forms.TextBox();
            this.txbAbd = new System.Windows.Forms.TextBox();
            this.lblAbd = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltTrip
            // 
            this.lbltTrip.AutoSize = true;
            this.lbltTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltTrip.ForeColor = System.Drawing.Color.White;
            this.lbltTrip.Location = new System.Drawing.Point(45, 276);
            this.lbltTrip.Name = "lbltTrip";
            this.lbltTrip.Size = new System.Drawing.Size(199, 24);
            this.lbltTrip.TabIndex = 0;
            this.lbltTrip.Text = "Máximo de tripulantes:";
            // 
            // txbTrip
            // 
            this.txbTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTrip.Location = new System.Drawing.Point(264, 271);
            this.txbTrip.Name = "txbTrip";
            this.txbTrip.Size = new System.Drawing.Size(141, 29);
            this.txbTrip.TabIndex = 1;
            // 
            // txbAbd
            // 
            this.txbAbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAbd.Location = new System.Drawing.Point(264, 318);
            this.txbAbd.Name = "txbAbd";
            this.txbAbd.Size = new System.Drawing.Size(141, 29);
            this.txbAbd.TabIndex = 3;
            // 
            // lblAbd
            // 
            this.lblAbd.AutoSize = true;
            this.lblAbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbd.ForeColor = System.Drawing.Color.White;
            this.lblAbd.Location = new System.Drawing.Point(45, 323);
            this.lblAbd.Name = "lblAbd";
            this.lblAbd.Size = new System.Drawing.Size(201, 24);
            this.lblAbd.TabIndex = 2;
            this.lblAbd.Text = "Máximo de abduzidos:";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigem.ForeColor = System.Drawing.Color.White;
            this.lblOrigem.Location = new System.Drawing.Point(76, 371);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(168, 24);
            this.lblOrigem.TabIndex = 4;
            this.lblOrigem.Text = "Planeta de origem:";
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(264, 363);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(141, 32);
            this.cmbPlanetas.TabIndex = 5;
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(131, 432);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(219, 52);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(111, 224);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 24);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Onde iremos abduzir hoje?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciadorDeOVNI.Properties.Resources.alien;
            this.pictureBox1.Location = new System.Drawing.Point(80, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(439, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.txbAbd);
            this.Controls.Add(this.lblAbd);
            this.Controls.Add(this.txbTrip);
            this.Controls.Add(this.lbltTrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltTrip;
        private System.Windows.Forms.TextBox txbTrip;
        private System.Windows.Forms.TextBox txbAbd;
        private System.Windows.Forms.Label lblAbd;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblTitulo;
    }
}