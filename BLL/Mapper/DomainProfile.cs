using AutoMapper;
using DataModel.Entities;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<User, UserVM>();
            CreateMap<UserVM, User>();
            
          





        }
    }
}
