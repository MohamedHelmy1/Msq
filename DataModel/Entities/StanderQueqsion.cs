using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entities
{
    public class StanderQueqsion
    {
        public int Id { get; set; }
        public string Queqsion { get; set; }
        public int? Fk_Standard { get; set; }
        [ForeignKey("Fk_Standard")]
        public Standard Standard { get; set; }
    }
}
