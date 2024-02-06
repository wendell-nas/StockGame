using StockApp.Core.Entidades;
using StockApp.Desktop.Forms.Categorias;
using StockApp.Desktop.Forms.Clientes;
using StockApp.Desktop.Forms.Colaborador;
using StockApp.Desktop.Forms.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp.Desktop.Forms.TelaMenu
{
    public partial class FrmMenu : Form
    {
        bool slidebarExpand;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void slideBarTimer_Tick(object sender, EventArgs e)
        {
            if (slidebarExpand)
            {
                slidebar.Width -= 10;
                if (slidebar.Width == slidebar.MinimumSize.Width)
                {
                    slidebarExpand = false;
                    slideBarTimer.Stop();
                }
            }
            else
            {
                slidebar.Width += 10;
                if (slidebar.Width == slidebar.MaximumSize.Width)
                {
                    slidebarExpand = true;
                    slideBarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            slideBarTimer.Start();

        }

        public void CarregamentoDoFormulario(object Form)
        {
            if (this.telaCentral.Controls.Count > 0)
                this.telaCentral.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.telaCentral.Controls.Add(f);
            this.telaCentral.Tag = f;
            f.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            CarregamentoDoFormulario(new FrmCategoria());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CarregamentoDoFormulario(new ClientesView());
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            CarregamentoDoFormulario(new ColaboradorView());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            CarregamentoDoFormulario(new ProdutoView());
        }
    }
}
