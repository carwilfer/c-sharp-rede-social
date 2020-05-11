using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RedeSocial.Infraestrutura.Arquivos
{
    public class ArmazenamentoDeFotosComAws : IArmazenamentoDeFotos
    {
        public Task<Uri> ArmazenarFotoDePerfil(IFormFile foto)
        {
            throw new NotImplementedException();
        }

        public Uri ArmazenarFotoDoPost(IFormFile foto)
        {
            throw new NotImplementedException();
        }
    }
}
