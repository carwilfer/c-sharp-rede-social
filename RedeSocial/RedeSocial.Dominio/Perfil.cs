using System;

namespace RedeSocial.Dominio
{
    public class Perfil
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string UrlFoto { get; set; }
    }
}
