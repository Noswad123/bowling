using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    class scoreboard
    {
        List<IFrame> Score= new List<IFrame>(10);
        public int CalculateScore()
        {
           
                //start at 0-17
                foreach (IFrame frame in Score)
                {
                    //check for strike
                    
                
                            i++;
                            wasStrike = true;
                        }
                        else
                        {
                            if (wasSpare)
                            {
                                scoreArray[placeholder - 1] += input[i];
                            }

                            scoreArray[placeholder] += input[i];
                            wasStrike = false;
                        }

                    }
                    else
                    {

                        if (isSpare(input[i], input[i - 1]))
                        {
                            wasSpare = true;
                            if (wasStrike)
                            {

                            }
                        }
                        else
                        {
                            if (wasStrike)
                            {

                            }
                            scoreArray[placeholder] += input[i];
                            wasSpare = false;
                        }
                    }

                }

                //last from (3 throws)
                for (var j = 18; j < 22; j++)
                {
                    if (wasStrike)
                    {


                        if (input[i] == 10)
                        {
                            i++;
                            wasStrike = true;
                        }
                        else
                        {
                            scoreArray[placeholder] += input[i];
                            wasStrike = false;
                        }
                    }
                }
                int sum = 0;
                .forEach(frame => {
                    sum += frame;
                })
                return sum;
            }
            function isFirstThrow(number)
            {
                if (number % 2 == 0 || number == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            function isSpare(current, previous)
            {
                if (current + previous == 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return 0;
        }
    }
}
