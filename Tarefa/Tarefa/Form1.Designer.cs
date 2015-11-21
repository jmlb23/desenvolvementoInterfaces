namespace Tarefa
{
    partial class Form1
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
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.lstVotados = new System.Windows.Forms.ListBox();
            this.lstVotos = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCarga = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGraba = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrdena = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnOrdena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeDelegado = new System.Windows.Forms.Label();
            this.txtNomeSubdele = new System.Windows.Forms.Label();
            this.txtVotosDelegado = new System.Windows.Forms.Label();
            this.txtVotosSubdele = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.Location = new System.Drawing.Point(20, 36);
            this.lstAlumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(242, 355);
            this.lstAlumnos.TabIndex = 1;
            // 
            // lstVotados
            // 
            this.lstVotados.FormattingEnabled = true;
            this.lstVotados.Location = new System.Drawing.Point(387, 36);
            this.lstVotados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstVotados.Name = "lstVotados";
            this.lstVotados.Size = new System.Drawing.Size(242, 355);
            this.lstVotados.TabIndex = 2;
            // 
            // lstVotos
            // 
            this.lstVotos.FormattingEnabled = true;
            this.lstVotos.Location = new System.Drawing.Point(628, 36);
            this.lstVotos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstVotos.Name = "lstVotos";
            this.lstVotos.Size = new System.Drawing.Size(91, 355);
            this.lstVotos.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCarga,
            this.mnuGraba,
            this.mnuOrdena,
            this.mnuSalir});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(840, 23);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCarga
            // 
            this.mnuCarga.Name = "mnuCarga";
            this.mnuCarga.Size = new System.Drawing.Size(105, 19);
            this.mnuCarga.Text = "Cargar Alumnos";
            // 
            // mnuGraba
            // 
            this.mnuGraba.Name = "mnuGraba";
            this.mnuGraba.Size = new System.Drawing.Size(109, 19);
            this.mnuGraba.Text = "Grabar Escrutinio";
            // 
            // mnuOrdena
            // 
            this.mnuOrdena.Name = "mnuOrdena";
            this.mnuOrdena.Size = new System.Drawing.Size(62, 19);
            this.mnuOrdena.Text = "Ordenar";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(41, 19);
            this.mnuSalir.Text = "Salir";
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(299, 99);
            this.btnMais.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(56, 19);
            this.btnMais.TabIndex = 5;
            this.btnMais.Text = "+1";
            this.btnMais.UseVisualStyleBackColor = true;
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(299, 232);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(56, 19);
            this.btnMenos.TabIndex = 6;
            this.btnMenos.Text = "-1";
            this.btnMenos.UseVisualStyleBackColor = true;
            // 
            // btnOrdena
            // 
            this.btnOrdena.Location = new System.Drawing.Point(387, 402);
            this.btnOrdena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdena.Name = "btnOrdena";
            this.btnOrdena.Size = new System.Drawing.Size(241, 23);
            this.btnOrdena.TabIndex = 7;
            this.btnOrdena.Text = "Ordenar";
            this.btnOrdena.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 437);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Delegado/a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 478);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Subdelegado/a";
            // 
            // txtNomeDelegado
            // 
            this.txtNomeDelegado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNomeDelegado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtNomeDelegado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDelegado.Location = new System.Drawing.Point(218, 429);
            this.txtNomeDelegado.Name = "txtNomeDelegado";
            this.txtNomeDelegado.Size = new System.Drawing.Size(343, 33);
            this.txtNomeDelegado.TabIndex = 10;
            // 
            // txtNomeSubdele
            // 
            this.txtNomeSubdele.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNomeSubdele.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtNomeSubdele.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSubdele.Location = new System.Drawing.Point(218, 467);
            this.txtNomeSubdele.Name = "txtNomeSubdele";
            this.txtNomeSubdele.Size = new System.Drawing.Size(343, 33);
            this.txtNomeSubdele.TabIndex = 11;
            // 
            // txtVotosDelegado
            // 
            this.txtVotosDelegado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtVotosDelegado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtVotosDelegado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVotosDelegado.Location = new System.Drawing.Point(582, 429);
            this.txtVotosDelegado.Name = "txtVotosDelegado";
            this.txtVotosDelegado.Size = new System.Drawing.Size(46, 33);
            this.txtVotosDelegado.TabIndex = 12;
            // 
            // txtVotosSubdele
            // 
            this.txtVotosSubdele.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtVotosSubdele.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtVotosSubdele.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVotosSubdele.Location = new System.Drawing.Point(582, 466);
            this.txtVotosSubdele.Name = "txtVotosSubdele";
            this.txtVotosSubdele.Size = new System.Drawing.Size(47, 35);
            this.txtVotosSubdele.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 522);
            this.Controls.Add(this.txtVotosSubdele);
            this.Controls.Add(this.txtVotosDelegado);
            this.Controls.Add(this.txtNomeSubdele);
            this.Controls.Add(this.txtNomeDelegado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrdena);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.lstVotos);
            this.Controls.Add(this.lstVotados);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.ListBox lstVotados;
        private System.Windows.Forms.ListBox lstVotos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCarga;
        private System.Windows.Forms.ToolStripMenuItem mnuGraba;
        private System.Windows.Forms.ToolStripMenuItem mnuOrdena;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnOrdena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNomeDelegado;
        private System.Windows.Forms.Label txtNomeSubdele;
        private System.Windows.Forms.Label txtVotosDelegado;
        private System.Windows.Forms.Label txtVotosSubdele;
    }
}

