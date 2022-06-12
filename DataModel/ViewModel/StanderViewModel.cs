using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
    public class StanderViewModel
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public string Name { get; set; }
        public int? Fk_SubCatogery { get; set; }
    }
}
