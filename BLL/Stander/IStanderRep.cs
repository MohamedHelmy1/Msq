using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Stander
{
    public interface IStanderRep
    {
        IEnumerable<StanderViewModel> GetAllStander(int id);
        IEnumerable<StanderQuectionViewModel> GetAllStanderQuection(int id);
        bool AddUserStander(UserStanderViewmodel model); 


    }
}
