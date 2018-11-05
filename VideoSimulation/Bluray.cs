using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSimulation
{
    class Bluray : IOperate
    {
        
        public string Play()
        {
            return "BluRay is playing";   
        }

        public string Stop()
        {
            return "BluRay stopped playing";
        }
    }
}
