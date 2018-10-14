using GoData.Core.Repositories;
using GoData.Entities.Entities;
using System;
using System.Linq;

namespace GoData.Core.Logic
{
    public class UserLogic
    {
        private UserRepository _repository;

        public UserLogic(UserRepository repository)
        {
            _repository = repository;
        }

        public User GetUserByUserObjectId(string objectId)
        {
            System.Linq.Expressions.Expression<Func<User, bool>> expression = u => u.UserObjectId == objectId;

            return _repository.GetItems(expression)?.FirstOrDefault() != null 
                ? _repository.GetItems(expression).FirstOrDefault() : null;
        }
    }
}
