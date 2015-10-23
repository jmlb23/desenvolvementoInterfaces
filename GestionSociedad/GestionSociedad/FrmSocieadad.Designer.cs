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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNben = new System.Windows.Forms.Label();
            this.lblNsoc = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.cmbSocio = new System.Windows.Forms.ComboBox();
            this.lstBeneficiarios = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNsocio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Socios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Beneficiarios:";
            // 
            // lblNben
            // 
            this.lblNben.AutoSize = true;
            this.lblNben.Location = new System.Drawing.Point(212, 77);
            this.lblNben.Name = "lblNben";
            this.lblNben.Size = new System.Drawing.Size(13, 13);
            this.lblNben.TabIndex = 3;
            this.lblNben.Text = "0";
            // 
            // lblNsoc
            // 
            this.lblNsoc.AutoSize = true;
            this.lblNsoc.Location = new System.Drawing.Point(212, 38);
            this.lblNsoc.Name = "lblNsoc";
            this.lblNsoc.Size = new System.Drawing.Size(13, 13);
            this.lblNsoc.TabIndex = 2;
            this.lblNsoc.Text = "0";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(67, 164);
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
            this.groupBox1.Location = new System.Drawing.Point(291, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 321);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de beneficiarios por socio";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Beneficiarios/as";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblNif);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblNsocio);
            this.groupBox2.Location = new System.Drawing.Point(291, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 258);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Socio";
            // 
            // lblNsocio
            // 
            this.lblNsocio.AutoSize = true;
            this.lblNsocio.Location = new System.Drawing.Point(165, 16);
            this.lblNsocio.Name = "lblNsocio";
            this.lblNsocio.Size = new System.Drawing.Size(0, 13);
            this.lblNsocio.TabIndex = 0;
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
            // FrmSocieadad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.lblNben);
            this.Controls.Add(this.lblNsoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSocieadad";
            this.Text = "Gestion de sociedad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

