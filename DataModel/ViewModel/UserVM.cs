using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.ViewModel
{
  public  class UserVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter  the input")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter  the input")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter  the input")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Enter  the input")]
        public string cuntery { get; set; }
        [Required(ErrorMessage = "Enter  the input")]
        public string job { get; set; }
        [Required(ErrorMessage = "Enter  the input")]
        public string Password { get; set; }
    }
}
