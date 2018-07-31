using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bowling.MsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcScoreReturn0WhenAllFrames0()
        {
            int[] input = new int[] { 1, 4, 4, 5, 6, 4, 5, 5, 10, 0, 0, 1, 7, 3, 6, 4, 10, 0, 2, 8, 6 };
          
            int expectScore = 133;
        
            
        }
    }
}
