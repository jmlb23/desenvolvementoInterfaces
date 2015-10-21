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
            this.btnVer.Text = "Ver cuantos hai";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // FrmSocieadad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 362);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.lblNben);
            this.Controls.Add(this.lblNsoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSocieadad";
            this.Text = "Gestion de sociedad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNben;
        private System.Windows.Forms.Label lblNsoc;
        private System.Windows.Forms.Button btnVer;
    }
}

