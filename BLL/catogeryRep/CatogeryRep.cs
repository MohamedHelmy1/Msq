using DataModel.Entities;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.catogeryRep
{
    public class CatogeryRep : ICatogeryRep
    {
        private readonly ApplicationDbContext db;

        public CatogeryRep(ApplicationDbContext db)
        {
            this.db = db;
        }

        public string CatageryName(int id)
        {
            var catogeryName = db.Catogery.Where(x => x.Id == id).FirstOrDefault().Name;
            return catogeryName;
        }

        public IEnumerable<catogeryViewModel> GetAllCatogery()
        {
            return db.Catogery.Select(c => new catogeryViewModel
            {
                Id= c.Id,
                Name= c.Name,
                Note= c.Note
            });
            
        }

        public IEnumerable<SubCatogeryViewModel> GetAllSubCatogery(int id)
        {
            return db.subCatogery.Where(x => x.Fk_Catogery == id).Select(c => new SubCatogeryViewModel
            {
                id = c.id,
                name = c.name
            });
        }

        public GetUrlCatagery getUrlCatagery(int id)
        {
            GetUrlCatagery obj = new GetUrlCatagery();
            var data = db.subCatogery.Where(x => x.id == id).FirstOrDefault();
            var catogeryName = db.Catogery.Where(x => x.Id == data.Fk_Catogery).FirstOrDefault().Name;
            obj.SubCatogeryName = data.name;
            obj.CatogeryName = catogeryName;
            return obj;


        }
    }
}
