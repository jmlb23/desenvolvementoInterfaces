namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lstNomes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblLista2 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.btnBorra2 = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnComboLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNomes
            // 
            this.lstNomes.FormattingEnabled = true;
            this.lstNomes.Location = new System.Drawing.Point(12, 154);
            this.lstNomes.Name = "lstNomes";
            this.lstNomes.Size = new System.Drawing.Size(120, 95);
            this.lstNomes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(181, 68);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "engadir";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(181, 226);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 5;
            this.btnLista.Text = ">";
            this.btnLista.UseVisualStyleBackColor = true;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(160, 285);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(0, 13);
            this.lblLista.TabIndex = 6;
            // 
            // lblLista2
            // 
            this.lblLista2.AutoSize = true;
            this.lblLista2.Location = new System.Drawing.Point(160, 312);
            this.lblLista2.Name = "lblLista2";
            this.lblLista2.Size = new System.Drawing.Size(0, 13);
            this.lblLista2.TabIndex = 7;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(181, 150);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "borra";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // cmbNome
            // 
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.Location = new System.Drawing.Point(317, 68);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(156, 21);
            this.cmbNome.TabIndex = 9;
            // 
            // btnBorra2
            // 
            this.btnBorra2.Location = new System.Drawing.Point(317, 105);
            this.btnBorra2.Name = "btnBorra2";
            this.btnBorra2.Size = new System.Drawing.Size(75, 23);
            this.btnBorra2.TabIndex = 11;
            this.btnBorra2.Text = "borra";
            this.btnBorra2.UseVisualStyleBackColor = true;
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(317, 138);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(75, 23);
            this.btnCombo.TabIndex = 12;
            this.btnCombo.Text = "Agrega";
            this.btnCombo.UseVisualStyleBackColor = true;
            // 
            // btnComboLista
            // 
            this.btnComboLista.Location = new System.Drawing.Point(317, 231);
            this.btnComboLista.Name = "btnComboLista";
            this.btnComboLista.Size = new System.Drawing.Size(75, 23);
            this.btnComboLista.TabIndex = 13;
            this.btnComboLista.Text = ">";
            this.btnComboLista.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 331);
            this.Controls.Add(this.btnComboLista);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.btnBorra2);
            this.Controls.Add(this.cmbNome);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblLista2);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNomes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNomes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblLista2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbNome;
        private System.Windows.Forms.Button btnBorra2;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnComboLista;

    }
}

