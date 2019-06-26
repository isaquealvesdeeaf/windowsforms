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
    public partial class Form1 : Form
    {
        public static int contUser = 0, contClient = 0, contFornecedor = 0;

        public struct usuario
        {
            public int cd_usuario;
            public string nm_usuario;
            public string sg_nivel;
            public string nm_login;
            public string ds_senha;
        }

        public struct cliente
        {
            public int cd_cliente;
            public string endereco;
            public string bairro;
            public string cidade;
            public string cep;
            public string cpf;
            public string nm_login;
            public string ds_senha;
        }
        public struct fornecedor
        {
            public int cd_fornecedor;
            public string nome;
            public string telefone;
            public string cnpj;
            public string login;
            public string senha;

        }
        public static usuario[] Usuario = new usuario[10];
        public static cliente[] Cliente = new cliente[10];
        public static fornecedor[] Fornecedor = new fornecedor[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioUsers fmrUsers = new formularioUsers();
            fmrUsers.ShowDialog();
        }
    }
}
