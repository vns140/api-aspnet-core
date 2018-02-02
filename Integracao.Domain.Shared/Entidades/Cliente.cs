using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades.Shared
{
    public abstract class Cliente
    {

        #region constructors
        protected Cliente() { }
        protected Cliente(string cNPJ, string razaoSocial, string codigo, string apelido, Email email)
        {
            CNPJ = cNPJ;
            RazaoSocial = razaoSocial;
            Codigo = codigo;
            Apelido = apelido;
            Email = email;
        }

        #endregion

        #region properties
        
        public string CNPJ { get; }
        public string RazaoSocial { get; }
        public string Codigo { get; }
        public string Apelido { get; }
        public Email Email { get; }

        #endregion


    }
}