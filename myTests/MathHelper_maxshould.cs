using System;
using Xunit;
using myLib;

namespace myTests
{
    public class MathHelper_MaxShould
    {
        [Fact]
        public void ReturnGivenValue()
        {
             var  mathHelper = new MathHelper();
             var result = mathHelper.Max(0,0);
             Assert.Equal(0,result);
             //if(result == 0)
             //{
             //    Console.WriteLine("Sucess"); 
            // }
             //else
            // {
             //    Console.WriteLine("Fail");
            // }
        }
    }
}
