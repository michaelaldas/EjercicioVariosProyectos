namespace LlamandoDesdeWin
{
    partial class Tarea
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSuma1 = new System.Windows.Forms.TextBox();
            this.TxtSuma2 = new System.Windows.Forms.TextBox();
            this.TxtFac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtResSu = new System.Windows.Forms.TextBox();
            this.TxtResFa = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese primer numero que desee sumar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese segundo numero que desee sumar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese numero que desee factoriar:";
            // 
            // TxtSuma1
            // 
            this.TxtSuma1.Location = new System.Drawing.Point(273, 29);
            this.TxtSuma1.Name = "TxtSuma1";
            this.TxtSuma1.Size = new System.Drawing.Size(99, 20);
            this.TxtSuma1.TabIndex = 4;
            // 
            // TxtSuma2
            // 
            this.TxtSuma2.Location = new System.Drawing.Point(273, 63);
            this.TxtSuma2.Name = "TxtSuma2";
            this.TxtSuma2.Size = new System.Drawing.Size(99, 20);
            this.TxtSuma2.TabIndex = 5;
            // 
            // TxtFac
            // 
            this.TxtFac.Location = new System.Drawing.Point(273, 89);
            this.TxtFac.Name = "TxtFac";
            this.TxtFac.Size = new System.Drawing.Size(100, 20);
            this.TxtFac.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Suma =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Factorial =";
            // 
            // TxtResSu
            // 
            this.TxtResSu.Location = new System.Drawing.Point(111, 219);
            this.TxtResSu.Name = "TxtResSu";
            this.TxtResSu.Size = new System.Drawing.Size(100, 20);
            this.TxtResSu.TabIndex = 9;
            // 
            // TxtResFa
            // 
            this.TxtResFa.Location = new System.Drawing.Point(111, 249);
            this.TxtResFa.Name = "TxtResFa";
            this.TxtResFa.Size = new System.Drawing.Size(100, 20);
            this.TxtResFa.TabIndex = 10;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(111, 141);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(167, 52);
            this.BtnCalcular.TabIndex = 11;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtResFa);
            this.Controls.Add(this.TxtResSu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFac);
            this.Controls.Add(this.TxtSuma2);
            this.Controls.Add(this.TxtSuma1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tarea";
            this.Text = "LlamadoFuncion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSuma1;
        private System.Windows.Forms.TextBox TxtSuma2;
        private System.Windows.Forms.TextBox TxtFac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtResSu;
        private System.Windows.Forms.TextBox TxtResFa;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

