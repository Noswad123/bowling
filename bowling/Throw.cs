using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    class Throw
    {
        public bool isStrike { get; set; }
        public int score;

        public Throw(int score)
        {
            this.score = score;
            isStrike = (score == 10);
            
        }
    }
}
