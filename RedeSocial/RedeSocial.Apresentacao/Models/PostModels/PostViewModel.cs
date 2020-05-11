using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedeSocial.Apresentacao.Models.PostModels
{
    public class PostViewModel
    {
        public string Texto { get; set; }
        public List<string> Comentarios { get; set; } = new List<string>();
    }
}
