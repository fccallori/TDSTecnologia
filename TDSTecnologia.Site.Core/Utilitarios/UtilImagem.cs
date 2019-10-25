using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TDSTecnologia.Site.Core.Entities;

namespace TDSTecnologia.Site.Core.Utilitarios
{
    public class UtilImagem
    {
        public static byte[] ConverterParaByte(IFormFile arquivo)
        {
            if (arquivo != null && arquivo.ContentType.ToLower().StartsWith("image/"))
            {
                MemoryStream ms = new MemoryStream();
                arquivo.OpenReadStream().CopyToAsync(ms);
               return ms.ToArray();
            }
            return null;
        }

        public static string ConverterByteArrayParaStringBase64(byte[] imagem)
        {
            return imagem != null ? "data:image/png;base64," + Convert.ToBase64String(imagem, 0, imagem.Length) : null;
        }
    }
}
