using DomainData;
using DomainRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DomainService
{
    public interface IUserService : IRepository<User>
    {
        Task<User> GetUserByEmail(string email);
    }
}
