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
            this.txtNomeDelegado = new System.Windows.Forms.TextBox();
            this.txtNomeSubdele = new System.Windows.Forms.TextBox();
            this.txtVotosSubdele = new System.Windows.Forms.TextBox();
            this.txtVotosDelegado = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.ItemHeight = 16;
            this.lstAlumnos.Location = new System.Drawing.Point(26, 44);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(321, 436);
            this.lstAlumnos.TabIndex = 1;
            // 
            // lstVotados
            // 
            this.lstVotados.FormattingEnabled = true;
            this.lstVotados.ItemHeight = 16;
            this.lstVotados.Location = new System.Drawing.Point(516, 44);
            this.lstVotados.Name = "lstVotados";
            this.lstVotados.Size = new System.Drawing.Size(321, 436);
            this.lstVotados.TabIndex = 2;
            // 
            // lstVotos
            // 
            this.lstVotos.FormattingEnabled = true;
            this.lstVotos.ItemHeight = 16;
            this.lstVotos.Location = new System.Drawing.Point(837, 44);
            this.lstVotos.Name = "lstVotos";
            this.lstVotos.Size = new System.Drawing.Size(120, 436);
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
            this.menuStrip1.Size = new System.Drawing.Size(1120, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCarga
            // 
            this.mnuCarga.Name = "mnuCarga";
            this.mnuCarga.Size = new System.Drawing.Size(127, 24);
            this.mnuCarga.Text = "Cargar Alumnos";
            // 
            // mnuGraba
            // 
            this.mnuGraba.Name = "mnuGraba";
            this.mnuGraba.Size = new System.Drawing.Size(134, 24);
            this.mnuGraba.Text = "Grabar Escrutinio";
            // 
            // mnuOrdena
            // 
            this.mnuOrdena.Name = "mnuOrdena";
            this.mnuOrdena.Size = new System.Drawing.Size(75, 24);
            this.mnuOrdena.Text = "Ordenar";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(50, 24);
            this.mnuSalir.Text = "Salir";
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(399, 122);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(75, 23);
            this.btnMais.TabIndex = 5;
            this.btnMais.Text = "+1";
            this.btnMais.UseVisualStyleBackColor = true;
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(399, 285);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 23);
            this.btnMenos.TabIndex = 6;
            this.btnMenos.Text = "-1";
            this.btnMenos.UseVisualStyleBackColor = true;
            // 
            // btnOrdena
            // 
            this.btnOrdena.Location = new System.Drawing.Point(516, 495);
            this.btnOrdena.Name = "btnOrdena";
            this.btnOrdena.Size = new System.Drawing.Size(321, 28);
            this.btnOrdena.TabIndex = 7;
            this.btnOrdena.Text = "Ordenar";
            this.btnOrdena.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Delegado/a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Subdelegado/a";
            // 
            // txtNomeDelegado
            // 
            this.txtNomeDelegado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDelegado.Location = new System.Drawing.Point(285, 535);
            this.txtNomeDelegado.Name = "txtNomeDelegado";
            this.txtNomeDelegado.ReadOnly = true;
            this.txtNomeDelegado.Size = new System.Drawing.Size(391, 34);
            this.txtNomeDelegado.TabIndex = 10;
            // 
            // txtNomeSubdele
            // 
            this.txtNomeSubdele.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSubdele.Location = new System.Drawing.Point(285, 585);
            this.txtNomeSubdele.Name = "txtNomeSubdele";
            this.txtNomeSubdele.ReadOnly = true;
            this.txtNomeSubdele.Size = new System.Drawing.Size(391, 34);
            this.txtNomeSubdele.TabIndex = 11;
            // 
            // txtVotosSubdele
            // 
            this.txtVotosSubdele.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVotosSubdele.Location = new System.Drawing.Point(722, 585);
            this.txtVotosSubdele.Name = "txtVotosSubdele";
            this.txtVotosSubdele.ReadOnly = true;
            this.txtVotosSubdele.Size = new System.Drawing.Size(61, 34);
            this.txtVotosSubdele.TabIndex = 13;
            // 
            // txtVotosDelegado
            // 
            this.txtVotosDelegado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVotosDelegado.Location = new System.Drawing.Point(722, 535);
            this.txtVotosDelegado.Name = "txtVotosDelegado";
            this.txtVotosDelegado.ReadOnly = true;
            this.txtVotosDelegado.Size = new System.Drawing.Size(61, 34);
            this.txtVotosDelegado.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 642);
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
        private System.Windows.Forms.TextBox txtNomeDelegado;
        private System.Windows.Forms.TextBox txtNomeSubdele;
        private System.Windows.Forms.TextBox txtVotosSubdele;
        private System.Windows.Forms.TextBox txtVotosDelegado;
    }
}

