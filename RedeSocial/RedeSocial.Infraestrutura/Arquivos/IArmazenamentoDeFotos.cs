using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RedeSocial.Infraestrutura.Arquivos
{
    public interface IArmazenamentoDeFotos
    {
        Task<Uri> ArmazenarFotoDePerfil(IFormFile foto);
        Uri ArmazenarFotoDoPost(IFormFile foto);
    }
}
