using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel.ViewModel;

namespace BLL.Usres
{
   public interface IUser
    {
        UserVM GetById(int id);
        void add(UserVM dpt);
        void Edit(UserVM dpt);
        string login(UserVM dpt);
    }
}
