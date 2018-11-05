using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSimulation
{
   
    public class DVD : IOperate
    {
        public int id { get; set; }

        public void Play()
        {
            id = 2;
            
        }

        public void Stop()
        {
            id = 3;
            
        }
    }
}
