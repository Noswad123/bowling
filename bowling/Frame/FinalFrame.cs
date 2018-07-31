using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    class FinalFrame : IFrame
    {
        public Throw FirstThrow { get; set; }
        public Throw SecondThrow { get; set; }
        public Throw ThirdThrow { get; set; }
     
        public FinalFrame(int first, int second, int third)
        {
            FirstThrow = new Throw(first);
            SecondThrow = new Throw(second);
            ThirdThrow = new Throw(third);
           
            IsSpareOrStrike();
        }
        public int GetScore(List<IFrame> frames, int frameIndex)
        {
            
             return FirstThrow.score + SecondThrow.score + ThirdThrow.score;      
        }

        public void IsSpareOrStrike()
        {
            if (FirstThrow.score == 10)
            {
                FirstThrow.isStrike = true;

                if (SecondThrow.score == 10)
                {
                    SecondThrow.isStrike = true;
                }
                else if(SecondThrow.score +ThirdThrow.score==10)
                {
                    ThirdThrow.isSpare=true;
                }
      
            }
            else if(FirstThrow.score + SecondThrow.score==10)
            {
                SecondThrow.isSpare = true;
            }
            else if(ThirdThrow.score==10)
            {
                ThirdThrow.isStrike = true;
            }
        }    
    }
}
