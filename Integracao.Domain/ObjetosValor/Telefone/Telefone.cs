using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using Contmatic.Integracao.Domain.ObjetosValor.Validacoes;
using Contmatic.Integracao.Domain.Shared.Enums;
using static Contmatic.Integracao.Domain.Shared.Enums.ETelefone;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Telefone : ObjetoValor
    {
        private Telefone(int dDI, int dDD, int numero,TipoTelefone tipo)
        {
            DDI = dDI;
            DDD = dDD;
            Numero = numero;
            NumeroConfirmado = false;
            Tipo = tipo;
        }

        public static Telefone Factory(int dDI, int dDD, int numero, TipoTelefone tipo)
        {
            Telefone telefone = new Telefone(dDI, dDD, numero,tipo);
            TelefoneValidator telefoneValidator = new TelefoneValidator();

            telefone.IncluirValidacao(telefoneValidator.Validate(telefone));
            return telefone;
        }

        public TipoTelefone Tipo { get; private set;}
        public int DDI { get; private set; }
        public int DDD { get; private set; }
        public int Numero { get; private set; }
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