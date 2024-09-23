namespace Projeto_Banco
{
    partial class Frm_Cadastro
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
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_TitularConta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_idade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_mes_Nasc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Txt_Numero_Conta = new System.Windows.Forms.TextBox();
            this.Txt_Agencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(517, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "CADASTRO DE NOVAS CONTA";
            // 
            // Txt_TitularConta
            // 
            this.Txt_TitularConta.Location = new System.Drawing.Point(26, 73);
            this.Txt_TitularConta.Name = "Txt_TitularConta";
            this.Txt_TitularConta.Size = new System.Drawing.Size(274, 26);
            this.Txt_TitularConta.TabIndex = 12;
            this.Txt_TitularConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Titular_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Titular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Idade";
            // 
            // Txt_idade
            // 
            this.Txt_idade.Location = new System.Drawing.Point(353, 73);
            this.Txt_idade.Name = "Txt_idade";
            this.Txt_idade.Size = new System.Drawing.Size(100, 26);
            this.Txt_idade.TabIndex = 14;
            this.Txt_idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_idade_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mês de Nascimnento";
            // 
            // Txt_mes_Nasc
            // 
            this.Txt_mes_Nasc.AcceptsReturn = true;
            this.Txt_mes_Nasc.Location = new System.Drawing.Point(500, 73);
            this.Txt_mes_Nasc.Name = "Txt_mes_Nasc";
            this.Txt_mes_Nasc.Size = new System.Drawing.Size(100, 26);
            this.Txt_mes_Nasc.TabIndex = 16;
            this.Txt_mes_Nasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_mes_Nasc_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Email);
            this.groupBox1.Controls.Add(this.Lbl_Email);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Lbl_Senha);
            this.groupBox1.Controls.Add(this.Txt_mes_Nasc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_idade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_TitularConta);
            this.groupBox1.Location = new System.Drawing.Point(23, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 217);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(353, 151);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(335, 26);
            this.Txt_Email.TabIndex = 21;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(353, 118);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(48, 20);
            this.Lbl_Email.TabIndex = 20;
            this.Lbl_Email.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 26);
            this.textBox1.TabIndex = 19;
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Location = new System.Drawing.Point(22, 118);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(56, 20);
            this.Lbl_Senha.TabIndex = 18;
            this.Lbl_Senha.Text = "Senha";
            // 
            // Txt_Numero_Conta
            // 
            this.Txt_Numero_Conta.Enabled = false;
            this.Txt_Numero_Conta.Location = new System.Drawing.Point(164, 80);
            this.Txt_Numero_Conta.Name = "Txt_Numero_Conta";
            this.Txt_Numero_Conta.Size = new System.Drawing.Size(100, 26);
            this.Txt_Numero_Conta.TabIndex = 20;
            // 
            // Txt_Agencia
            // 
            this.Txt_Agencia.Enabled = false;
            this.Txt_Agencia.Location = new System.Drawing.Point(15, 80);
            this.Txt_Agencia.Name = "Txt_Agencia";
            this.Txt_Agencia.Size = new System.Drawing.Size(100, 26);
            this.Txt_Agencia.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Numero da conta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Agencia";
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.Location = new System.Drawing.Point(424, 513);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(92, 50);
            this.Btn_Cadastrar.TabIndex = 18;
            this.Btn_Cadastrar.Text = "Cadastrar";
            this.Btn_Cadastrar.UseVisualStyleBackColor = true;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Txt_Numero_Conta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Txt_Agencia);
            this.groupBox2.Location = new System.Drawing.Point(23, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 114);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Conta";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(692, 513);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(96, 50);
            this.Btn_Login.TabIndex = 22;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Location = new System.Drawing.Point(556, 513);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(92, 50);
            this.Btn_Voltar.TabIndex = 23;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Cadastro";
            this.Text = "Cadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_TitularConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_idade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_mes_Nasc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Numero_Conta;
        private System.Windows.Forms.TextBox Txt_Agencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Cadastrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}