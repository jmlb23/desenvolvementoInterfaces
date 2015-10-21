namespace Areas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtdous = new System.Windows.Forms.TextBox();
            this.lbldous = new System.Windows.Forms.Label();
            this.txtun = new System.Windows.Forms.TextBox();
            this.lblun = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFiguras = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtTriangulo = new System.Windows.Forms.RadioButton();
            this.rbtCirculo = new System.Windows.Forms.RadioButton();
            this.rbtCadrado = new System.Windows.Forms.RadioButton();
            this.rbtRectangulo = new System.Windows.Forms.RadioButton();
            this.txtTres = new System.Windows.Forms.TextBox();
            this.lbltres = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpFiguras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtTres);
            this.grpDatos.Controls.Add(this.lbltres);
            this.grpDatos.Controls.Add(this.txtdous);
            this.grpDatos.Controls.Add(this.lbldous);
            this.grpDatos.Controls.Add(this.txtun);
            this.grpDatos.Controls.Add(this.lblun);
            this.grpDatos.Location = new System.Drawing.Point(501, 41);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(318, 92);
            this.grpDatos.TabIndex = 7;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // txtdous
            // 
            this.txtdous.Location = new System.Drawing.Point(136, 21);
            this.txtdous.Name = "txtdous";
            this.txtdous.Size = new System.Drawing.Size(146, 22);
            this.txtdous.TabIndex = 7;
            // 
            // lbldous
            // 
            this.lbldous.AutoSize = true;
            this.lbldous.Location = new System.Drawing.Point(36, 24);
            this.lbldous.Name = "lbldous";
            this.lbldous.Size = new System.Drawing.Size(81, 17);
            this.lbldous.TabIndex = 6;
            this.lbldous.Text = "Radio (cm):";
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(136, 21);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(146, 22);
            this.txtun.TabIndex = 5;
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Location = new System.Drawing.Point(36, 24);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(76, 17);
            this.lblun.TabIndex = 4;
            this.lblun.Text = "Base (cm):";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(448, 372);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 39);
            this.lblResultado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultado (cm):";
            // 
            // grpFiguras
            // 
            this.grpFiguras.Controls.Add(this.pictureBox4);
            this.grpFiguras.Controls.Add(this.pictureBox3);
            this.grpFiguras.Controls.Add(this.pictureBox2);
            this.grpFiguras.Controls.Add(this.pictureBox1);
            this.grpFiguras.Controls.Add(this.rbtTriangulo);
            this.grpFiguras.Controls.Add(this.rbtCirculo);
            this.grpFiguras.Controls.Add(this.rbtCadrado);
            this.grpFiguras.Controls.Add(this.rbtRectangulo);
            this.grpFiguras.Location = new System.Drawing.Point(8, 41);
            this.grpFiguras.Name = "grpFiguras";
            this.grpFiguras.Size = new System.Drawing.Size(200, 271);
            this.grpFiguras.TabIndex = 4;
            this.grpFiguras.TabStop = false;
            this.grpFiguras.Text = "Figuras";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 192);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // rbtTriangulo
            // 
            this.rbtTriangulo.AutoSize = true;
            this.rbtTriangulo.Location = new System.Drawing.Point(74, 217);
            this.rbtTriangulo.Name = "rbtTriangulo";
            this.rbtTriangulo.Size = new System.Drawing.Size(89, 21);
            this.rbtTriangulo.TabIndex = 3;
            this.rbtTriangulo.TabStop = true;
            this.rbtTriangulo.Text = "Triangulo";
            this.rbtTriangulo.UseVisualStyleBackColor = true;
            // 
            // rbtCirculo
            // 
            this.rbtCirculo.AutoSize = true;
            this.rbtCirculo.Location = new System.Drawing.Point(74, 160);
            this.rbtCirculo.Name = "rbtCirculo";
            this.rbtCirculo.Size = new System.Drawing.Size(72, 21);
            this.rbtCirculo.TabIndex = 2;
            this.rbtCirculo.TabStop = true;
            this.rbtCirculo.Text = "Circulo";
            this.rbtCirculo.UseVisualStyleBackColor = true;
            // 
            // rbtCadrado
            // 
            this.rbtCadrado.AutoSize = true;
            this.rbtCadrado.Location = new System.Drawing.Point(74, 38);
            this.rbtCadrado.Name = "rbtCadrado";
            this.rbtCadrado.Size = new System.Drawing.Size(83, 21);
            this.rbtCadrado.TabIndex = 1;
            this.rbtCadrado.TabStop = true;
            this.rbtCadrado.Text = "Cadrado";
            this.rbtCadrado.UseVisualStyleBackColor = true;
            // 
            // rbtRectangulo
            // 
            this.rbtRectangulo.AutoSize = true;
            this.rbtRectangulo.Location = new System.Drawing.Point(74, 97);
            this.rbtRectangulo.Name = "rbtRectangulo";
            this.rbtRectangulo.Size = new System.Drawing.Size(101, 21);
            this.rbtRectangulo.TabIndex = 0;
            this.rbtRectangulo.TabStop = true;
            this.rbtRectangulo.Text = "Rectangulo";
            this.rbtRectangulo.UseVisualStyleBackColor = true;
            // 
            // txtTres
            // 
            this.txtTres.Location = new System.Drawing.Point(136, 49);
            this.txtTres.Name = "txtTres";
            this.txtTres.Size = new System.Drawing.Size(146, 22);
            this.txtTres.TabIndex = 9;
            // 
            // lbltres
            // 
            this.lbltres.AutoSize = true;
            this.lbltres.Location = new System.Drawing.Point(36, 52);
            this.lbltres.Name = "lbltres";
            this.lbltres.Size = new System.Drawing.Size(81, 17);
            this.lbltres.TabIndex = 8;
            this.lbltres.Text = "Altura (cm):";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(540, 177);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(243, 32);
            this.btnCalcula.TabIndex = 8;
            this.btnCalcula.Text = "Area";
            this.btnCalcula.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 489);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpFiguras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpFiguras.ResumeLayout(false);
            this.grpFiguras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtdous;
        private System.Windows.Forms.Label lbldous;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFiguras;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtTriangulo;
        private System.Windows.Forms.RadioButton rbtCirculo;
        private System.Windows.Forms.RadioButton rbtCadrado;
        private System.Windows.Forms.RadioButton rbtRectangulo;
        private System.Windows.Forms.TextBox txtTres;
        private System.Windows.Forms.Label lbltres;
        private System.Windows.Forms.Button btnCalcula;
    }
}

