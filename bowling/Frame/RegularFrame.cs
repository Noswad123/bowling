using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    class RegularFrame : IFrame
    {
        public Throw FirstThrow { get; set; }
        public Throw SecondThrow { get; set; }
       
        public RegularFrame(int first, int second)
        {
            FirstThrow= new Throw(first);
            SecondThrow = new Throw(second);
            IsSpareOrStrike();
        }

        public void IsSpareOrStrike()
        {
            if ((FirstThrow.score + SecondThrow.score) == 10 )
            {
                if (FirstThrow.score == 10) {
                    FirstThrow.isStrike = true;
                }
                else
                {
                    SecondThrow.isSpare = true;
                }
            }
        }
        
        public int GetScore(List<IFrame> frames, int frameIndex)
        {
            if (FirstThrow.isStrike)
                return CalcStrike(frames, frameIndex);              
            else if (SecondThrow.isSpare)
                return CalcSpare(frames, frameIndex); 
            else         
               return FirstThrow.score + SecondThrow.score;
        }

        public int CalcSpare(List<IFrame> frames, int frameIndex)
        {
            return FirstThrow.score + SecondThrow.score + frames[frameIndex + 1].FirstThrow.score;
        }

        public int CalcStrike(List<IFrame> frames, int frameIndex)
        {
            return FirstThrow.score + NextTwoThrows(frames, frameIndex+1);
        }

        public int NextTwoThrows(List<IFrame> frames, int nextFrameIndex)
        {
            if (frames[nextFrameIndex].FirstThrow.isStrike && nextFrameIndex < 9)
                return frames[nextFrameIndex].FirstThrow.score + frames[nextFrameIndex + 1].FirstThrow.score;

            if (frames[nextFrameIndex].SecondThrow.isSpare)
                return frames[nextFrameIndex].FirstThrow.score + frames[nextFrameIndex].SecondThrow.score + frames[nextFrameIndex + 1].FirstThrow.score;

            return frames[nextFrameIndex].FirstThrow.score + frames[nextFrameIndex].SecondThrow.score;
        }
    }
}
