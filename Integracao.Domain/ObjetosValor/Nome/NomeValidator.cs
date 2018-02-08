using FluentValidation;

namespace Contmatic.Integracao.Domain.ObjetosValor.Validacoes
{
    public class NomeValidator : AbstractValidator<Nome>
    {
       public NomeValidator()
        {
            RuleFor(nome => nome.PrimeiroNome).NotEmpty().WithMessage("Nome é obrigatório.");
            RuleFor(nome => nome.PrimeiroNome).Length(2, 30).WithMessage("Nome precisa ter no mínimo de 2 e máximo de 30 caracteres.");
            RuleFor(nome => nome.PrimeiroNome).Must(VerificaNomeAbreviado).WithMessage("Nome não pode ser abreviado.");
            RuleFor(nome => nome.PrimeiroNome).Must(VerificaContemNumero).WithMessage("Nome não pode conter números");
            RuleFor(nome => nome.PrimeiroNome).Must(VerificaCaracterEspecial).WithMessage("Nome não pode conter caracteres especiais");
            RuleFor(nome => nome.SobreNome).Length(2, 30).WithMessage("Sobrenome precisa ter no mínimo de 2 e máximo de 30 caracteres.");            
            RuleFor(nome => nome.SobreNome).Must(VerificaNomeAbreviado).WithMessage("Sobrenome nome não pode ser abreviado.");            
            RuleFor(nome => nome.SobreNome).Must(VerificaContemNumero).WithMessage("Sobrenome não pode conter números");
            RuleFor(nome => nome.SobreNome).Must(VerificaCaracterEspecial).WithMessage("Sobrenome não pode conter caracteres especiais");
        }
        
        private bool VerificaNomeAbreviado(string valor)
        {
            return !valor.EndsWith(".");
        }

        private bool VerificaContemNumero(string valor)
        {
            for (int i = 0; i < valor.Length; i++)
            {
                if(char.IsNumber(valor, i))
                    return false;
            }

            return true;
        }

        private bool VerificaCaracterEspecial(string valor)
        {
            string[] caracteres = { "!", "@", "#", "$", "%", "¨", "&", "*", "(", ")", "[", "]", "{", "}", ",", ".", ";", ":" };

            for (int i = 0; i < caracteres.Length; i++) 
            {
                if(valor.Contains(caracteres[i]))
                    return false;
            }

            return true;
        }
    }
}