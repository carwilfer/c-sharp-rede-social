using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedeSocial.Apresentacao.Services
{
    public interface IRedeSocialApi
    {
        Task Post(string recurso, object dados);
        ActionResult Put(string recurso, object dados);
        ActionResult Delete(string recurso, object dados);
        IEnumerable<T> Get<T>(string recurso, object filtros) where T : class;
    }
}
