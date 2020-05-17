using System;
using System.Collections.Generic;
using System.Text;

namespace RedeSocial.Dominio.Modelo
{
    public class Post
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string UrlFoto { get; set; }
        public string Proprietario { get; set; }
    }
}
