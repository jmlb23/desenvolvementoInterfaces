namespace GestionSociedad
{
    partial class FrmSocieadad
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSocieadad));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNben = new System.Windows.Forms.Label();
            this.lblNsoc = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.cmbSocio = new System.Windows.Forms.ComboBox();
            this.lstBeneficiarios = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCuouta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipo2 = new System.Windows.Forms.ComboBox();
            this.chkBaixa = new System.Windows.Forms.CheckBox();
            this.dtdata = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNsocio = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModifica = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCuota = new System.Windows.Forms.ToolStripMenuItem();
            this.beneficiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNovoBen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrarBen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuElimina = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSnuevosocio = new System.Windows.Forms.ToolStripButton();
            this.TSElimina = new System.Windows.Forms.ToolStripButton();
            this.TSEdita = new System.Windows.Forms.ToolStripButton();
            this.TSCalcula = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSnovoBenef = new System.Windows.Forms.ToolStripButton();
            this.TSEliminaBenef = new System.Windows.Forms.ToolStripButton();
            this.TSsalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Socios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Beneficiarios:";
            // 
            // lblNben
            // 
            this.lblNben.AutoSize = true;
            this.lblNben.Location = new System.Drawing.Point(194, 167);
            this.lblNben.Name = "lblNben";
            this.lblNben.Size = new System.Drawing.Size(13, 13);
            this.lblNben.TabIndex = 3;
            this.lblNben.Text = "0";
            // 
            // lblNsoc
            // 
            this.lblNsoc.AutoSize = true;
            this.lblNsoc.Location = new System.Drawing.Point(194, 128);
            this.lblNsoc.Name = "lblNsoc";
            this.lblNsoc.Size = new System.Drawing.Size(13, 13);
            this.lblNsoc.TabIndex = 2;
            this.lblNsoc.Text = "0";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(49, 254);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(138, 23);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ver cantos hai";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // cmbSocio
            // 
            this.cmbSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSocio.FormattingEnabled = true;
            this.cmbSocio.Location = new System.Drawing.Point(155, 19);
            this.cmbSocio.Name = "cmbSocio";
            this.cmbSocio.Size = new System.Drawing.Size(389, 21);
            this.cmbSocio.TabIndex = 5;
            // 
            // lstBeneficiarios
            // 
            this.lstBeneficiarios.FormattingEnabled = true;
            this.lstBeneficiarios.Location = new System.Drawing.Point(155, 65);
            this.lstBeneficiarios.Name = "lstBeneficiarios";
            this.lstBeneficiarios.Size = new System.Drawing.Size(389, 225);
            this.lstBeneficiarios.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbSocio);
            this.groupBox1.Controls.Add(this.lstBeneficiarios);
            this.groupBox1.Location = new System.Drawing.Point(273, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 321);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de beneficiarios por socio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Beneficiarios/as";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selecione Socio/a";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCuouta);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbTipo2);
            this.groupBox2.Controls.Add(this.chkBaixa);
            this.groupBox2.Controls.Add(this.dtdata);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblNif);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblNsocio);
            this.groupBox2.Location = new System.Drawing.Point(273, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 258);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Socio";
            // 
            // lblCuouta
            // 
            this.lblCuouta.AutoSize = true;
            this.lblCuouta.Location = new System.Drawing.Point(419, 15);
            this.lblCuouta.Name = "lblCuouta";
            this.lblCuouta.Size = new System.Drawing.Size(0, 13);
            this.lblCuouta.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cuota:";
            // 
            // cmbTipo2
            // 
            this.cmbTipo2.Enabled = false;
            this.cmbTipo2.FormattingEnabled = true;
            this.cmbTipo2.Location = new System.Drawing.Point(101, 173);
            this.cmbTipo2.Name = "cmbTipo2";
            this.cmbTipo2.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo2.TabIndex = 14;
            // 
            // chkBaixa
            // 
            this.chkBaixa.AutoSize = true;
            this.chkBaixa.Enabled = false;
            this.chkBaixa.Location = new System.Drawing.Point(100, 146);
            this.chkBaixa.Name = "chkBaixa";
            this.chkBaixa.Size = new System.Drawing.Size(15, 14);
            this.chkBaixa.TabIndex = 13;
            this.chkBaixa.UseVisualStyleBackColor = true;
            // 
            // dtdata
            // 
            this.dtdata.Enabled = false;
            this.dtdata.Location = new System.Drawing.Point(93, 108);
            this.dtdata.Name = "dtdata";
            this.dtdata.Size = new System.Drawing.Size(200, 20);
            this.dtdata.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "TIpo Socio:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Baja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "FechaAlta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nombre";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(165, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "NIF:";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(165, 47);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(0, 13);
            this.lblNif.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Numero socio:";
            // 
            // lblNsocio
            // 
            this.lblNsocio.AutoSize = true;
            this.lblNsocio.Location = new System.Drawing.Point(165, 16);
            this.lblNsocio.Name = "lblNsocio";
            this.lblNsocio.Size = new System.Drawing.Size(0, 13);
            this.lblNsocio.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.beneficiarioToolStripMenuItem,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNovo,
            this.mnuBorra,
            this.mnuModifica,
            this.mnuCuota});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // mnuNovo
            // 
            this.mnuNovo.Name = "mnuNovo";
            this.mnuNovo.Size = new System.Drawing.Size(158, 22);
            this.mnuNovo.Text = "Novo";
            // 
            // mnuBorra
            // 
            this.mnuBorra.Name = "mnuBorra";
            this.mnuBorra.Size = new System.Drawing.Size(158, 22);
            this.mnuBorra.Text = "Borrar Selecion";
            // 
            // mnuModifica
            // 
            this.mnuModifica.Name = "mnuModifica";
            this.mnuModifica.Size = new System.Drawing.Size(158, 22);
            this.mnuModifica.Text = "Modificar Datos";
            // 
            // mnuCuota
            // 
            this.mnuCuota.Name = "mnuCuota";
            this.mnuCuota.Size = new System.Drawing.Size(158, 22);
            this.mnuCuota.Text = "Calcular Couta";
            // 
            // beneficiarioToolStripMenuItem
            // 
            this.beneficiarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNovoBen,
            this.mnuBorrarBen,
            this.mnuElimina});
            this.beneficiarioToolStripMenuItem.Name = "beneficiarioToolStripMenuItem";
            this.beneficiarioToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.beneficiarioToolStripMenuItem.Text = "Beneficiario";
            // 
            // mnuNovoBen
            // 
            this.mnuNovoBen.Name = "mnuNovoBen";
            this.mnuNovoBen.Size = new System.Drawing.Size(173, 22);
            this.mnuNovoBen.Text = "Novo";
            // 
            // mnuBorrarBen
            // 
            this.mnuBorrarBen.Name = "mnuBorrarBen";
            this.mnuBorrarBen.Size = new System.Drawing.Size(173, 22);
            this.mnuBorrarBen.Text = "Borrar Selecionado";
            // 
            // mnuElimina
            // 
            this.mnuElimina.Name = "mnuElimina";
            this.mnuElimina.Size = new System.Drawing.Size(173, 22);
            this.mnuElimina.Text = "Eliminar";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(41, 20);
            this.mnuSalir.Text = "Salir";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSnuevosocio,
            this.TSElimina,
            this.TSEdita,
            this.TSCalcula,
            this.toolStripSeparator1,
            this.TSnovoBenef,
            this.TSEliminaBenef,
            this.TSsalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(958, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSnuevosocio
            // 
            this.TSnuevosocio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSnuevosocio.Image = ((System.Drawing.Image)(resources.GetObject("TSnuevosocio.Image")));
            this.TSnuevosocio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSnuevosocio.Name = "TSnuevosocio";
            this.TSnuevosocio.Size = new System.Drawing.Size(23, 22);
            this.TSnuevosocio.Text = "Novo socio";
            // 
            // TSElimina
            // 
            this.TSElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSElimina.Image = ((System.Drawing.Image)(resources.GetObject("TSElimina.Image")));
            this.TSElimina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSElimina.Name = "TSElimina";
            this.TSElimina.Size = new System.Drawing.Size(23, 22);
            this.TSElimina.Text = "Borrar socio";
            // 
            // TSEdita
            // 
            this.TSEdita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSEdita.Image = ((System.Drawing.Image)(resources.GetObject("TSEdita.Image")));
            this.TSEdita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSEdita.Name = "TSEdita";
            this.TSEdita.Size = new System.Drawing.Size(23, 22);
            this.TSEdita.Text = "Editar socio";
            // 
            // TSCalcula
            // 
            this.TSCalcula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSCalcula.Image = ((System.Drawing.Image)(resources.GetObject("TSCalcula.Image")));
            this.TSCalcula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSCalcula.Name = "TSCalcula";
            this.TSCalcula.Size = new System.Drawing.Size(23, 22);
            this.TSCalcula.Text = "Calcular Cuota";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSnovoBenef
            // 
            this.TSnovoBenef.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSnovoBenef.Image = ((System.Drawing.Image)(resources.GetObject("TSnovoBenef.Image")));
            this.TSnovoBenef.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSnovoBenef.Name = "TSnovoBenef";
            this.TSnovoBenef.Size = new System.Drawing.Size(23, 22);
            this.TSnovoBenef.Text = "Novo beneficiario";
            // 
            // TSEliminaBenef
            // 
            this.TSEliminaBenef.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSEliminaBenef.Image = ((System.Drawing.Image)(resources.GetObject("TSEliminaBenef.Image")));
            this.TSEliminaBenef.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSEliminaBenef.Name = "TSEliminaBenef";
            this.TSEliminaBenef.Size = new System.Drawing.Size(23, 22);
            this.TSEliminaBenef.Text = "Eliminar beneficiario";
            // 
            // TSsalir
            // 
            this.TSsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSsalir.Image = ((System.Drawing.Image)(resources.GetObject("TSsalir.Image")));
            this.TSsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSsalir.Name = "TSsalir";
            this.TSsalir.Size = new System.Drawing.Size(23, 22);
            this.TSsalir.Text = "Sair";
            // 
            // FrmSocieadad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 694);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.lblNben);
            this.Controls.Add(this.lblNsoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmSocieadad";
            this.Text = "Gestion de sociedad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNben;
        private System.Windows.Forms.Label lblNsoc;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ComboBox cmbSocio;
        private System.Windows.Forms.ListBox lstBeneficiarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNsocio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNovo;
        private System.Windows.Forms.ToolStripMenuItem mnuBorra;
        private System.Windows.Forms.ToolStripMenuItem mnuModifica;
        private System.Windows.Forms.ToolStripMenuItem beneficiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNovoBen;
        private System.Windows.Forms.ToolStripMenuItem mnuBorrarBen;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ComboBox cmbTipo2;
        private System.Windows.Forms.CheckBox chkBaixa;
        private System.Windows.Forms.DateTimePicker dtdata;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStripMenuItem mnuCuota;
        private System.Windows.Forms.Label lblCuouta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem mnuElimina;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSnuevosocio;
        private System.Windows.Forms.ToolStripButton TSElimina;
        private System.Windows.Forms.ToolStripButton TSEdita;
        private System.Windows.Forms.ToolStripButton TSCalcula;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSnovoBenef;
        private System.Windows.Forms.ToolStripButton TSEliminaBenef;
        private System.Windows.Forms.ToolStripButton TSsalir;
    }
}

