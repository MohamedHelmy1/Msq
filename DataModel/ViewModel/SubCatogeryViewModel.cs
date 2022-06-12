using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
    public class SubCatogeryViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? Fk_Catogery { get; set; }
    }
}
