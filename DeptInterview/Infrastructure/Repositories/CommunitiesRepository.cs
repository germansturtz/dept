using Logic.Entities;
using Logic.Interfaces.Repositories;

using Nest;

using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CommunitiesRepository : ICommunitiesRepository
    {
        public readonly IElasticClient elasticClient;

        public CommunitiesRepository(IElasticClient elasticClient)
        {
            this.elasticClient = elasticClient;
        }

        public async Task<Communite> GetById(int id)
        {
            var result = await elasticClient.GetAsync<Communite>(id, e => e.Index("communities"));

            return result.Source;
        }
    }
}
