using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area51
{
    public class Agent
    {
        public string? Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public Floor CurrentFloor { get; set; }
    }
}
