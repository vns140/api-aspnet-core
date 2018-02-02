using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades.Shared
{
    public abstract class Cliente
    {
        protected Cliente() { }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string Codigo { get; set; }
        public string Apelido { get; set; }
        public Email Email { get; set; }
    }
}