namespace PessoaPOO
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVizualizar = new System.Windows.Forms.Button();
            this.txtVizualizaSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVizualizaEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVizualizaNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVizualizaCPF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtVizualizarIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtVizualizarDataNasc = new System.Windows.Forms.TextBox();
            this.lsbUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(12, 25);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(139, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(192, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Nascimento:";
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNasc.Location = new System.Drawing.Point(360, 25);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Size = new System.Drawing.Size(146, 20);
            this.dtDataNasc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(262, 75);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(259, 59);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 13);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "SENHA:";
            this.lblSenha.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 114);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "USUÁRIOS:";
            // 
            // btnVizualizar
            // 
            this.btnVizualizar.Location = new System.Drawing.Point(12, 346);
            this.btnVizualizar.Name = "btnVizualizar";
            this.btnVizualizar.Size = new System.Drawing.Size(100, 23);
            this.btnVizualizar.TabIndex = 23;
            this.btnVizualizar.Text = "VIZUALIZAR";
            this.btnVizualizar.UseVisualStyleBackColor = true;
            this.btnVizualizar.Click += new System.EventHandler(this.btnVizualizar_Click);
            // 
            // txtVizualizaSenha
            // 
            this.txtVizualizaSenha.Location = new System.Drawing.Point(262, 307);
            this.txtVizualizaSenha.Name = "txtVizualizaSenha";
            this.txtVizualizaSenha.Size = new System.Drawing.Size(100, 20);
            this.txtVizualizaSenha.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "SENHA:";
            // 
            // txtVizualizaEmail
            // 
            this.txtVizualizaEmail.Location = new System.Drawing.Point(12, 307);
            this.txtVizualizaEmail.Name = "txtVizualizaEmail";
            this.txtVizualizaEmail.Size = new System.Drawing.Size(227, 20);
            this.txtVizualizaEmail.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "EMAIL:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data de Nascimento:";
            // 
            // txtVizualizaNome
            // 
            this.txtVizualizaNome.Location = new System.Drawing.Point(139, 257);
            this.txtVizualizaNome.Name = "txtVizualizaNome";
            this.txtVizualizaNome.Size = new System.Drawing.Size(192, 20);
            this.txtVizualizaNome.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "NOME:";
            // 
            // txtVizualizaCPF
            // 
            this.txtVizualizaCPF.Location = new System.Drawing.Point(12, 257);
            this.txtVizualizaCPF.Name = "txtVizualizaCPF";
            this.txtVizualizaCPF.Size = new System.Drawing.Size(100, 20);
            this.txtVizualizaCPF.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "CPF:";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(139, 346);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 23);
            this.btnRemover.TabIndex = 24;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtVizualizarIdade
            // 
            this.txtVizualizarIdade.Location = new System.Drawing.Point(391, 307);
            this.txtVizualizarIdade.Name = "txtVizualizarIdade";
            this.txtVizualizarIdade.Size = new System.Drawing.Size(115, 20);
            this.txtVizualizarIdade.TabIndex = 26;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(388, 291);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(43, 13);
            this.lblIdade.TabIndex = 25;
            this.lblIdade.Text = "IDADE:";
            // 
            // txtVizualizarDataNasc
            // 
            this.txtVizualizarDataNasc.Location = new System.Drawing.Point(360, 257);
            this.txtVizualizarDataNasc.Name = "txtVizualizarDataNasc";
            this.txtVizualizarDataNasc.Size = new System.Drawing.Size(192, 20);
            this.txtVizualizarDataNasc.TabIndex = 27;
            // 
            // lsbUsuarios
            // 
            this.lsbUsuarios.FormattingEnabled = true;
            this.lsbUsuarios.Location = new System.Drawing.Point(15, 168);
            this.lsbUsuarios.Name = "lsbUsuarios";
            this.lsbUsuarios.Size = new System.Drawing.Size(716, 69);
            this.lsbUsuarios.TabIndex = 28;
            this.lsbUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbUsuarios_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbUsuarios);
            this.Controls.Add(this.txtVizualizarDataNasc);
            this.Controls.Add(this.txtVizualizarIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnVizualizar);
            this.Controls.Add(this.txtVizualizaSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVizualizaEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVizualizaNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVizualizaCPF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtDataNasc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDataNasc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVizualizar;
        private System.Windows.Forms.TextBox txtVizualizaSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVizualizaEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVizualizaNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVizualizaCPF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtVizualizarIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtVizualizarDataNasc;
        private System.Windows.Forms.ListBox lsbUsuarios;
    }
}

