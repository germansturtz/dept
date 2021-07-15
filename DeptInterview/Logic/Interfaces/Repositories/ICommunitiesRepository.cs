using Logic.Entities;

using System.Threading.Tasks;

namespace Logic.Interfaces.Repositories
{
    public interface ICommunitiesRepository
    {
        Task<Communite> GetById(int id);
    }
}
