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
        
        //Create Test for MatHelper.Max if values are the same

        [Theory]
        [InlineDataAttribute(89,89,89)]
        [InlineDataAttribute(0,0,0)]
        [InlineDataAttribute(2,2,2)]
        [InlineDataAttribute(1,1,1)]

        public void ReturnGivenValue(int value1, int value2, int expectedvalue)
        { 
             var result = _mathHelper.Max(value1,value2);
             Assert.Equal(expectedvalue,result);    
        }

        //Create test to return the larger value

        [Theory]
        [InlineDataAttribute(89,87,89)]
        [InlineDataAttribute(117,125,125)]
        public void ReturnMaxValue(int value1, int value2, int expectedvalue)
        {
             var actualresult = _mathHelper.Max(value1,value2);
             Assert.Equal(expectedvalue,actualresult);

        }

        //create test to test the Max function commutative property

        [Fact]
        public void TestIndependentOrder()
        {
        int x=9;
        int y= 87;

        var actualresult1 = _mathHelper.Max(x,y);
        var actualresult2 = _mathHelper.Max(y,x);

        }

    }
}
