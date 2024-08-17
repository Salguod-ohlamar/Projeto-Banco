namespace Projeto_Banco
{
    partial class Frm_conta_banco
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
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.Txt_Saldo_Disponivel = new System.Windows.Forms.TextBox();
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
            this.Lbl_Agencia.Size = new System.Drawing.Size(140, 37);
            this.Lbl_Agencia.TabIndex = 0;
            this.Lbl_Agencia.Text = "Agência";
            // 
            // Lbl_NAgencia
            // 
            this.Lbl_NAgencia.AutoSize = true;
            this.Lbl_NAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NAgencia.Location = new System.Drawing.Point(316, 72);
            this.Lbl_NAgencia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_NAgencia.Name = "Lbl_NAgencia";
            this.Lbl_NAgencia.Size = new System.Drawing.Size(197, 37);
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
            this.Lbl_TitulatConta.Size = new System.Drawing.Size(263, 37);
            this.Lbl_TitulatConta.TabIndex = 3;
            this.Lbl_TitulatConta.Text = "Titular da Conta";
            // 
            // Txt_Agencia
            // 
            this.Txt_Agencia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_Agencia.Location = new System.Drawing.Point(53, 103);
            this.Txt_Agencia.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_Agencia.MaxLength = 4;
            this.Txt_Agencia.Name = "Txt_Agencia";
            this.Txt_Agencia.Size = new System.Drawing.Size(212, 43);
            this.Txt_Agencia.TabIndex = 4;
            // 
            // Txt_NConta
            // 
            this.Txt_NConta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_NConta.Location = new System.Drawing.Point(311, 103);
            this.Txt_NConta.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_NConta.MaxLength = 5;
            this.Txt_NConta.Name = "Txt_NConta";
            this.Txt_NConta.Size = new System.Drawing.Size(212, 43);
            this.Txt_NConta.TabIndex = 5;
            // 
            // Txt_TitularConta
            // 
            this.Txt_TitularConta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_TitularConta.Location = new System.Drawing.Point(577, 103);
            this.Txt_TitularConta.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_TitularConta.MaxLength = 30;
            this.Txt_TitularConta.Name = "Txt_TitularConta";
            this.Txt_TitularConta.Size = new System.Drawing.Size(396, 43);
            this.Txt_TitularConta.TabIndex = 7;
            // 
            // Btn_Saque
            // 
            this.Btn_Saque.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Saque.Location = new System.Drawing.Point(82, 194);
            this.Btn_Saque.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Saque.Name = "Btn_Saque";
            this.Btn_Saque.Size = new System.Drawing.Size(162, 44);
            this.Btn_Saque.TabIndex = 8;
            this.Btn_Saque.Text = "Saque";
            this.Btn_Saque.UseVisualStyleBackColor = false;
            this.Btn_Saque.Click += new System.EventHandler(this.Btn_Saque_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(311, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Deposito";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor.Location = new System.Drawing.Point(585, 150);
            this.Lbl_Valor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(98, 37);
            this.Lbl_Valor.TabIndex = 10;
            this.Lbl_Valor.Text = "Valor";
            // 
            // Lbl_SaldoDisponivel
            // 
            this.Lbl_SaldoDisponivel.AutoSize = true;
            this.Lbl_SaldoDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SaldoDisponivel.Location = new System.Drawing.Point(788, 152);
            this.Lbl_SaldoDisponivel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_SaldoDisponivel.Name = "Lbl_SaldoDisponivel";
            this.Lbl_SaldoDisponivel.Size = new System.Drawing.Size(270, 37);
            this.Lbl_SaldoDisponivel.TabIndex = 11;
            this.Lbl_SaldoDisponivel.Text = "Saldo Disponivel";
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Location = new System.Drawing.Point(537, 195);
            this.Txt_Valor.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(212, 43);
            this.Txt_Valor.TabIndex = 12;
            // 
            // Txt_Saldo_Disponivel
            // 
            this.Txt_Saldo_Disponivel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Txt_Saldo_Disponivel.Enabled = false;
            this.Txt_Saldo_Disponivel.Location = new System.Drawing.Point(795, 195);
            this.Txt_Saldo_Disponivel.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_Saldo_Disponivel.Name = "Txt_Saldo_Disponivel";
            this.Txt_Saldo_Disponivel.Size = new System.Drawing.Size(212, 43);
            this.Txt_Saldo_Disponivel.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Banco - Invista seu $";
            // 
            // Frm_conta_banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1160, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Saldo_Disponivel);
            this.Controls.Add(this.Txt_Valor);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_conta_banco";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.TextBox Txt_Saldo_Disponivel;
        private System.Windows.Forms.Label label1;
    }
}

