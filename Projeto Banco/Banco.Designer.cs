﻿namespace Projeto_Banco
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
            this.Btn_Deposito = new System.Windows.Forms.Button();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Lbl_SaldoDisponivel = new System.Windows.Forms.Label();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.Txt_Saldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_idade = new System.Windows.Forms.Label();
            this.Txt_idadeBanco = new System.Windows.Forms.TextBox();
            this.Txt_Mes_Nasc_Banco = new System.Windows.Forms.TextBox();
            this.Lbl_mes_Nascimento = new System.Windows.Forms.Label();
            this.Lbl_conta_saque = new System.Windows.Forms.Label();
            this.Lbl_Conta_Deposito = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_investir = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Txt_Email_Banco = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Agencia
            // 
            this.Lbl_Agencia.AutoSize = true;
            this.Lbl_Agencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Agencia.Location = new System.Drawing.Point(15, 58);
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
            this.Lbl_NAgencia.Location = new System.Drawing.Point(167, 58);
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
            this.Lbl_TitulatConta.Location = new System.Drawing.Point(376, 58);
            this.Lbl_TitulatConta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_TitulatConta.Name = "Lbl_TitulatConta";
            this.Lbl_TitulatConta.Size = new System.Drawing.Size(263, 37);
            this.Lbl_TitulatConta.TabIndex = 3;
            this.Lbl_TitulatConta.Text = "Titular da Conta";
            // 
            // Txt_Agencia
            // 
            this.Txt_Agencia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_Agencia.Enabled = false;
            this.Txt_Agencia.Location = new System.Drawing.Point(3, 113);
            this.Txt_Agencia.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_Agencia.MaxLength = 4;
            this.Txt_Agencia.Name = "Txt_Agencia";
            this.Txt_Agencia.Size = new System.Drawing.Size(159, 43);
            this.Txt_Agencia.TabIndex = 4;
            this.Txt_Agencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Agencia_KeyPress);
            // 
            // Txt_NConta
            // 
            this.Txt_NConta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_NConta.Enabled = false;
            this.Txt_NConta.Location = new System.Drawing.Point(174, 113);
            this.Txt_NConta.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_NConta.MaxLength = 5;
            this.Txt_NConta.Name = "Txt_NConta";
            this.Txt_NConta.Size = new System.Drawing.Size(158, 43);
            this.Txt_NConta.TabIndex = 5;
            this.Txt_NConta.TextChanged += new System.EventHandler(this.Txt_NConta_TextChanged);
            this.Txt_NConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NConta_KeyPress);
            // 
            // Txt_TitularConta
            // 
            this.Txt_TitularConta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_TitularConta.Enabled = false;
            this.Txt_TitularConta.Location = new System.Drawing.Point(381, 113);
            this.Txt_TitularConta.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_TitularConta.MaxLength = 30;
            this.Txt_TitularConta.Name = "Txt_TitularConta";
            this.Txt_TitularConta.Size = new System.Drawing.Size(290, 43);
            this.Txt_TitularConta.TabIndex = 7;
            this.Txt_TitularConta.TextChanged += new System.EventHandler(this.Txt_TitularConta_TextChanged);
            this.Txt_TitularConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_TitularConta_KeyPress);
            // 
            // Btn_Saque
            // 
            this.Btn_Saque.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Saque.Location = new System.Drawing.Point(15, 306);
            this.Btn_Saque.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Saque.Name = "Btn_Saque";
            this.Btn_Saque.Size = new System.Drawing.Size(162, 44);
            this.Btn_Saque.TabIndex = 8;
            this.Btn_Saque.Text = "Saque";
            this.Btn_Saque.UseVisualStyleBackColor = false;
            this.Btn_Saque.Click += new System.EventHandler(this.Btn_Saque_Click);
            // 
            // Btn_Deposito
            // 
            this.Btn_Deposito.BackColor = System.Drawing.Color.Lime;
            this.Btn_Deposito.Location = new System.Drawing.Point(15, 382);
            this.Btn_Deposito.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Deposito.Name = "Btn_Deposito";
            this.Btn_Deposito.Size = new System.Drawing.Size(162, 44);
            this.Btn_Deposito.TabIndex = 9;
            this.Btn_Deposito.Text = "Deposito";
            this.Btn_Deposito.UseVisualStyleBackColor = false;
            this.Btn_Deposito.Click += new System.EventHandler(this.Btn_Deposito_Click);
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor.Location = new System.Drawing.Point(637, 332);
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
            this.Lbl_SaldoDisponivel.Location = new System.Drawing.Point(298, 332);
            this.Lbl_SaldoDisponivel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_SaldoDisponivel.Name = "Lbl_SaldoDisponivel";
            this.Lbl_SaldoDisponivel.Size = new System.Drawing.Size(270, 37);
            this.Lbl_SaldoDisponivel.TabIndex = 11;
            this.Lbl_SaldoDisponivel.Text = "Saldo Disponivel";
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Location = new System.Drawing.Point(628, 389);
            this.Txt_Valor.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(139, 43);
            this.Txt_Valor.TabIndex = 12;
            this.Txt_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Valor_KeyPress);
            // 
            // Txt_Saldo
            // 
            this.Txt_Saldo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Txt_Saldo.Enabled = false;
            this.Txt_Saldo.Location = new System.Drawing.Point(341, 386);
            this.Txt_Saldo.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_Saldo.Name = "Txt_Saldo";
            this.Txt_Saldo.Size = new System.Drawing.Size(147, 43);
            this.Txt_Saldo.TabIndex = 13;
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
            // Lbl_idade
            // 
            this.Lbl_idade.AutoSize = true;
            this.Lbl_idade.Location = new System.Drawing.Point(725, 76);
            this.Lbl_idade.Name = "Lbl_idade";
            this.Lbl_idade.Size = new System.Drawing.Size(101, 37);
            this.Lbl_idade.TabIndex = 15;
            this.Lbl_idade.Text = "Idade";
            // 
            // Txt_idadeBanco
            // 
            this.Txt_idadeBanco.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_idadeBanco.Enabled = false;
            this.Txt_idadeBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idadeBanco.Location = new System.Drawing.Point(726, 116);
            this.Txt_idadeBanco.MaxLength = 3;
            this.Txt_idadeBanco.Name = "Txt_idadeBanco";
            this.Txt_idadeBanco.Size = new System.Drawing.Size(100, 35);
            this.Txt_idadeBanco.TabIndex = 18;
            this.Txt_idadeBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_idade_KeyPress);
            // 
            // Txt_Mes_Nasc_Banco
            // 
            this.Txt_Mes_Nasc_Banco.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_Mes_Nasc_Banco.Enabled = false;
            this.Txt_Mes_Nasc_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Mes_Nasc_Banco.Location = new System.Drawing.Point(874, 116);
            this.Txt_Mes_Nasc_Banco.MaxLength = 2;
            this.Txt_Mes_Nasc_Banco.Name = "Txt_Mes_Nasc_Banco";
            this.Txt_Mes_Nasc_Banco.Size = new System.Drawing.Size(100, 35);
            this.Txt_Mes_Nasc_Banco.TabIndex = 19;
            this.Txt_Mes_Nasc_Banco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_mes_Nasc_KeyPress);
            // 
            // Lbl_mes_Nascimento
            // 
            this.Lbl_mes_Nascimento.AutoSize = true;
            this.Lbl_mes_Nascimento.Location = new System.Drawing.Point(867, 76);
            this.Lbl_mes_Nascimento.Name = "Lbl_mes_Nascimento";
            this.Lbl_mes_Nascimento.Size = new System.Drawing.Size(177, 37);
            this.Lbl_mes_Nascimento.TabIndex = 20;
            this.Lbl_mes_Nascimento.Text = "Mês Nasc.";
            // 
            // Lbl_conta_saque
            // 
            this.Lbl_conta_saque.AutoSize = true;
            this.Lbl_conta_saque.Location = new System.Drawing.Point(199, 306);
            this.Lbl_conta_saque.Name = "Lbl_conta_saque";
            this.Lbl_conta_saque.Size = new System.Drawing.Size(36, 37);
            this.Lbl_conta_saque.TabIndex = 21;
            this.Lbl_conta_saque.Text = "0";
            // 
            // Lbl_Conta_Deposito
            // 
            this.Lbl_Conta_Deposito.AutoSize = true;
            this.Lbl_Conta_Deposito.Location = new System.Drawing.Point(189, 386);
            this.Lbl_Conta_Deposito.Name = "Lbl_Conta_Deposito";
            this.Lbl_Conta_Deposito.Size = new System.Drawing.Size(36, 37);
            this.Lbl_Conta_Deposito.TabIndex = 22;
            this.Lbl_Conta_Deposito.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 37);
            this.label4.TabIndex = 23;
            // 
            // Btn_investir
            // 
            this.Btn_investir.Location = new System.Drawing.Point(916, 389);
            this.Btn_investir.Name = "Btn_investir";
            this.Btn_investir.Size = new System.Drawing.Size(217, 52);
            this.Btn_investir.TabIndex = 24;
            this.Btn_investir.Text = "Investir";
            this.Btn_investir.UseVisualStyleBackColor = true;
            this.Btn_investir.Click += new System.EventHandler(this.Btn_investir_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Location = new System.Drawing.Point(393, 218);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(75, 39);
            this.Btn_Editar.TabIndex = 25;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Txt_Email_Banco
            // 
            this.Txt_Email_Banco.Location = new System.Drawing.Point(10, 218);
            this.Txt_Email_Banco.Name = "Txt_Email_Banco";
            this.Txt_Email_Banco.Size = new System.Drawing.Size(335, 43);
            this.Txt_Email_Banco.TabIndex = 27;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(15, 184);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(102, 37);
            this.Lbl_Email.TabIndex = 26;
            this.Lbl_Email.Text = "Email";
            // 
            // Frm_conta_banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1145, 453);
            this.Controls.Add(this.Txt_Email_Banco);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_investir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_Conta_Deposito);
            this.Controls.Add(this.Lbl_conta_saque);
            this.Controls.Add(this.Lbl_mes_Nascimento);
            this.Controls.Add(this.Txt_Mes_Nasc_Banco);
            this.Controls.Add(this.Txt_idadeBanco);
            this.Controls.Add(this.Lbl_idade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Saldo);
            this.Controls.Add(this.Txt_Valor);
            this.Controls.Add(this.Lbl_SaldoDisponivel);
            this.Controls.Add(this.Lbl_Valor);
            this.Controls.Add(this.Btn_Deposito);
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
        private System.Windows.Forms.Button Btn_Deposito;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Label Lbl_SaldoDisponivel;
        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_idade;
        private System.Windows.Forms.TextBox Txt_idadeBanco;
        private System.Windows.Forms.TextBox Txt_Mes_Nasc_Banco;
        private System.Windows.Forms.Label Lbl_mes_Nascimento;
        private System.Windows.Forms.Label Lbl_conta_saque;
        private System.Windows.Forms.Label Lbl_Conta_Deposito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_investir;
        public System.Windows.Forms.TextBox Txt_Saldo;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.TextBox Txt_Email_Banco;
        private System.Windows.Forms.Label Lbl_Email;
    }
}

