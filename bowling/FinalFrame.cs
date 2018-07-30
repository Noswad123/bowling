using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    class FinalFrame : IFrame
    {
        public int FirstThrow { get; set; }
        public int SecondThrow { get; set; }
        public int ThirdThrow { get; set; }
    }
}
