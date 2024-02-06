namespace StockApp.Desktop.Forms.Usuarios
{
    partial class RecuperarSenhaView
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
            label1 = new Label();
            txtEmail = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(213, 56);
            label1.Name = "label1";
            label1.Size = new Size(93, 41);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 101);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(285, 27);
            txtEmail.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.LightCyan;
            btnEnviar.ForeColor = Color.Red;
            btnEnviar.Location = new Point(194, 203);
            btnEnviar.Margin = new Padding(3, 4, 3, 4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(123, 39);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += button1_Click;
            // 
            // RecuperarSenhaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(518, 297);
            Controls.Add(btnEnviar);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RecuperarSenhaView";
            Text = "Recuperar Senha";
            Load += RecuperarSenhaView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnEnviar;
    }
}