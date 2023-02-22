using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _login_bin_c.utils
{
    internal abstract class login : login_bin_c.utils.strategy
    {
        [Required]
        [MinLength(length:10)]
        public string username {get; set;}
        public string password {get; set;}
    }
}