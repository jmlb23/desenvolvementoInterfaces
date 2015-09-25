namespace proba
{
    partial class FrmEjerc
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
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.txtUn = new System.Windows.Forms.TextBox();
            this.txtDous = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(175, 101);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.operacion);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(256, 101);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.operacion);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(175, 130);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 23);
            this.btnMul.TabIndex = 2;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.operacion);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(256, 130);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.operacion);
            // 
            // txtUn
            // 
            this.txtUn.Location = new System.Drawing.Point(46, 116);
            this.txtUn.Name = "txtUn";
            this.txtUn.Size = new System.Drawing.Size(100, 20);
            this.txtUn.TabIndex = 4;
            // 
            // txtDous
            // 
            this.txtDous.Location = new System.Drawing.Point(366, 116);
            this.txtDous.Name = "txtDous";
            this.txtDous.Size = new System.Drawing.Size(100, 20);
            this.txtDous.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(224, 252);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(96, 15);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "                             ";
            // 
            // FrmEjerc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 340);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtDous);
            this.Controls.Add(this.txtUn);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Name = "FrmEjerc";
            this.Text = "FrmEjerc";
            this.Load += new System.EventHandler(this.FrmEjerc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox txtUn;
        private System.Windows.Forms.TextBox txtDous;
        private System.Windows.Forms.Label lblResult;

    }
}