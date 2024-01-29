namespace Cadastrar_Perguntas
{
    partial class FrmCadastrarPergunta
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
            this.rtxPergunta = new System.Windows.Forms.RichTextBox();
            this.txbAlternativaA = new System.Windows.Forms.TextBox();
            this.txbAlternativaB = new System.Windows.Forms.TextBox();
            this.txbAlternativaC = new System.Windows.Forms.TextBox();
            this.txbAlternativaD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rbAlternativaCorretaA = new System.Windows.Forms.RadioButton();
            this.rbAlternativaCorretaB = new System.Windows.Forms.RadioButton();
            this.rbAlternativaCorretaC = new System.Windows.Forms.RadioButton();
            this.rbAlternativaCorretaD = new System.Windows.Forms.RadioButton();
            this.btnJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxPergunta
            // 
            this.rtxPergunta.Location = new System.Drawing.Point(12, 12);
            this.rtxPergunta.Name = "rtxPergunta";
            this.rtxPergunta.Size = new System.Drawing.Size(424, 221);
            this.rtxPergunta.TabIndex = 0;
            this.rtxPergunta.Text = "";
            this.rtxPergunta.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txbAlternativaA
            // 
            this.txbAlternativaA.Location = new System.Drawing.Point(28, 240);
            this.txbAlternativaA.Name = "txbAlternativaA";
            this.txbAlternativaA.Size = new System.Drawing.Size(381, 20);
            this.txbAlternativaA.TabIndex = 1;
            // 
            // txbAlternativaB
            // 
            this.txbAlternativaB.Location = new System.Drawing.Point(28, 267);
            this.txbAlternativaB.Name = "txbAlternativaB";
            this.txbAlternativaB.Size = new System.Drawing.Size(381, 20);
            this.txbAlternativaB.TabIndex = 2;
            // 
            // txbAlternativaC
            // 
            this.txbAlternativaC.Location = new System.Drawing.Point(28, 294);
            this.txbAlternativaC.Name = "txbAlternativaC";
            this.txbAlternativaC.Size = new System.Drawing.Size(381, 20);
            this.txbAlternativaC.TabIndex = 3;
            // 
            // txbAlternativaD
            // 
            this.txbAlternativaD.Location = new System.Drawing.Point(28, 321);
            this.txbAlternativaD.Name = "txbAlternativaD";
            this.txbAlternativaD.Size = new System.Drawing.Size(381, 20);
            this.txbAlternativaD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "a)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "b)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "c)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "d)";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(76, 347);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(132, 48);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rbAlternativaCorretaA
            // 
            this.rbAlternativaCorretaA.AutoSize = true;
            this.rbAlternativaCorretaA.Location = new System.Drawing.Point(415, 243);
            this.rbAlternativaCorretaA.Name = "rbAlternativaCorretaA";
            this.rbAlternativaCorretaA.Size = new System.Drawing.Size(14, 13);
            this.rbAlternativaCorretaA.TabIndex = 10;
            this.rbAlternativaCorretaA.TabStop = true;
            this.rbAlternativaCorretaA.UseVisualStyleBackColor = true;
            // 
            // rbAlternativaCorretaB
            // 
            this.rbAlternativaCorretaB.AutoSize = true;
            this.rbAlternativaCorretaB.Location = new System.Drawing.Point(415, 270);
            this.rbAlternativaCorretaB.Name = "rbAlternativaCorretaB";
            this.rbAlternativaCorretaB.Size = new System.Drawing.Size(14, 13);
            this.rbAlternativaCorretaB.TabIndex = 11;
            this.rbAlternativaCorretaB.TabStop = true;
            this.rbAlternativaCorretaB.UseVisualStyleBackColor = true;
            // 
            // rbAlternativaCorretaC
            // 
            this.rbAlternativaCorretaC.AutoSize = true;
            this.rbAlternativaCorretaC.Location = new System.Drawing.Point(415, 301);
            this.rbAlternativaCorretaC.Name = "rbAlternativaCorretaC";
            this.rbAlternativaCorretaC.Size = new System.Drawing.Size(14, 13);
            this.rbAlternativaCorretaC.TabIndex = 12;
            this.rbAlternativaCorretaC.TabStop = true;
            this.rbAlternativaCorretaC.UseVisualStyleBackColor = true;
            // 
            // rbAlternativaCorretaD
            // 
            this.rbAlternativaCorretaD.AutoSize = true;
            this.rbAlternativaCorretaD.Location = new System.Drawing.Point(415, 324);
            this.rbAlternativaCorretaD.Name = "rbAlternativaCorretaD";
            this.rbAlternativaCorretaD.Size = new System.Drawing.Size(14, 13);
            this.rbAlternativaCorretaD.TabIndex = 13;
            this.rbAlternativaCorretaD.TabStop = true;
            this.rbAlternativaCorretaD.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(243, 347);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(132, 48);
            this.btnJogar.TabIndex = 14;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // FrmCadastrarPergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 407);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.rbAlternativaCorretaD);
            this.Controls.Add(this.rbAlternativaCorretaC);
            this.Controls.Add(this.rbAlternativaCorretaB);
            this.Controls.Add(this.rbAlternativaCorretaA);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAlternativaD);
            this.Controls.Add(this.txbAlternativaC);
            this.Controls.Add(this.txbAlternativaB);
            this.Controls.Add(this.txbAlternativaA);
            this.Controls.Add(this.rtxPergunta);
            this.Name = "FrmCadastrarPergunta";
            this.Text = "Cadastrar Perguntas";
            this.Load += new System.EventHandler(this.FrmCadastrarPergunta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxPergunta;
        private System.Windows.Forms.TextBox txbAlternativaA;
        private System.Windows.Forms.TextBox txbAlternativaB;
        private System.Windows.Forms.TextBox txbAlternativaC;
        private System.Windows.Forms.TextBox txbAlternativaD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton rbAlternativaCorretaA;
        private System.Windows.Forms.RadioButton rbAlternativaCorretaB;
        private System.Windows.Forms.RadioButton rbAlternativaCorretaC;
        private System.Windows.Forms.RadioButton rbAlternativaCorretaD;
        private System.Windows.Forms.Button btnJogar;
    }
}

