using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FirstASPAppJuly2018.Models
{
    public class UserInfo
    {
        [Required] // attributes 
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string FirstName { set; get;  }

        [Required]
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string LastName { set; get; }
        public UserInfo()
        {
            FirstName = "";
            LastName = "";
        }
        public UserInfo(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }
    }
}