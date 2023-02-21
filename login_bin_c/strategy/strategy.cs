using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace login_bin_c.utils
{
    public class strategyReturn {
        public strategyReturn() {
            this.username = string.Empty;
            this.password = string.Empty;
        }
        public string username { get; set;}
        public string password { get; set; }
    }

    public abstract class strategy
    {
        public strategyReturn _strategyReturn { get; set;}
        public abstract void execute();
    }
}