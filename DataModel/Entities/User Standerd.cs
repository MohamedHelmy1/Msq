using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batabase.Entities
{
    public class User_Standerd
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int? Fk_Standard { get; set; }
        [ForeignKey("Fk_Standard")]
        public Standard Standard { get; set; }
        public int? Fk_User { get; set; }
        [ForeignKey("Fk_User")]
        public User User { get; set; }
        public int? Fk_Teacher { get; set; }
        [ForeignKey("Fk_Teacher")]
        public User Users { get; set; }
        public string DalilName { get; set; }
        public string pointOfStrong { get; set; }
        public string ChosetoImprove { get; set; }


    }
}
