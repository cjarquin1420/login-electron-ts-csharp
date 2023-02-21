using System;
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
        string username = "";
        string password = "";
    }

}