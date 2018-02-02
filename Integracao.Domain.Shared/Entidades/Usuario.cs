namespace Contmatic.Integracao.Domain.Entidades.Shared
{
    public abstract class Usuario
    {
        protected  Usuario()
        {
            
        }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}