using GoData.Core.Repositories;
using GoData.Entities.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GoData.Core.Logic
{
    public class UserLogic
    {
        private UserRepository _userRepository;
        private UnitMemberRepository _unitMemberRepository;

        public UserLogic(UserRepository userRepository,
            UnitMemberRepository unitMemberRepository)
        {
            _userRepository = userRepository;
            _unitMemberRepository = unitMemberRepository;
        }

        public User GetUserByUserObjectId(string objectId)
        {
            System.Linq.Expressions.Expression<Func<User, bool>> expression = u => u.UserObjectId == objectId;

            return _userRepository.GetItems(expression)?.FirstOrDefault() != null
                ? _userRepository.GetItems(expression).FirstOrDefault() : null;
        }

        public async Task<User> AddUser(User user)
        {
            //make checks
            if (user.UserObjectId == null || user.Roles == null)
                throw new ArgumentNullException();


            return await _userRepository.AddItemAsync(user);

        }

        public User GetUserById(int userId)
        {
            return _userRepository.GetItemById<int>(userId);
        }

        public User UpdateUserAsync(User user)
        {
            return _userRepository.UpdateItemAsync(user);
        }

        public IEnumerable<Unit> GetUserUnitsInOrganization(int userId, int organizationId)
        {
            List<Unit> Units = new List<Unit>();

            Expression<Func<UnitMember, bool>> expression = u => u.Unit.Organization.Id == organizationId && u.UserId == userId;

            var unitMembers = _unitMemberRepository.GetItems(expression);

            foreach (var item in unitMembers)
            {
                Units.Add(item.Unit);
            }

            return Units;
        }
    }
}
