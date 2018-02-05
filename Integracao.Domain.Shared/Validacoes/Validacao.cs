using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;

namespace Integracao.Domain.Shared.Validacoes
{
    public class Validacao
    {
        private IList<ValidationFailure> _erros = null;
        
        public IReadOnlyCollection<ValidationFailure> Erros { get { return _erros.ToArray(); } }
        public bool Valido { get { return _erros.Count == 0; } }

        public bool Invalido{ get { return _erros.Count > 0; } }
        
        public Validacao()
        {
            _erros = new List<ValidationFailure>();
        }

        public void IncluirValidacao(ValidationResult resultado)
        {
            if (!resultado.IsValid)
                foreach (var erro in resultado.Errors)
                    _erros.Add(erro);

        }
    }
}