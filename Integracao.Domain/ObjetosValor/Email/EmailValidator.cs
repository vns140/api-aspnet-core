using System;
using System.Text.RegularExpressions;
using FluentValidation;
using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.ObjetosValor.Validacoes
{
    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(email => email.Endereco).Must(x => x.Length <= 100).WithMessage("Email precisa ter no máximo 100 caracteres.");            
            RuleFor(email => email.Endereco).Must(ValidaEmail).WithMessage("Email inválido.");
        }

        private bool ValidaEmail(string valor)
        {
            return Regex.IsMatch(valor,
                "((?:[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]{1,65}(?:\\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*|(\".+\")|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9.])?|localserver|((?!localhost)[0-9a-zA-Z:\\[\\]])*|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-zA-Z0-9-]*[a-zA-Z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\]))",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));//Expression da galera do Java
        }
    }
}