using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace login_bin_c.utils
{
    public class strategyReturn {
        public strategyReturn() {
            this.commands = new List<string>();
            this.loginDir = string.Empty;
        }
        public List<string> commands { get; set;}
        public string loginDir { get; set; }
    }

    public abstract class strategy
    {
        public strategyReturn _strategyReturn { get; set;}
        public abstract void execute();
    }
}