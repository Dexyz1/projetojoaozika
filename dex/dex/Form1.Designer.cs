namespace dex
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
            this.txbInput = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbTelefone = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNome = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(9, 45);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(204, 20);
            this.txbInput.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(8, 149);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 51);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_Click);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(121, 149);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(92, 51);
            this.btnLer.TabIndex = 2;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(9, 84);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(204, 20);
            this.txbTelefone.TabIndex = 3;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(9, 123);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(204, 20);
            this.txbEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome (txbInput)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone (txbTelefone)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email (txbEmail)";
            // 
            // rbTelefone
            // 
            this.rbTelefone.AutoSize = true;
            this.rbTelefone.Location = new System.Drawing.Point(242, 45);
            this.rbTelefone.Name = "rbTelefone";
            this.rbTelefone.Size = new System.Drawing.Size(127, 17);
            this.rbTelefone.TabIndex = 8;
            this.rbTelefone.TabStop = true;
            this.rbTelefone.Text = "Telefone (rbTelefone)";
            this.rbTelefone.UseVisualStyleBackColor = true;
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(242, 68);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(93, 17);
            this.rbEmail.TabIndex = 9;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Email (rbEmail)";
            this.rbEmail.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome Contato (cbxNome)";
            // 
            // cbxNome
            // 
            this.cbxNome.FormattingEnabled = true;
            this.cbxNome.Location = new System.Drawing.Point(242, 123);
            this.cbxNome.Name = "cbxNome";
            this.cbxNome.Size = new System.Drawing.Size(121, 21);
            this.cbxNome.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "RespostaNome (lbNome)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "RespostaEmail (lbEmail)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "RespostaTelefone (lbTelefone)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 301);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbEmail);
            this.Controls.Add(this.rbTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbTelefone;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

