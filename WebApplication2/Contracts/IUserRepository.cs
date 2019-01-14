using Entities.ExtendedModels;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IEnumerable<User> GetAllUsers();

        User GetUserById(decimal id);

        UserExtended GetUserWithDetails(decimal id);

        void CrearUser(User user);

        void UpdateUser(User dbUser, User user);

        void DeleteUser(User user);
    }
}
