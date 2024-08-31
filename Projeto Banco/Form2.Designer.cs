namespace Projeto_Banco
{
    partial class Frm_investimento
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
            this.Lbl_saldo_disponivel = new System.Windows.Forms.Label();
            this.Lbl_Valor_investimento = new System.Windows.Forms.Label();
            this.Lbl_nu_meses = new System.Windows.Forms.Label();
            this.Lbl_Investimento = new System.Windows.Forms.Label();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Txt_saldo_disponivel = new System.Windows.Forms.TextBox();
            this.Txt_Valor_Investimento = new System.Windows.Forms.TextBox();
            this.Num_Meses = new System.Windows.Forms.NumericUpDown();
            this.List_Meses = new System.Windows.Forms.ListBox();
            this.List_Rendimento = new System.Windows.Forms.ListBox();
            this.Lbl_Mes = new System.Windows.Forms.Label();
            this.Lbl_Rendimento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Meses)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_saldo_disponivel
            // 
            this.Lbl_saldo_disponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldo_disponivel.Location = new System.Drawing.Point(18, 95);
            this.Lbl_saldo_disponivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_saldo_disponivel.Name = "Lbl_saldo_disponivel";
            this.Lbl_saldo_disponivel.Size = new System.Drawing.Size(258, 55);
            this.Lbl_saldo_disponivel.TabIndex = 0;
            this.Lbl_saldo_disponivel.Text = "Saldo Disponivel ";
            // 
            // Lbl_Valor_investimento
            // 
            this.Lbl_Valor_investimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor_investimento.Location = new System.Drawing.Point(2, 240);
            this.Lbl_Valor_investimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Valor_investimento.Name = "Lbl_Valor_investimento";
            this.Lbl_Valor_investimento.Size = new System.Drawing.Size(298, 55);
            this.Lbl_Valor_investimento.TabIndex = 1;
            this.Lbl_Valor_investimento.Text = "Valor do Investimento ";
            // 
            // Lbl_nu_meses
            // 
            this.Lbl_nu_meses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nu_meses.Location = new System.Drawing.Point(2, 377);
            this.Lbl_nu_meses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nu_meses.Name = "Lbl_nu_meses";
            this.Lbl_nu_meses.Size = new System.Drawing.Size(298, 55);
            this.Lbl_nu_meses.TabIndex = 2;
            this.Lbl_nu_meses.Text = "Número de meses";
            // 
            // Lbl_Investimento
            // 
            this.Lbl_Investimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Investimento.Location = new System.Drawing.Point(410, 14);
            this.Lbl_Investimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Investimento.Name = "Lbl_Investimento";
            this.Lbl_Investimento.Size = new System.Drawing.Size(258, 55);
            this.Lbl_Investimento.TabIndex = 3;
            this.Lbl_Investimento.Text = "Investimento";
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Location = new System.Drawing.Point(957, 69);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(112, 35);
            this.Btn_Voltar.TabIndex = 4;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Txt_saldo_disponivel
            // 
            this.Txt_saldo_disponivel.Enabled = false;
            this.Txt_saldo_disponivel.Location = new System.Drawing.Point(24, 171);
            this.Txt_saldo_disponivel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_saldo_disponivel.Name = "Txt_saldo_disponivel";
            this.Txt_saldo_disponivel.Size = new System.Drawing.Size(208, 26);
            this.Txt_saldo_disponivel.TabIndex = 5;
            // 
            // Txt_Valor_Investimento
            // 
            this.Txt_Valor_Investimento.Location = new System.Drawing.Point(24, 300);
            this.Txt_Valor_Investimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Valor_Investimento.Name = "Txt_Valor_Investimento";
            this.Txt_Valor_Investimento.Size = new System.Drawing.Size(208, 26);
            this.Txt_Valor_Investimento.TabIndex = 6;
            this.Txt_Valor_Investimento.TextChanged += new System.EventHandler(this.Txt_Valor_Investimento_TextChanged);
            // 
            // Num_Meses
            // 
            this.Num_Meses.Enabled = false;
            this.Num_Meses.Location = new System.Drawing.Point(58, 437);
            this.Num_Meses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Num_Meses.Name = "Num_Meses";
            this.Num_Meses.Size = new System.Drawing.Size(106, 26);
            this.Num_Meses.TabIndex = 7;
            // 
            // List_Meses
            // 
            this.List_Meses.FormattingEnabled = true;
            this.List_Meses.ItemHeight = 20;
            this.List_Meses.Location = new System.Drawing.Point(416, 211);
            this.List_Meses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.List_Meses.Name = "List_Meses";
            this.List_Meses.Size = new System.Drawing.Size(178, 284);
            this.List_Meses.TabIndex = 8;
            // 
            // List_Rendimento
            // 
            this.List_Rendimento.FormattingEnabled = true;
            this.List_Rendimento.ItemHeight = 20;
            this.List_Rendimento.Location = new System.Drawing.Point(672, 211);
            this.List_Rendimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.List_Rendimento.Name = "List_Rendimento";
            this.List_Rendimento.Size = new System.Drawing.Size(178, 284);
            this.List_Rendimento.TabIndex = 9;
            // 
            // Lbl_Mes
            // 
            this.Lbl_Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mes.Location = new System.Drawing.Point(416, 143);
            this.Lbl_Mes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Mes.Name = "Lbl_Mes";
            this.Lbl_Mes.Size = new System.Drawing.Size(159, 38);
            this.Lbl_Mes.TabIndex = 10;
            this.Lbl_Mes.Text = "Mês";
            // 
            // Lbl_Rendimento
            // 
            this.Lbl_Rendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rendimento.Location = new System.Drawing.Point(666, 143);
            this.Lbl_Rendimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Rendimento.Name = "Lbl_Rendimento";
            this.Lbl_Rendimento.Size = new System.Drawing.Size(186, 38);
            this.Lbl_Rendimento.TabIndex = 11;
            this.Lbl_Rendimento.Text = "Rendimento";
            // 
            // Frm_investimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1200, 608);
            this.Controls.Add(this.Lbl_Rendimento);
            this.Controls.Add(this.Lbl_Mes);
            this.Controls.Add(this.List_Rendimento);
            this.Controls.Add(this.List_Meses);
            this.Controls.Add(this.Num_Meses);
            this.Controls.Add(this.Txt_Valor_Investimento);
            this.Controls.Add(this.Txt_saldo_disponivel);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_Investimento);
            this.Controls.Add(this.Lbl_nu_meses);
            this.Controls.Add(this.Lbl_Valor_investimento);
            this.Controls.Add(this.Lbl_saldo_disponivel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_investimento";
            this.Text = "Investimento";
            this.Load += new System.EventHandler(this.Frm_investimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Num_Meses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_saldo_disponivel;
        private System.Windows.Forms.Label Lbl_Valor_investimento;
        private System.Windows.Forms.Label Lbl_nu_meses;
        private System.Windows.Forms.Label Lbl_Investimento;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.TextBox Txt_Valor_Investimento;
        private System.Windows.Forms.NumericUpDown Num_Meses;
        private System.Windows.Forms.ListBox List_Meses;
        private System.Windows.Forms.ListBox List_Rendimento;
        private System.Windows.Forms.Label Lbl_Mes;
        private System.Windows.Forms.Label Lbl_Rendimento;
        public System.Windows.Forms.TextBox Txt_saldo_disponivel;
    }
}