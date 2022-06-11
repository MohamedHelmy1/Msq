using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batabase.Entities
{
    public class Standard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Fk_SubCatogery { get; set; }
        [ForeignKey("Fk_SubCatogery")]
        public subCatogery subCatogery { get; set; }
    }
}
