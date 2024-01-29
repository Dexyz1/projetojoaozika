namespace odexyz
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnMaiorMenor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNumero3 = new System.Windows.Forms.TextBox();
            this.btnImparPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(39, 92);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 53);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbNumero1
            // 
            this.txbNumero1.Location = new System.Drawing.Point(39, 28);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(100, 20);
            this.txbNumero1.TabIndex = 1;
            this.txbNumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbNumero2
            // 
            this.txbNumero2.Location = new System.Drawing.Point(145, 28);
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(100, 20);
            this.txbNumero2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero 2";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(386, 28);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(55, 13);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "Resultado";
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(145, 92);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(106, 53);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(39, 163);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(100, 53);
            this.btnDividir.TabIndex = 7;
            this.btnDividir.Text = "Divisão";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(145, 163);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(106, 53);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "Multiplicação";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnMaiorMenor
            // 
            this.btnMaiorMenor.Location = new System.Drawing.Point(257, 78);
            this.btnMaiorMenor.Name = "btnMaiorMenor";
            this.btnMaiorMenor.Size = new System.Drawing.Size(94, 81);
            this.btnMaiorMenor.TabIndex = 9;
            this.btnMaiorMenor.Text = "Menor Maior";
            this.btnMaiorMenor.UseVisualStyleBackColor = true;
            this.btnMaiorMenor.Click += new System.EventHandler(this.btnMaiorMenor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Digite um numero:";
            // 
            // txbNumero3
            // 
            this.txbNumero3.Location = new System.Drawing.Point(254, 28);
            this.txbNumero3.Name = "txbNumero3";
            this.txbNumero3.Size = new System.Drawing.Size(100, 20);
            this.txbNumero3.TabIndex = 11;
            // 
            // btnImparPar
            // 
            this.btnImparPar.Location = new System.Drawing.Point(257, 165);
            this.btnImparPar.Name = "btnImparPar";
            this.btnImparPar.Size = new System.Drawing.Size(94, 79);
            this.btnImparPar.TabIndex = 12;
            this.btnImparPar.Text = "Impar ou Par";
            this.btnImparPar.UseVisualStyleBackColor = true;
            this.btnImparPar.Click += new System.EventHandler(this.btnImparPar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImparPar);
            this.Controls.Add(this.txbNumero3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMaiorMenor);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNumero2);
            this.Controls.Add(this.txbNumero1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbNumero1;
        private System.Windows.Forms.TextBox txbNumero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnMaiorMenor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNumero3;
        private System.Windows.Forms.Button btnImparPar;
    }
}

