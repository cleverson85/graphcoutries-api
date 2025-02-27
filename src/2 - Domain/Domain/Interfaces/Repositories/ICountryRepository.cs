﻿using Domain.Models;
using System.Threading.Tasks;
using ToDo.Domain.Interfaces.Repository;

namespace Domain.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> FindUser();
    }
}
