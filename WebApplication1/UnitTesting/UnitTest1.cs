using BusinessLogic;
using System;
using Xunit;

namespace UnitTesting
{
    public class UnitTest1
    {
        [Fact(DisplayName ="AddTwoNumber method Works properly")]
        public void Test1()
        {
            BussinessLogic blc = new BussinessLogic();
            var result = blc.AddTwoNumbers(5, 6);
            Assert.Equal(11, result);
        }

        [Fact(DisplayName ="MultiplyTwoNumbers method works properly")]

        public void Test2()
        {
            BussinessLogic blc = new BussinessLogic();
            var result = blc.MultiplyTwoNumbers(6, 8);
            Assert.Equal(48, result);
        }
    }
}
