using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TDSTecnologia.Site.Core.Entities;

namespace TDSTecnologia.Site.Core.Utilitarios
{
    public class UtilImagem
    {
        public static async void ConverterParaByte(Curso curso,IFormFile arquivo)
        {
            if (arquivo != null && arquivo.ContentType.ToLower().StartsWith("image/"))
            {
                MemoryStream ms = new MemoryStream();
                await arquivo.OpenReadStream().CopyToAsync(ms);
                curso.Banner = ms.ToArray();
            }
        }
    }
}
