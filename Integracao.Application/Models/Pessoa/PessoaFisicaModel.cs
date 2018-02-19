namespace Contmatic.Integracao.Application.Models
{
    public class PessoaFisicaModel : PessoaModel
    {
        public string CPF { get; set; }

        public string PrimeiroNome { get; set; }

        public string SobreNome { get; set; }
    }
}