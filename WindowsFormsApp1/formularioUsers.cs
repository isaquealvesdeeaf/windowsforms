using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formularioUsers : Form
    {

        int atual = 0;
        bool novoCadastro = false;

        private void Habilita()
        {
            txt_codigo.Enabled = false;
            txt_nome.Enabled = true;
            txt_nivel.Enabled = true;
            txt_login.Enabled = true;
            txt_senha.Enabled = true;

            btn_alterar.Enabled = false;
            btn_anterior.Enabled = false;
            btn_cancelar.Enabled = true;
            btn_excluir.Enabled = false;
            btn_imprimir.Enabled = false;
            btn_novo.Enabled = false;
            btn_pesquisar.Enabled = false;
            btn_proximo.Enabled = false;
            btn_sair.Enabled = false;
            btn_salvar.Enabled = true;
        }

        private void Desabilita()
        {
            txt_codigo.Enabled = false;
            txt_nome.Enabled = false;
            txt_nivel.Enabled = false;
            txt_login.Enabled = false;
            txt_senha.Enabled = false;

            btn_alterar.Enabled = true;
            btn_anterior.Enabled = true;
            btn_cancelar.Enabled = false;
            btn_excluir.Enabled = true;
            btn_imprimir.Enabled = true;
            btn_novo.Enabled = true;
            btn_pesquisar.Enabled = true;
            btn_proximo.Enabled = true;
            btn_sair.Enabled = true;
            btn_salvar.Enabled = false;
        }
        private void mostra()
        {
            if (Form1.contUser > 0)
            {
                txt_codigo.Text = (Form1.Usuario[atual].cd_usuario) > 0 ? Form1.Usuario[atual].cd_usuario.ToString() : "";
                txt_nome.Text = Form1.Usuario[atual].nm_usuario;
                txt_nivel.Text = Form1.Usuario[atual].sg_nivel;
                txt_login.Text = Form1.Usuario[atual].nm_login;
                txt_senha.Text = Form1.Usuario[atual].ds_senha;
            } else
            {
                txt_codigo.Text =  "";
                txt_nome.Text = "";
                txt_nivel.Text = "";
                txt_login.Text = "";
                txt_senha.Text = "";
            }
         }
        public formularioUsers()
        {
            InitializeComponent();
        }

        private void formularioUsers_Load(object sender, EventArgs e)
        {
            Desabilita();
            mostra();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            //se a quantidade de usuarios registrador for menos que 10, registre
            if (Form1.contUser < 10)
            {
                //cria um novo ID para o usuário que será registrado
                txt_codigo.Text = (Form1.contUser + 1).ToString();
                //limpa os campos do formulário para que o usuário possa preenche-los
                txt_nome.Text = "";
                txt_nivel.Text = "";
                txt_login.Text = "";
                txt_senha.Text = "";
                //habilita o formulário
                Habilita();
                //coloca o cursor dentro do input txtNome
                txt_nome.Focus();
                //torna a variavel booleana verdadeira (para avisar que é um novo usuario e nao a atualizacao de um existente)
                novoCadastro = true;
            }
            else
            {
                //se a quantidade de usuariSos registrador for maior ou igual a 10, envia a mensagem de erro.
                MessageBox.Show("Operação Inválida: nao é possivel cadastrar mais usuários");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Desabilita();

            int nr = 0;

            if (novoCadastro)
            {
                atual = Form1.contUser;
                nr = Form1.contUser++;
            }
            else
            {
                nr = int.Parse(txt_codigo.Text) - 1;
            }

            Form1.Usuario[nr].cd_usuario = int.Parse(txt_codigo.Text);
            Form1.Usuario[nr].nm_usuario = txt_nome.Text;
            Form1.Usuario[nr].sg_nivel = txt_nivel.Text;
            Form1.Usuario[nr].nm_login = txt_login.Text;
            Form1.Usuario[nr].ds_senha = txt_senha.Text;

            novoCadastro = false;
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }
    }
}
