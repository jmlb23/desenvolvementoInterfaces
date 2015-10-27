namespace GestionSociedad
{
    partial class FrmAux
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumeroSocio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCamcelar = new System.Windows.Forms.Button();
            this.btnAcep = new System.Windows.Forms.Button();
            this.chkBaixa = new System.Windows.Forms.CheckBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumeroSocio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCamcelar);
            this.groupBox1.Controls.Add(this.btnAcep);
            this.groupBox1.Controls.Add(this.chkBaixa);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtNif);
            this.groupBox1.Location = new System.Drawing.Point(29, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores do Novo Socio";
            // 
            // lblNumeroSocio
            // 
            this.lblNumeroSocio.AutoSize = true;
            this.lblNumeroSocio.Location = new System.Drawing.Point(139, 27);
            this.lblNumeroSocio.Name = "lblNumeroSocio";
            this.lblNumeroSocio.Size = new System.Drawing.Size(0, 13);
            this.lblNumeroSocio.TabIndex = 10;
            this.lblNumeroSocio.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numero";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIF";
            // 
            // btnCamcelar
            // 
            this.btnCamcelar.Location = new System.Drawing.Point(379, 337);
            this.btnCamcelar.Name = "btnCamcelar";
            this.btnCamcelar.Size = new System.Drawing.Size(75, 23);
            this.btnCamcelar.TabIndex = 6;
            this.btnCamcelar.Text = "Cancelar";
            this.btnCamcelar.UseVisualStyleBackColor = true;
            // 
            // btnAcep
            // 
            this.btnAcep.Location = new System.Drawing.Point(88, 337);
            this.btnAcep.Name = "btnAcep";
            this.btnAcep.Size = new System.Drawing.Size(75, 23);
            this.btnAcep.TabIndex = 5;
            this.btnAcep.Text = "Aceptar";
            this.btnAcep.UseVisualStyleBackColor = true;
            // 
            // chkBaixa
            // 
            this.chkBaixa.AutoSize = true;
            this.chkBaixa.Location = new System.Drawing.Point(88, 186);
            this.chkBaixa.Name = "chkBaixa";
            this.chkBaixa.Size = new System.Drawing.Size(52, 17);
            this.chkBaixa.TabIndex = 4;
            this.chkBaixa.Text = "Baixa";
            this.chkBaixa.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkBaixa.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(88, 133);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(151, 20);
            this.dtpData.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 94);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(366, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(88, 53);
            this.txtNif.MaxLength = 10;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(151, 20);
            this.txtNif.TabIndex = 1;
            // 
            // FrmAux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 454);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAux";
            this.Text = "FrmAux";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumeroSocio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCamcelar;
        private System.Windows.Forms.Button btnAcep;
        private System.Windows.Forms.CheckBox chkBaixa;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNif;
    }
}