using System;

namespace myLib
{
    public class MathHelper
    {

        //This is the class that was built to be tested. 
        //This class is tested in MathHelper_MaxShould
        
        public int Max(int x,int y)

        {
            if (x==y)
            {
            return x;
            }

            if (x>y)
            {
                return x;
            }

            if (x<y)
            {
                return y;
            }
            throw new NotImplementedException("Write Test");
        }
    }
}
