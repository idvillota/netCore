using Contracts;
using Entities;
using Entities.ExtendedModels;
using Entities.Extensions;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CrearUser(User user)
        {
            var maxId = GetAllUsers().Max(u => u.Id);
            user.Id = maxId + 1;
            Create(user);
            Save();
        }

        public void DeleteUser(User user)
        {
            Delete(user);
            Save();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return FindAll().OrderBy(u => u.Name);
        }

        public User GetUserById(decimal id)
        {
            return FindByCondition(u => u.Id.Equals(id))
                .DefaultIfEmpty(new User()).
                FirstOrDefault();
        }

        public UserExtended GetUserWithDetails(decimal id)
        {
            return new UserExtended(GetUserById(id));
        }

        public void UpdateUser(User dbUser, User user)
        {
            dbUser.Map(user);
            Update(dbUser);
            Save();
        }
    }
}
