using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _login_bin_c.utils
{
    public class login : login_bin_c.utils.strategy
    {
        public string username { get; set; }

        public string password { get; set; }

        public login()
        {
            this.strategyReturn = new strategyReturn()
        }

        public override execute()
        {

        }
    }
}
