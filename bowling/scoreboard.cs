using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    class Scoreboard
    {
        List<IFrame> Frames;
        int total;
        public Scoreboard(int[] scores)
        {
            Frames = new List<IFrame>();
            total = 0;
            for (int throwValue = 0; throwValue < scores.Length-2; throwValue++)
            {
                if (throwValue < 18)
                {
                    Frames.Add(new RegularFrame(scores[throwValue], scores[throwValue + 1]));
                    throwValue++;
                } 
                else{
                    Frames.Add(new FinalFrame(scores[throwValue], scores[throwValue + 1], scores[throwValue + 2]));
                }
            }
        }
        public int CalculateScore()
        {
            
            for (int frameIndex = 0; frameIndex <Frames.Count; frameIndex++)
            {
                if(Frames[frameIndex].Total!=0)
                    total+= Frames[frameIndex].Total;
                else
                    total += Frames[frameIndex].GetScore(Frames, frameIndex);
            }
            
            return total;
        }
    }
}
