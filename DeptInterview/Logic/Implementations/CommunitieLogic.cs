using Logic.Contracts;
using Logic.Entities;
using Logic.Interfaces.Repositories;

using System.Threading.Tasks;

namespace Logic.Implementations
{
    public class CommunitieLogic : ICommunitieLogic
    {
        private readonly ICommunitiesRepository communitiesRepository;

        public CommunitieLogic(ICommunitiesRepository communitiesRepository)
        {
            this.communitiesRepository = communitiesRepository;
        }

        public async Task<Communite> GetCommunitieById(int id)
        {
            return await communitiesRepository.GetById(id);
        }
    }
}
