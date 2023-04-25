using Kattis.CD;
using System.Diagnostics;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //1,000,000,000 
            //1,000,000,0;
            int jacksCds = 9000;
            int jillsCds = 10000;
            CD_GenerateTestData testdata = new CD_GenerateTestData(new CD_TestData<int>(jillsCds, jacksCds));
            //string[] input = File.ReadAllLines("./smallRandomTestData.txt");
        }
    }
}