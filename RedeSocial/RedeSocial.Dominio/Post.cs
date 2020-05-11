using System;
using System.Collections.Generic;
using System.Text;

namespace RedeSocial.Dominio
{
    public class Post
    {
        public int Id { get; set; }
        public Perfil Owner { get; set; }
        public string Texto { get; set; }
    }
}
