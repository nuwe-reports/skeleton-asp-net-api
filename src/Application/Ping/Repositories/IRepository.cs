using System.Threading.Tasks;

namespace CleanArchitecture.Application.Ping.Repositories
{
    public interface IRepository
    {
        Task<int> GetQueryAsync();
    }
}