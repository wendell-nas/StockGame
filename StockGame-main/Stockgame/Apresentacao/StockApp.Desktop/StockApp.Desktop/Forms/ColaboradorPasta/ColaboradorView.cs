using StockApp.Core.Entidades;
using StockApp.Core.Validator;
using StockApp.Data.SqlServer.Repositorio;

namespace StockApp.Desktop.Forms.Colaborador
{
    public partial class ColaboradorView : Form
    {


        ColaboradorRepository _colaboradorRepository;
        public ColaboradorView()
        {
            InitializeComponent();
            _colaboradorRepository = new ColaboradorRepository();
        }

        private void CarregarColaboradores()
        {
            dgvColaborador.AutoGenerateColumns = false;
            dgvColaborador.DataSource = _colaboradorRepository.ObterTodos();
            CarregarDepartamento();
            this.Size = new Size(776, 592);

        }
        private void btnCep_Click(object sender, EventArgs e)
        {
            if (mxtCep.Text != null)
            {
                txtUf.Enabled = true;
                txtCidade.Enabled = true;
                txtNumero.Enabled = true;
                txtLogadouro.Enabled = true;
                txtBairro.Enabled = true;
                txtComplemento.Enabled = true;
            }
        }

        private void CarregarCamposFalseCep()
        {
            txtUf.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            txtLogadouro.Enabled = false;
            txtBairro.Enabled = false;
            txtComplemento.Enabled = false;
        }
        private void CarregarCamposFalse()
        {
            txtNome.Enabled = false;
            mskCpf.Enabled = false;
            mskTelefone.Enabled = false;
            txtEmail.Enabled = false;
            cmbEditarDepartamento.Enabled = false;
            dtpNascimento.Enabled = false;
            chkColaboradorAtivo.Enabled = false;
        }
        private void CarregarCampos()
        {
            txtNome.Enabled = true;
            mskCpf.Enabled = true;
            mskTelefone.Enabled = true;
            txtEmail.Enabled = true;
            cmbEditarDepartamento.Enabled = true;
            dtpNascimento.Enabled = true;
            chkColaboradorAtivo.Enabled = true;
            mxtCep.Enabled = true;
        }
        private void CarregarDepartamento()
        {

            var resultado = _colaboradorRepository.ObterDepartamento();
            cmDepartamento.DataSource = resultado;

        }

        private void btnRegarregar_Click(object sender, EventArgs e)
        {
            CarregarColaboradores();
        }


        private void btnNovoColaborador_Click(object sender, EventArgs e)
        {
            tabColaborador.SelectTab(1);
            CarregarCamposFalseCep();

        }
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            tabColaborador.SelectTab(0);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var departamento = cmDepartamento.Text;
            var resultado = _colaboradorRepository.FiltrarDepartamento(departamento);
            dgvColaborador.DataSource = resultado;
        }

        private void cmDepartamentoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var resultado = _colaboradorRepository.ObterDepartamento();
            cmDepartamento.DataSource = resultado;

        }

        private void dgvColaborador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvColaborador.Rows[e.RowIndex];

            if (dgvColaborador.Columns[e.ColumnIndex].Name == "gvDeletar")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idRow = int.Parse(row.Cells[0].Value.ToString());

                    var resultado = _colaboradorRepository.Deletar(idRow);

                    if (resultado == true)
                    {
                        MessageBox.Show("Produto Deletado com Sucesso!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarColaboradores();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro Tente Novamente!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                };
                return;
            }
            if (dgvColaborador.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (MessageBox.Show("Deseja realmente Editar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idRow = int.Parse(row.Cells[0].Value.ToString());

                    var resultadoLista = _colaboradorRepository.ObterPorId(idRow);
                    txtNome.Focus();

                    var resultado = resultadoLista[0];

                    var editCategoria = _colaboradorRepository.ObterDepartamento();
                    cmbEditarDepartamento.DataSource = editCategoria;
                    cmbEditarDepartamento.Text = resultado.Departamento;

                    txtNome.Text = resultado.Nome;
                    txtEmail.Text = resultado.Email;
                    chkStatus.Checked = resultado.Status;
                    mskCpf.Text = resultado.Cpf;
                    mskTelefone.Text = resultado.Telefone;


                    this.Size = new Size(1047, 592);

                };
                return;
            }
        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mskCpf.Text == "")

                MessageBox.Show("Informe um CPF!", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (ValidatorCpf.ValidarCpf(mskCpf.Text))
                {
                    mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                    try
                    {

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao inserir Colaborador\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Informe um CPF válido!", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            var nome = txtNome.Text;
            var cpf = mskCpf.Text;
            var telefone = mskTelefone.Text;
            var email = txtEmail.Text;
            var departamento = cmbEditarDepartamento.Text;
            var dataNascimento = dtpNascimento.Text;
            var cep = mskCpf.Text;
            var estado = txtUf.Text;
            var cidade = txtCidade.Text;
            var numero = txtNumero.Text;
            var logadouro = txtLogadouro.Text;
            var rua = txtRua.Text;
            var bairro = txtBairro.Text;
            var complemento = txtComplemento.Text;
            bool status = chkColaboradorAtivo.Checked;

            var novoColaborador = new Colaborador1
            {
                Nome = nome,
                Cpf = cpf,
                Telefone = telefone,
                Email = email,
                Departamento = departamento,
                DataNascimento = dataNascimento,
                Cep = cep,
                Estado = estado,
                Cidade = cidade,
                Numero = numero,
                Logradouro = logadouro,
                Rua = rua,
                Bairro = bairro,
                Complemento = complemento,
                Status = status,

            };


            var resultado = _colaboradorRepository.Incluir(novoColaborador);
            CarregarColaboradores();
            dgvColaborador.DataSource = resultado;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabLista_Click(object sender, EventArgs e)
        {

        }
    }
}


