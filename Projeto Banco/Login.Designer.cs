namespace Projeto_Banco
{
    partial class Frm_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Agencia = new System.Windows.Forms.TextBox();
            this.Txt_Numero_Conta = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Cadastro = new System.Windows.Forms.Button();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Btn_Recuperar = new System.Windows.Forms.Button();
            this.Btn_MostrarOcultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faça seu login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero da conta";
            // 
            // Txt_Agencia
            // 
            this.Txt_Agencia.Location = new System.Drawing.Point(26, 192);
            this.Txt_Agencia.Name = "Txt_Agencia";
            this.Txt_Agencia.Size = new System.Drawing.Size(100, 26);
            this.Txt_Agencia.TabIndex = 4;
            // 
            // Txt_Numero_Conta
            // 
            this.Txt_Numero_Conta.Location = new System.Drawing.Point(194, 192);
            this.Txt_Numero_Conta.Name = "Txt_Numero_Conta";
            this.Txt_Numero_Conta.Size = new System.Drawing.Size(182, 26);
            this.Txt_Numero_Conta.TabIndex = 5;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(44, 277);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(104, 42);
            this.Btn_Login.TabIndex = 7;
            this.Btn_Login.Text = "Logar";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Cadastro
            // 
            this.Btn_Cadastro.Location = new System.Drawing.Point(191, 277);
            this.Btn_Cadastro.Name = "Btn_Cadastro";
            this.Btn_Cadastro.Size = new System.Drawing.Size(104, 42);
            this.Btn_Cadastro.TabIndex = 8;
            this.Btn_Cadastro.Text = "Cadastrar";
            this.Btn_Cadastro.UseVisualStyleBackColor = true;
            this.Btn_Cadastro.Click += new System.EventHandler(this.Btn_Cadastro_Click);
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Senha.Location = new System.Drawing.Point(430, 149);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(87, 29);
            this.Lbl_Senha.TabIndex = 10;
            this.Lbl_Senha.Text = "Senha";
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(435, 195);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(150, 26);
            this.Txt_Senha.TabIndex = 11;
            // 
            // Btn_Recuperar
            // 
            this.Btn_Recuperar.Location = new System.Drawing.Point(340, 277);
            this.Btn_Recuperar.Name = "Btn_Recuperar";
            this.Btn_Recuperar.Size = new System.Drawing.Size(164, 42);
            this.Btn_Recuperar.TabIndex = 12;
            this.Btn_Recuperar.Text = "Recuperar Senha";
            this.Btn_Recuperar.UseVisualStyleBackColor = true;
            // 
            // Btn_MostrarOcultar
            // 
            this.Btn_MostrarOcultar.Location = new System.Drawing.Point(598, 193);
            this.Btn_MostrarOcultar.Name = "Btn_MostrarOcultar";
            this.Btn_MostrarOcultar.Size = new System.Drawing.Size(34, 31);
            this.Btn_MostrarOcultar.TabIndex = 23;
            this.Btn_MostrarOcultar.Text = "M";
            this.Btn_MostrarOcultar.UseVisualStyleBackColor = true;
            this.Btn_MostrarOcultar.Click += new System.EventHandler(this.Btn_MostrarOcultar_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 353);
            this.Controls.Add(this.Btn_MostrarOcultar);
            this.Controls.Add(this.Btn_Recuperar);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Btn_Cadastro);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_Numero_Conta);
            this.Controls.Add(this.Txt_Agencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Agencia;
        private System.Windows.Forms.TextBox Txt_Numero_Conta;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_Cadastro;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Button Btn_Recuperar;
        private System.Windows.Forms.Button Btn_MostrarOcultar;
    }
}