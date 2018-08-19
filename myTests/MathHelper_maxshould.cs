using System;
using Xunit;
using myLib;

namespace myTests
{
    public class MathHelper_MaxShould
    {
        private readonly MathHelper _mathHelper;

        public MathHelper_MaxShould()
        {
            _mathHelper= new MathHelper();
        }
        
        [Theory]
        [InlineDataAttribute(89,89,89)]
        [InlineDataAttribute(0,0,0)]
        [InlineDataAttribute(2,2,2)]
        [InlineDataAttribute(1,1,1)]

        public void ReturnGivenValue(int value1, int value2, int expectedvalue)
        {
             
             var result = _mathHelper.Max(value1,value2);
             Assert.Equal(expectedvalue,result);
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
