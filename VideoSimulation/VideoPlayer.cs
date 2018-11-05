using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSimulation
{
    public class VideoPlayer : IOperate
    {
        public int id { get; set; }
        public void Play()
        {
            id = 1;
        }

        public void Stop()
        {
            id = 0;
        }
    }
}
