using System;
using Xunit;

namespace SampleLibrary.Tests.Unit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           var testObject = new SampleLibrary.Class1();
           testObject.SampleMethod();
        }
    }
}
