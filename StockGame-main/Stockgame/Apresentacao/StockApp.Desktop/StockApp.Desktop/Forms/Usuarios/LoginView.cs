using Azure.Core;
using StockApp.Core.Entidades;
using StockApp.Core.Repository;
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
    public partial class LoginView : Form
    {
        ColaboradorRepository _colaboradorRepository;

        public LoginView()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parametro = new Colaborador();
            parametro.Email = txtEmail.Text;


            var dadosColaborador = _colaboradorRepository.ObterPorEmail(parametro);

            if (dadosColaborador.Count == 0)
            {
                MessageBox.Show("Email ou senha Incorreta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            var senha = dadosColaborador[0].Senha;

            if (senha != txtSenha.Text)
            {
                MessageBox.Show("Email ou senha Incorreta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

            _colaboradorRepository = new ColaboradorRepository();


        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form recuperarSenha = new RecuperarSenhaView();
            recuperarSenha.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fecharLogin = new LoginView();
            fecharLogin.Close();
        }
    }
}
