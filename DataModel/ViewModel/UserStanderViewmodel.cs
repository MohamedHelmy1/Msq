using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
    public class UserStanderViewmodel
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public string file { get; set; }
        public IFormFile files { get; set; }
        public int? Fk_Standard { get; set; }
        
        public int? Fk_User { get; set; }
        
        public int? Fk_Teacher { get; set; }
        public string DalilName { get; set; }
        public string pointOfStrong { get; set; }
        public string ChosetoImprove { get; set; }
        public List<UserStanderViewmodel> Userstander { get; set; }
    }
    public class user
    {
         public string files { get; set; }
        public IFormFile filess { get; set; }
        public string Names{ get; set; }


    }
}
