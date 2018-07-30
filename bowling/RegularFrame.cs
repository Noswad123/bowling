using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    class RegularFrame : IFrame
    {
        public Throw FirstThrow{ get; set; }
        public Throw SecondThrow { get; set; }
        public int total { get; set; }
       
        public RegularFrame(int first, int second)
        {
            FirstThrow.score = first;
            SecondThrow.score = second;
        }
        public bool isSpare()
        {
            if ((this.FirstThrow.score + this.SecondThrow.score) == 10)
            {
                return true;
            }
            return false;
        }
        public int getTotal()
        {
            return this.FirstThrow.score + this.SecondThrow.score;
        }
    }
}
