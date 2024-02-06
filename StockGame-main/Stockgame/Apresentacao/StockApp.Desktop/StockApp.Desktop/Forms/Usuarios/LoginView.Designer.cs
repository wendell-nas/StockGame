namespace StockApp.Desktop.Forms.Usuarios
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-185, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(890, 756);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 192);
            label1.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(726, 43);
            label1.Name = "label1";
            label1.Size = new Size(135, 51);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CornflowerBlue;
            label2.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(204, 316);
            label2.Name = "label2";
            label2.Size = new Size(0, 51);
            label2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(718, 148);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(129, 113);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(693, 281);
            label3.Name = "label3";
            label3.Size = new Size(228, 23);
            label3.TabIndex = 6;
            label3.Text = "Faça o Seu Login Aqui";
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.FromArgb(125, 137, 149);
            txtEmail.Location = new Point(672, 325);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 26);
            txtEmail.TabIndex = 7;
            // 
            // txtSenha
            // 
            txtSenha.ForeColor = Color.FromArgb(125, 137, 149);
            txtSenha.Location = new Point(672, 407);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(261, 26);
            txtSenha.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonHighlight;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(623, 316);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ButtonHighlight;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(623, 399);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(34, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(722, 445);
            label4.Name = "label4";
            label4.Size = new Size(136, 18);
            label4.TabIndex = 11;
            label4.Text = "Recuperar Senha";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(722, 521);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 12;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = Properties.Resources.icons8_x_48;
            button2.Location = new Point(1062, 2);
            button2.Name = "button2";
            button2.Size = new Size(49, 48);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1111, 740);
            Controls.Add(button2);
            Controls.Add(pictureBox5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginView";
            Text = "LoginView";
            Load += LoginView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}