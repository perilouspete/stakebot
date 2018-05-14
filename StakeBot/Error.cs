using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeBot
{

    

    public class Error
    {
        public string name { get; set; }
        public string message { get; set; }
        public bool error { get; set; }
        public int status { get; set; }
        public object field { get; set; }
        public object data { get; set; }
    }

}
