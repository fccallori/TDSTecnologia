﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TDSTecnologia.Site.Infrastructure.Integrations
{
    public interface IEmail
    {
        Task EnviarEmail(string email, string assunto, string mensagem);
    }
}
