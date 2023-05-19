using Kattis.CD;
using System.Diagnostics;
using Xunit.Abstractions;

namespace Tests.CD
{
    public class Tests : IClassFixture<CDTestHelpers>
    {
        CDTestHelpers helpers;
        ITestOutputHelper output;
        public Tests(ITestOutputHelper output, CDTestHelpers testHelpers)
        {
            this.output = output;
            helpers = testHelpers;
        }
        [Fact]
        public void DatasetShouldBeginWithTwoPositiveIntegers() 
        { 
            foreach(var file in helpers.TestDataFiles) 
            { 
            
            }            
        }
    }
}