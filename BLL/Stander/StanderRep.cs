using DataModel.Entities;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Stander
{
    public class StanderRep : IStanderRep
    {
        private readonly ApplicationDbContext db;

        public StanderRep(ApplicationDbContext db)
        {
            this.db = db;
        }

        public bool AddUserStander(UserStanderViewmodel model)
        {
            User_Standerd obj = new User_Standerd();
            obj.file = model.file;
            obj.Fk_Standard = model.Fk_Standard;
            obj.Name= model.Name;
            obj.Fk_User= model.Fk_User;
            db.User_Standerd.Add(obj);
            db.SaveChanges();   
           return true;
        }

        public IEnumerable<StanderViewModel> GetAllStander(int id)
        {
            return db.Standard.Where(x => x.Fk_SubCatogery == id).Select(x => new StanderViewModel
            {
                Fk_SubCatogery = x.Fk_SubCatogery,
                Id = x.Id,
                Name = x.Name,
                Number = x.Number

            });
        }

        public IEnumerable<StanderQuectionViewModel> GetAllStanderQuection(int id)
        {
            return db.StanderQueqsion.Where(x => x.Fk_Standard == id).Select(c => new StanderQuectionViewModel
            {
                Id = c.Id,
                Queqsion = c.Queqsion
            });
        }

        public IEnumerable<GetUrlCatagery> GetMyStander(int id)
        {
            var data = db.User_Standerd.Where(x => x.Fk_User == id).Select(z=>z.Fk_Standard);
            List<int?>SubCatogery=new List<int?>();
            foreach (var item in data)
            {
                var Stander = db.Standard.Where(x => x.Id ==item).Select(x =>x.Fk_SubCatogery).Distinct();
                foreach (var item1 in Stander)
                {
                    SubCatogery.Add(item1);
                }
               
            }
            
            List<GetUrlCatagery>catageries=new List<GetUrlCatagery>();
            foreach (var item in SubCatogery.Distinct())
            {
                var data8= db.subCatogery.Where(x => x.id == item).FirstOrDefault();
                GetUrlCatagery catagery=new GetUrlCatagery();
                catagery.CatogeryName = db.Catogery.Where(x => x.Id == data8.Fk_Catogery).Select(z => z.Name).FirstOrDefault();
                catagery.SubCatogeryName=data8.name;
                catagery.id = (int)item;
                catageries.Add(catagery);
            }
           

            return catageries;
        }
    }
}
