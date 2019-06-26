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
    }
}
