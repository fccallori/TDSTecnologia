
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TDSTecnologia.Site.Core.Entities
{
    public class Permissao : IdentityRole
    {
        public string Descricao { get; set; }
        
    }
}
