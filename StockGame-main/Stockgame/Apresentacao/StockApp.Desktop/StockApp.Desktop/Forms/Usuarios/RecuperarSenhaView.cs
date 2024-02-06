using StockApp.Core.Entidades;
using StockApp.Core.Ultilidade;
using StockApp.Data.SqlServer.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp.Desktop.Forms.Usuarios
{
    public partial class RecuperarSenhaView : Form
    {
        ColaboradorRepository _colaboradorRepository;

        public RecuperarSenhaView()
        {
            InitializeComponent();
            _colaboradorRepository = new ColaboradorRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var emailUsuario = new Colaborador();
            emailUsuario.Email = txtEmail.Text;
            var emailExist = _colaboradorRepository.ObterPorEmail(emailUsuario);

            if (emailExist.Count < 1)
            {
                MessageBox.Show("Email Invalido favor tente novamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = new EmailService(txtEmail.Text);
            var senha = new GerarSenha();
            string novaSenha = senha.GerarSenhaAleatoria();

            var parametroUpdate = new Colaborador();
            parametroUpdate.Email = txtEmail.Text;
            parametroUpdate.Senha = novaSenha;

            var updateUser = _colaboradorRepository.AtualizarSenha(parametroUpdate);

            resultado.EmailRecuperarSenha(txtEmail.Text, novaSenha);
            return;

        }

        private void RecuperarSenhaView_Load(object sender, EventArgs e)
        {

        }
    }
}
