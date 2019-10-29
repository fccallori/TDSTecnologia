using System;
using System.Collections.Generic;
using System.Text;

namespace TDSTecnologia.Site.Infrastructure.Integrations
{
    public class ConfiguracoesEmail
    {
        public string Endereco { get; set; }

        public int Porta { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Destinatario { get; set; }
    }
}
