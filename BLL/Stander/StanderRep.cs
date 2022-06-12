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
            throw new NotImplementedException();
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
    }
}
