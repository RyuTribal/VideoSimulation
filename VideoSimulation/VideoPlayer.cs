using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSimulation
{
    public class VideoPlayer : IOperate
    {

        public string Play()
        {
            return "VHS is playing";
        }

        public string Stop()
        {
            return "VHS has stopped";
        }
    }
}
