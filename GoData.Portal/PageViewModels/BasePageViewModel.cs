using GoData.Core.Logic;
using GoData.Entities.Entities;
using GoData.Portal.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoData.Portal.PageViewModels
{
    public class BasePageViewModel : IPageViewModel
    {
        
        public UserLogic _userLogic { private get; set; }

        private int _userId;

        public BasePageViewModel(int userId, UserLogic userLogic)
        {
            _userId = userId;
            _userLogic = userLogic;
        }

        public string PageName { get; set; }

        public IEnumerable<Unit> Units { get { return GetUnits(_userId);  }}

        public IEnumerable<Unit> GetUnits(int id)
        {
            int organizationId = _userLogic.GetUserById(id).DefaultOrganization;
            return _userLogic.GetUserUnitsInOrganization(id, organizationId);
        } 

    }
}
