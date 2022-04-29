using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            string profissao = cbProfissao.SelectedItem.ToString();
            lstCadastros.Items.Add(string.Format($"{nome}, {idade} Anos, {profissao}"));
            MessageBox.Show("Cadastro Realizado com Sucesso");
            txtNome.Clear();
            txtIdade.Clear();
            cbProfissao.ResetText();
        }
    }
}
