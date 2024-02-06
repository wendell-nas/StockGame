using MailKit.Net.Smtp;
using MimeKit;
using StockApp.Core.Repository;
using StockApp.Core.Templetes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Entidades
{
    public class EmailService
    {
        IColaboradorRepository _colaboradorRepository;


        private const string SenhaApp = "kunw wqlu dbmk yswl";
        private const string UsuarioApp = "tiago.s.nascimento6@aluno.senai.br";
        private const string GmailSmtp = "smtp.gmail.com";
        private const int GmailPorta = 587;

        public string Remetente { get; private set; }
        public string Destinatario { get; private set; }
        public string Assunto { get; private set; }
        public string Mensagem { get; private set; }

        public EmailService (string destinatario)
        {
            Destinatario = destinatario;
            Remetente = "tiago.s.nascimento6@aluno.senai.br";
        }


        public bool EmailRecuperarSenha(string email, string novaSenha)
        {

            var colaborador = new Colaborador
            {
                Email = email,
                Senha = novaSenha
            };
            
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("", Remetente));
            message.To.Add(new MailboxAddress("", Destinatario));
            message.Subject = "StockGame - Recuperação de Senha";

            var corpoEmail = EmailTemplate.RecuperarSenha;
  
            corpoEmail = corpoEmail.Replace("{{senha}}", colaborador.Senha);
            
            message.Body = new TextPart("html")
            {
                Text = corpoEmail
            };

            using (var client = new SmtpClient())
            {
                client.Connect(GmailSmtp, GmailPorta, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(UsuarioApp, SenhaApp);

                client.Send(message);
                client.Disconnect(true);
            }

            return true;
        }
    }
}
