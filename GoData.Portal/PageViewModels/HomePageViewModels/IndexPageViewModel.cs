using GoData.Core.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoData.Portal.PageViewModels.HomePageViewModels
{
    public class IndexPageViewModel : BasePageViewModel
    {
        public IndexPageViewModel(int userId, UserLogic userLogic) : base(userId, userLogic)
        {
        }
    }
}
