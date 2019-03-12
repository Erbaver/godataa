using GoData.Core.Logic;
using GoData.Portal.Helpers;
using GoData.Portal.PageViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoData.Portal.Controllers
{
    public class BaseController : Controller
    {
       
        public UserLogic _userLogic;
        public UserHelper _userHelper;
        public OrganizationLogic _organizationLogic;
        public BasePageViewModel<DefaultPageViewModel> _viewModel;
        public int userId;

        public BaseController()
        {
           
        }

      

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            userId = Int32.Parse(Request.Headers["User"].ToString());
            _viewModel = new BasePageViewModel<DefaultPageViewModel>(userId, _userLogic);
        }
    }
}
