using Contmatic.Integracao.Domain.Entidades;
using Contmatic.Integracao.Domain.ObjetosValor;
using MongoDB.Driver;

namespace Contmatic.Integracao.Infrastructure.Data
{
    public class Contexto
    {
        MongoClient _mongoClient;
        IMongoDatabase _mongoDatabase;

        //declaração das collections
        public IMongoCollection<Convite> Convites { get; set; }
      
        public Contexto()
        {
            _mongoClient = new MongoClient("mongodb://localhost:27017");      
            _mongoDatabase = _mongoClient.GetDatabase("Integracao"); 

            //configuração das collections 
            Convites = _mongoDatabase.GetCollection<Convite>(typeof(Convite).Name +"s");
           
        }
    }
}