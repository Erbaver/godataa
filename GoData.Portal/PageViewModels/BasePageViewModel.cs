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
        [Inject]
        private UserLogic _userLogic { get; set; }

        public BasePageViewModel(int userId)
        {

        }

        public string PageName { get; set; }

        public List<Unit> Units { get; set; }

        public List<Unit> GetUnits(int id)
        {
            throw new NotImplementedException();
        } 

    }
}
