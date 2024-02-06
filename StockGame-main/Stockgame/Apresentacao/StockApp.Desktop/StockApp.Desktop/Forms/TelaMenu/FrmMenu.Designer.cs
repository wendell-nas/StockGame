namespace StockApp.Desktop.Forms.TelaMenu
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            slidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel2 = new Panel();
            btnInicio = new Button();
            panel8 = new Panel();
            btnProdutos = new Button();
            panel6 = new Panel();
            btnUsuarios = new Button();
            panel5 = new Panel();
            btnColaboradores = new Button();
            panel4 = new Panel();
            btnClientes = new Button();
            panel3 = new Panel();
            btnCategorias = new Button();
            slideBarTimer = new System.Windows.Forms.Timer(components);
            telaCentral = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            slidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)telaCentral).BeginInit();
            SuspendLayout();
            // 
            // slidebar
            // 
            slidebar.BackColor = Color.DodgerBlue;
            slidebar.Controls.Add(panel1);
            slidebar.Controls.Add(panel2);
            slidebar.Controls.Add(panel8);
            slidebar.Controls.Add(panel6);
            slidebar.Controls.Add(panel5);
            slidebar.Controls.Add(panel4);
            slidebar.Controls.Add(panel3);
            slidebar.Dock = DockStyle.Left;
            slidebar.Location = new Point(0, 0);
            slidebar.MaximumSize = new Size(208, 644);
            slidebar.MinimumSize = new Size(67, 644);
            slidebar.Name = "slidebar";
            slidebar.Size = new Size(208, 644);
            slidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 108);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(69, 40);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(9, 33);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(41, 37);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnInicio);
            panel2.Location = new Point(3, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 44);
            panel2.TabIndex = 1;
            // 
            // btnInicio
            // 
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInicio.ForeColor = SystemColors.Control;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(-9, -7);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(20, 0, 0, 0);
            btnInicio.Size = new Size(237, 60);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "           Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnProdutos);
            panel8.Location = new Point(3, 167);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 44);
            panel8.TabIndex = 7;
            // 
            // btnProdutos
            // 
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProdutos.ForeColor = SystemColors.Control;
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(-9, -8);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Padding = new Padding(20, 0, 0, 0);
            btnProdutos.Size = new Size(237, 60);
            btnProdutos.TabIndex = 0;
            btnProdutos.Text = "           Produtos";
            btnProdutos.TextAlign = ContentAlignment.MiddleLeft;
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnUsuarios);
            panel6.Location = new Point(3, 217);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 44);
            panel6.TabIndex = 5;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = SystemColors.Control;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(-9, -8);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(20, 0, 0, 0);
            btnUsuarios.Size = new Size(237, 60);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "           Usuários";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnColaboradores);
            panel5.Location = new Point(3, 267);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 44);
            panel5.TabIndex = 4;
            // 
            // btnColaboradores
            // 
            btnColaboradores.FlatStyle = FlatStyle.Flat;
            btnColaboradores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnColaboradores.ForeColor = SystemColors.Control;
            btnColaboradores.Image = (Image)resources.GetObject("btnColaboradores.Image");
            btnColaboradores.ImageAlign = ContentAlignment.MiddleLeft;
            btnColaboradores.Location = new Point(-9, -8);
            btnColaboradores.Name = "btnColaboradores";
            btnColaboradores.Padding = new Padding(20, 0, 0, 0);
            btnColaboradores.Size = new Size(237, 60);
            btnColaboradores.TabIndex = 0;
            btnColaboradores.Text = "           Colaboradores";
            btnColaboradores.TextAlign = ContentAlignment.MiddleLeft;
            btnColaboradores.UseVisualStyleBackColor = true;
            btnColaboradores.Click += btnColaboradores_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnClientes);
            panel4.Location = new Point(3, 317);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 44);
            panel4.TabIndex = 3;
            // 
            // btnClientes
            // 
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = SystemColors.Control;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(-9, -8);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(20, 0, 0, 0);
            btnClientes.Size = new Size(237, 60);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "           Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCategorias);
            panel3.Location = new Point(3, 367);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 44);
            panel3.TabIndex = 2;
            // 
            // btnCategorias
            // 
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategorias.ForeColor = SystemColors.Control;
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(-9, -8);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Padding = new Padding(20, 0, 0, 0);
            btnCategorias.Size = new Size(237, 60);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "           Categorias";
            btnCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // slideBarTimer
            // 
            slideBarTimer.Interval = 10;
            slideBarTimer.Tick += slideBarTimer_Tick;
            // 
            // telaCentral
            // 
            telaCentral.Image = (Image)resources.GetObject("telaCentral.Image");
            telaCentral.Location = new Point(208, 72);
            telaCentral.Name = "telaCentral";
            telaCentral.Size = new Size(1129, 572);
            telaCentral.SizeMode = PictureBoxSizeMode.CenterImage;
            telaCentral.TabIndex = 1;
            telaCentral.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DodgerBlue;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(208, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1129, 73);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 645);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(telaCentral);
            Controls.Add(slidebar);
            ForeColor = Color.Black;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockGame";
            slidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)telaCentral).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel slidebar;
        private Panel panel1;
        private Button btnInicio;
        private Panel panel2;
        private Panel panel3;
        private Button btnCategorias;
        private Panel panel4;
        private Button btnClientes;
        private Panel panel5;
        private Button btnColaboradores;
        private Panel panel6;
        private Button btnUsuarios;
        private Label label1;
        private PictureBox menuButton;
        private System.Windows.Forms.Timer slideBarTimer;
        private Panel panel8;
        private Button btnProdutos;
        private PictureBox telaCentral;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}