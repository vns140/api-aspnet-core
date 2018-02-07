using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using Contmatic.Integracao.Domain.Shared.Enums;
using static Contmatic.Integracao.Domain.Shared.Enums.ETelefone;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Telefone : ObjetoValor
    {
        private Telefone(string dDI, string dDD, string numero,TipoTelefone tipo)
        {
            DDI = dDI;
            DDD = dDD;
            Numero = numero;
            NumeroConfirmado = false;
            Tipo = tipo;
        }

        public static Telefone Factory(string dDI, string dDD, string numero, TipoTelefone tipo)
        {
            Telefone telefone = new Telefone(dDI, dDD, numero,tipo);
            return telefone;
        }

        public TipoTelefone Tipo { get; private set;}
        public string DDI { get; }
        public string DDD { get; }
        public string Numero { get; }
        public bool NumeroConfirmado { get; private set;}

        public void ConfirmarNumero()
        {
            NumeroConfirmado = true;
        }

        public void TipoCelular()
        {
            Tipo = TipoTelefone.Celular;
        }

        public void TipoResidencial()
        {
            Tipo = TipoTelefone.Residencial;
        }

        public void TipoComercial()
        {
            Tipo = TipoTelefone.Comercial;
        }
    }
}