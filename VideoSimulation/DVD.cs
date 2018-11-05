using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSimulation
{
   
    public class DVD : IOperate
    {
        

        public string Play()
        {
            return "DVD is playing";
            
        }

        public string Stop()
        {
            return "DVD has stopped smoking";
            
        }
    }
}
