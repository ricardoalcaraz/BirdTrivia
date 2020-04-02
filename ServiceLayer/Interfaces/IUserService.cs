using DataAccessLayer;
using System;


namespace ServiceLayer.Interfaces
{
    public interface IUserService
    {
        public User CreateUser(User user);
        public int GetTallyCount();

    }
}
