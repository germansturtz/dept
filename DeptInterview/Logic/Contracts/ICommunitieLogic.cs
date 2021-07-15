using Logic.Entities;

using System.Threading.Tasks;

namespace Logic.Contracts
{
    public interface ICommunitieLogic
    {
        Task<Communite> GetCommunitieById(int id);
    }
}
