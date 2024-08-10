namespace Projeto_Banco
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
            this.Lbl_Agencia = new System.Windows.Forms.Label();
            this.Lbl_NAgencia = new System.Windows.Forms.Label();
            this.Lbl_TitulatConta = new System.Windows.Forms.Label();
            this.Txt_Agencia = new System.Windows.Forms.TextBox();
            this.Txt_NConta = new System.Windows.Forms.TextBox();
            this.Txt_TitularConta = new System.Windows.Forms.TextBox();
            this.Btn_Saque = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Lbl_SaldoDisponivel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Agencia
            // 
            this.Lbl_Agencia.AutoSize = true;
            this.Lbl_Agencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Agencia.Location = new System.Drawing.Point(104, 72);
            this.Lbl_Agencia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_Agencia.Name = "Lbl_Agencia";
            this.Lbl_Agencia.Size = new System.Drawing.Size(97, 25);
            this.Lbl_Agencia.TabIndex = 0;
            this.Lbl_Agencia.Text = "Agência";
            // 
            // Lbl_NAgencia
            // 
            this.Lbl_NAgencia.AutoSize = true;
            this.Lbl_NAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NAgencia.Location = new System.Drawing.Point(353, 72);
            this.Lbl_NAgencia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_NAgencia.Name = "Lbl_NAgencia";
            this.Lbl_NAgencia.Size = new System.Drawing.Size(135, 25);
            this.Lbl_NAgencia.TabIndex = 1;
            this.Lbl_NAgencia.Text = "Nº da conta";
            // 
            // Lbl_TitulatConta
            // 
            this.Lbl_TitulatConta.AutoSize = true;
            this.Lbl_TitulatConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitulatConta.Location = new System.Drawing.Point(668, 72);
            this.Lbl_TitulatConta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_TitulatConta.Name = "Lbl_TitulatConta";
            this.Lbl_TitulatConta.Size = new System.Drawing.Size(181, 25);
            this.Lbl_TitulatConta.TabIndex = 3;
            this.Lbl_TitulatConta.Text = "Titular da Conta";
            // 
            // Txt_Agencia
            // 
            this.Txt_Agencia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_Agencia.Location = new System.Drawing.Point(53, 103);
            this.Txt_Agencia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_Agencia.Name = "Txt_Agencia";
            this.Txt_Agencia.Size = new System.Drawing.Size(212, 31);
            this.Txt_Agencia.TabIndex = 4;
            // 
            // Txt_NConta
            // 
            this.Txt_NConta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_NConta.Location = new System.Drawing.Point(311, 103);
            this.Txt_NConta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_NConta.Name = "Txt_NConta";
            this.Txt_NConta.Size = new System.Drawing.Size(212, 31);
            this.Txt_NConta.TabIndex = 5;
            // 
            // Txt_TitularConta
            // 
            this.Txt_TitularConta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_TitularConta.Location = new System.Drawing.Point(577, 103);
            this.Txt_TitularConta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_TitularConta.Name = "Txt_TitularConta";
            this.Txt_TitularConta.Size = new System.Drawing.Size(396, 31);
            this.Txt_TitularConta.TabIndex = 7;
            // 
            // Btn_Saque
            // 
            this.Btn_Saque.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Saque.Location = new System.Drawing.Point(76, 173);
            this.Btn_Saque.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Btn_Saque.Name = "Btn_Saque";
            this.Btn_Saque.Size = new System.Drawing.Size(162, 44);
            this.Btn_Saque.TabIndex = 8;
            this.Btn_Saque.Text = "Saque";
            this.Btn_Saque.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(311, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Deposito";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor.Location = new System.Drawing.Point(585, 150);
            this.Lbl_Valor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(67, 25);
            this.Lbl_Valor.TabIndex = 10;
            this.Lbl_Valor.Text = "Valor";
            // 
            // Lbl_SaldoDisponivel
            // 
            this.Lbl_SaldoDisponivel.AutoSize = true;
            this.Lbl_SaldoDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SaldoDisponivel.Location = new System.Drawing.Point(784, 150);
            this.Lbl_SaldoDisponivel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_SaldoDisponivel.Name = "Lbl_SaldoDisponivel";
            this.Lbl_SaldoDisponivel.Size = new System.Drawing.Size(189, 25);
            this.Lbl_SaldoDisponivel.TabIndex = 11;
            this.Lbl_SaldoDisponivel.Text = "Saldo Disponivel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(526, 186);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 31);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Location = new System.Drawing.Point(770, 186);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 31);
            this.textBox2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Banco - Invista seu $";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1059, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_SaldoDisponivel);
            this.Controls.Add(this.Lbl_Valor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Saque);
            this.Controls.Add(this.Txt_TitularConta);
            this.Controls.Add(this.Txt_NConta);
            this.Controls.Add(this.Txt_Agencia);
            this.Controls.Add(this.Lbl_TitulatConta);
            this.Controls.Add(this.Lbl_NAgencia);
            this.Controls.Add(this.Lbl_Agencia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Agencia;
        private System.Windows.Forms.Label Lbl_NAgencia;
        private System.Windows.Forms.Label Lbl_TitulatConta;
        private System.Windows.Forms.TextBox Txt_Agencia;
        private System.Windows.Forms.TextBox Txt_NConta;
        private System.Windows.Forms.TextBox Txt_TitularConta;
        private System.Windows.Forms.Button Btn_Saque;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Label Lbl_SaldoDisponivel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

