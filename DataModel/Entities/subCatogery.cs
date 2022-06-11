using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batabase.Entities
{
    public class subCatogery
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? Fk_Catogery { get; set; }
        [ForeignKey("Fk_Catogery")]
        public Catogery Catogery { get; set; }  

    }
}
