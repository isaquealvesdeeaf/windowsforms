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

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {

        }
    }
}
