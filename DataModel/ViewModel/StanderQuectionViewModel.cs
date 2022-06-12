using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
    public class StanderQuectionViewModel
    {
        public int Id { get; set; }
        public string Queqsion { get; set; }
        public int? Fk_Standard { get; set; }
    }
}
