using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PessoaPOO
{
    public partial class Form1 : Form
    {
        //Criar uma instancia global para acessar a classe de manipulação
        UsuarioExecucao usuarioExecucao = new UsuarioExecucao();
        public Form1()
        {
            InitializeComponent();
        }

        private void AdicionarUsuario() 
        {
            //Variaveis auxiliares para cada campo
            string cpf, nome, email, senha;
            DateTime dtNascimento;

            //Iremos popular as variaveis de acordo com as informações inseridas pelo usuario final
            nome = txtNome.Text;
            cpf = txtCPF.Text;
            email = txtEmail.Text;
            senha = txtSenha.Text;
            dtNascimento = dtDataNasc.Value;

            //Validação simples | Exemplo
            if (string.IsNullOrEmpty(cpf) && string.IsNullOrEmpty(nome))
            return;

            //Criamos a instancia das classes
            Usuario usuario = new Usuario();
            Pessoa pessoa = new Pessoa();

            //Popular o objeto pessoa
            pessoa.Nome = nome;
            pessoa.CPF = cpf;
            pessoa.DtNascimento = dtNascimento;

            //Popular o objeto usuario
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.Pessoa = pessoa;

            //Aqui finalizar a atribuição de valores
            //Agora precisamos manipular os registro
            usuarioExecucao.Adicionar(usuario);
            //Nesse momento o objeto do usuario foi adicionado a lista

            //Atualizar a listBox para exibir os registros
            AtualizarListaUsuarios();

            //Após inserção de dados, limpar os campos
            txtCPF.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            dtDataNasc.Value = DateTime.Now;


        }

        //Método para atualizar a ListBox
        private void AtualizarListaUsuarios()
        {
            //Limpar o ListBox
            lsbUsuarios.DataSource = null;
            //Popular a ListBox com a Lista de Usuarios

            lsbUsuarios.DataSource = usuarioExecucao.ListarUsuario();

            //Definir qual inforamção será exibida
            lsbUsuarios.DisplayMember = "NomeEmail";

        }

        //Método para remover um registro da lista
        private void RemoverUsuario()
        {
            //Primeiro identificar o registro selecionado na listbox
            Usuario usuarioSelecionado = lsbUsuarios.SelectedItem as Usuario;

            //Após colear o objeto, validar se está nulo
            if(usuarioSelecionado != null)
            {
                usuarioExecucao.Remover(usuarioSelecionado);

                AtualizarListaUsuarios();
            }
        }

        //Método para exibir os detalhes do registro selecionado
        private void ExibirUsuario()
        {
            Usuario usuarioSelecionado = lsbUsuarios.SelectedItem as Usuario;

            if(usuarioSelecionado != null)
            {
                txtVizualizaCPF.Text = usuarioSelecionado.Pessoa.CPF;
                txtVizualizaNome.Text = usuarioSelecionado.Pessoa.Nome;
                txtVizualizarDataNasc.Text = usuarioSelecionado.Pessoa.DtNascimento.ToShortDateString();
                txtVizualizarIdade.Text = usuarioSelecionado.Pessoa.Idade.ToString();
                txtVizualizaEmail.Text = usuarioSelecionado.Email;
                txtVizualizaSenha.Text = usuarioSelecionado.Senha;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lsbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVizualizar_Click(object sender, EventArgs e)
        {
            ExibirUsuario();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverUsuario();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarUsuario();
        }

        private void lsbUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ExibirUsuario();
        }
    }
}
