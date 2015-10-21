namespace ListaMultiple
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstPresentados = new System.Windows.Forms.ListBox();
            this.lstContratados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPasaTodos = new System.Windows.Forms.Button();
            this.btnPasaSele = new System.Windows.Forms.Button();
            this.btnQuitarT = new System.Windows.Forms.Button();
            this.btnQuitarS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dlgDialogoAbrir = new System.Windows.Forms.OpenFileDialog();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnElexirImaxen = new System.Windows.Forms.Button();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCargar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPresentados
            // 
            this.lstPresentados.FormattingEnabled = true;
            this.lstPresentados.Location = new System.Drawing.Point(260, 57);
            this.lstPresentados.Name = "lstPresentados";
            this.lstPresentados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPresentados.Size = new System.Drawing.Size(101, 173);
            this.lstPresentados.TabIndex = 0;
            // 
            // lstContratados
            // 
            this.lstContratados.FormattingEnabled = true;
            this.lstContratados.Location = new System.Drawing.Point(756, 57);
            this.lstContratados.Name = "lstContratados";
            this.lstContratados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstContratados.Size = new System.Drawing.Size(124, 173);
            this.lstContratados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Presentados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contratados";
            // 
            // btnPasaTodos
            // 
            this.btnPasaTodos.Location = new System.Drawing.Point(461, 105);
            this.btnPasaTodos.Name = "btnPasaTodos";
            this.btnPasaTodos.Size = new System.Drawing.Size(197, 23);
            this.btnPasaTodos.TabIndex = 4;
            this.btnPasaTodos.Text = "Pasar Todos";
            this.btnPasaTodos.UseVisualStyleBackColor = true;
            // 
            // btnPasaSele
            // 
            this.btnPasaSele.Location = new System.Drawing.Point(461, 66);
            this.btnPasaSele.Name = "btnPasaSele";
            this.btnPasaSele.Size = new System.Drawing.Size(197, 23);
            this.btnPasaSele.TabIndex = 5;
            this.btnPasaSele.Text = "Pasar selecionados";
            this.btnPasaSele.UseVisualStyleBackColor = true;
            // 
            // btnQuitarT
            // 
            this.btnQuitarT.Location = new System.Drawing.Point(461, 147);
            this.btnQuitarT.Name = "btnQuitarT";
            this.btnQuitarT.Size = new System.Drawing.Size(197, 23);
            this.btnQuitarT.TabIndex = 6;
            this.btnQuitarT.Text = "Quitar Todos";
            this.btnQuitarT.UseVisualStyleBackColor = true;
            // 
            // btnQuitarS
            // 
            this.btnQuitarS.Location = new System.Drawing.Point(461, 188);
            this.btnQuitarS.Name = "btnQuitarS";
            this.btnQuitarS.Size = new System.Drawing.Size(197, 23);
            this.btnQuitarS.TabIndex = 7;
            this.btnQuitarS.Text = "Quitar Selecionados";
            this.btnQuitarS.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(260, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 106);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dlgDialogoAbrir
            // 
            this.dlgDialogoAbrir.FileName = "openFileDialog1";
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "maria_carlos.png");
            this.imgList.Images.SetKeyName(1, "maria_incio.png");
            this.imgList.Images.SetKeyName(2, "nc.PNG");
            this.imgList.Images.SetKeyName(3, "nmap.PNG");
            this.imgList.Images.SetKeyName(4, "ping.PNG");
            this.imgList.Images.SetKeyName(5, "raul_inicio.png");
            this.imgList.Images.SetKeyName(6, "sofia_inicio.png");
            this.imgList.Images.SetKeyName(7, "sofia_raul.png");
            this.imgList.Images.SetKeyName(8, "telnet.PNG");
            // 
            // btnElexirImaxen
            // 
            this.btnElexirImaxen.Location = new System.Drawing.Point(489, 257);
            this.btnElexirImaxen.Name = "btnElexirImaxen";
            this.btnElexirImaxen.Size = new System.Drawing.Size(134, 23);
            this.btnElexirImaxen.TabIndex = 9;
            this.btnElexirImaxen.Text = "Elixe unha imaxe";
            this.btnElexirImaxen.UseVisualStyleBackColor = true;
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(907, 24);
            this.mnuPrincipal.TabIndex = 10;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCargar,
            this.mnuGuardar,
            this.toolStripMenuItem1,
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "&Archivo";
            // 
            // mnuCargar
            // 
            this.mnuCargar.Name = "mnuCargar";
            this.mnuCargar.Size = new System.Drawing.Size(160, 22);
            this.mnuCargar.Text = "&Cargar Alumnos";
            // 
            // mnuGuardar
            // 
            this.mnuGuardar.Name = "mnuGuardar";
            this.mnuGuardar.Size = new System.Drawing.Size(160, 22);
            this.mnuGuardar.Text = "&Gardar Datos";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(160, 22);
            this.mnuSalir.Text = "&Salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 422);
            this.Controls.Add(this.btnElexirImaxen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuitarS);
            this.Controls.Add(this.btnQuitarT);
            this.Controls.Add(this.btnPasaSele);
            this.Controls.Add(this.btnPasaTodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstContratados);
            this.Controls.Add(this.lstPresentados);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "Form1";
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPresentados;
        private System.Windows.Forms.ListBox lstContratados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPasaTodos;
        private System.Windows.Forms.Button btnPasaSele;
        private System.Windows.Forms.Button btnQuitarT;
        private System.Windows.Forms.Button btnQuitarS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog dlgDialogoAbrir;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Button btnElexirImaxen;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuCargar;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}

