using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = " Please Enter Name")]
        public String Name { get; set; }

        [Required (ErrorMessage = " Please Enter Password")]
        public String Password { get; set; }
        public bool Sign_status { get; set; }
    }
}
