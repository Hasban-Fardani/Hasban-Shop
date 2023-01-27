using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasban_Shop
{
    internal class Payload
    {
        public string Message { get; set; }
        public bool Status { get; set; }
        public string Token { get; set; }

        public dynamic Data { get; set; }
    }
    
}
