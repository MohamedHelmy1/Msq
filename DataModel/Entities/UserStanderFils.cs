using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batabase.Entities
{
    public class UserStanderFils
    {
        public int Id { get; set; }
        public int Ids { get; set; }

        public string Name { get; set; }
        public int? Fk_UserStander { get; set; }
        [ForeignKey("Fk_UserStander")]
        public User_Standerd User_Standerd { get; set; }
    }
}
