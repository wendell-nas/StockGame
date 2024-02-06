using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Templetes
{
    public static class EmailTemplate
    {
        public const string RecuperarSenha = @"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd""><html dir=""ltr"" xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office""><head><meta charset=""UTF-8""><meta content=""width=device-width, initial-scale=1"" name=""viewport""><meta name=""x-apple-disable-message-reformatting""><meta http-equiv=""X-UA-Compatible"" content=""IE=edge""><meta content=""telephone=no"" name=""format-detection""><title></title><!--[if (mso 16)]>
    <style type=""text/css"">
    a {text-decoration: none;}
    </style>
    <![endif]--><!--[if gte mso 9]><style>sup { font-size: 100% !important; }</style><![endif]--><!--[if gte mso 9]>
<xml>
    <o:OfficeDocumentSettings>
    <o:AllowPNG></o:AllowPNG>
    <o:PixelsPerInch>96</o:PixelsPerInch>
    </o:OfficeDocumentSettings>
</xml>
<![endif]--><!--[if !mso]><!-- --><link href=""https://fonts.googleapis.com/css2?family=Orbitron&display=swap"" rel=""stylesheet""><!--<![endif]--><!--[if mso]>
 <style type=""text/css"">
     ul {
  margin: 0 !important;
  }
  ol {
  margin: 0 !important;
  }
  li {
  margin-left: 47px !important;
  }

 </style><![endif]
--></head><body class=""body""><div dir=""ltr"" class=""es-wrapper-color""><!--[if gte mso 9]>
			<v:background xmlns:v=""urn:schemas-microsoft-com:vml"" fill=""t"">
				<v:fill type=""tile"" color=""#07023c""></v:fill>
			</v:background>
		<![endif]--><table class=""es-wrapper"" width=""100%"" cellspacing=""0"" cellpadding=""0""><tbody><tr><td class=""esd-email-paddings"" valign=""top""><table class=""es-content esd-footer-popover"" cellspacing=""0"" cellpadding=""0"" align=""center""><tbody><tr><td class=""esd-stripe"" align=""center""><table class=""es-content-body"" style=""background-color: #ffffff; background-image: url(https://fckzkgr.stripocdn.email/content/guids/CABINET_0e8fbb6adcc56c06fbd3358455fdeb41/images/vector_0Ia.png); background-repeat: no-repeat; background-position: center center;"" width=""600"" cellspacing=""0"" cellpadding=""0"" bgcolor=""#ffffff"" align=""center"" background=""https://fckzkgr.stripocdn.email/content/guids/CABINET_0e8fbb6adcc56c06fbd3358455fdeb41/images/vector_0Ia.png"" esd-img-prev-position=""center center""><tbody><tr _msthidden=""2""><td class=""esd-structure es-p20t es-p10b es-p20r es-p20l"" align=""left"" _msthidden=""2""><table cellpadding=""0"" cellspacing=""0"" width=""100%"" _msthidden=""1""><tbody _msthidden=""1""><tr _msthidden=""1""><td width=""560"" class=""es-m-p0r esd-container-frame"" valign=""top"" align=""center"" _msthidden=""1""><table cellpadding=""0"" cellspacing=""0"" width=""100%""><tbody><tr><td align=""center"" class=""esd-block-image"" style=""font-size: 0px;""><a target=""_blank""><img class=""adapt-img"" src=""https://fckzkgr.stripocdn.email/content/guids/2f93d176-9ea6-46da-a390-35b973150433/images/stockgame_oficial_png.png"" alt="""" style=""display: block;"" width=""200""></a></td></tr></tbody></table></td></tr></tbody></table></td></tr><tr><td class=""esd-structure es-p30t es-p30b es-p20r es-p20l"" align=""left""><table width=""100%"" cellspacing=""0"" cellpadding=""0""><tbody><tr><td class=""es-m-p0r es-m-p20b esd-container-frame"" width=""560"" valign=""top"" align=""center""><table width=""100%"" cellspacing=""0"" cellpadding=""0""><tbody><tr><td align=""center"" class=""esd-block-text""><h1 _msttexthash=""1818739"" _msthash=""3877""> Recebemos uma solicitação para redefinir sua senha</h1></td></tr><tr><td align=""center"" class=""esd-block-image es-p15t es-p10b"" style=""font-size: 0px;""><a target=""_blank"" href=""https://viewstripo.email""><img class=""adapt-img"" src=""https://fckzkgr.stripocdn.email/content/guids/CABINET_dee64413d6f071746857ca8c0f13d696/images/852converted_1x3.png"" alt="""" style=""display: block;"" height=""300""></a></td></tr><tr><td align=""center"" class=""esd-block-text es-p10t es-p10b""><p _msttexthash=""2360605"" _msthash=""3878"">Esqueceu sua senha? Não tem problema - acontece com todo mundo!</p><p><br></p><p><font _mstmutation=""1"" _msttexthash=""810927"" _msthash=""3879"">Essa é a sua nova Senha : {{senha}}</font><br></p><p><br></p><p><font _mstmutation=""1"" _msttexthash=""3166657"" _msthash=""3880"">&nbsp;Você pode alterar sua senha em configurações ou entre em contato com o RH</font></p></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table></div></body></html>";
    }
}
