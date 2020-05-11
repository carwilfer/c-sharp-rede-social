using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RedeSocial.Infraestrutura
{
    public interface IArmazenamentoDeFotos
    {
        Task<Uri> ArmazenarFotoDePerfil(IFormFile foto);
    }
}
