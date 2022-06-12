using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.catogeryRep
{
    public interface ICatogeryRep
    {
        IEnumerable<catogeryViewModel> GetAllCatogery();
        IEnumerable<SubCatogeryViewModel> GetAllSubCatogery(int id);
        string CatageryName(int id);

        GetUrlCatagery getUrlCatagery(int id);

    }
}
