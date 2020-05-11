using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial.Apresentacao.Services
{
    public class RedeSocialApi : IRedeSocialApi
    {
        
        public ActionResult Delete(string recurso, object dados)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get<T>(string recurso, object filtros) where T : class
        {
            throw new NotImplementedException();
        }

        public async Task Post(string recurso, object dados)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:5000");
            httpClient.DefaultRequestHeaders.Add("accept", "application/json");

            var perfil = JsonConvert.SerializeObject(dados);

            var content = new StringContent(perfil, Encoding.UTF8, "application/json");

            var responseMessage = await httpClient.PostAsync("/api/" + recurso, content);

            if (responseMessage.IsSuccessStatusCode)
            {

            }
            else
            {

            }
        }

        public ActionResult Put(string recurso, object dados)
        {
            throw new NotImplementedException();
        }
    }
}
