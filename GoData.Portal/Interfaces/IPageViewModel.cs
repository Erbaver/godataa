using GoData.Entities.Entities;
using System.Collections.Generic;

namespace GoData.Portal.Interfaces
{
    public interface IPageViewModel
    {
        //Generals
        string PageName { get; set; }

        IEnumerable<Unit> Units { get; }

        //T ActionViewModel { get; set; }
    }
}
