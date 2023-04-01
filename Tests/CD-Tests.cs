using Kattis.CD;
using System.Diagnostics;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Random random = new Random();
            int records = 1000000;
            //var range1 = Enumerable.Range(1, records);
            //List<string> input = new List<string>();
            //input.Add($"{records} {records}");
            //int value = 0;
            //for(int i = 0; i < records;i++)
            //{
            //    value = random.Next();

            //    input.Add(value.ToString());
            //if (input.Count > 10000000)
            //{
            //    File.AppendAllLines("BillionTestdata.txt", input);
            //    input.Clear();
            //    Debug.WriteLine($"Number is: {number.ToString()}");

            //}
            //}
            //input.Sort();
            //input.Insert(0, $"{records} {records}");
            //File.AppendAllLines("./randomTestData.txt", input);
            //input.Clear();
            //for (int i = 0; i < records; i++)
            //{
            //    value = random.Next();

            //    input.Add(value.ToString());
            //if (input.Count > 10000000)
            //{
            //    File.AppendAllLines("BillionTestdata.txt", input);
            //    input.Clear();
            //    Debug.WriteLine($"Number is: {number.ToString()}");

            //}
            //}
            //input.Sort();
            //input.Add("0 0");
            //File.AppendAllLines("./randomTestData.txt", input);
            //foreach (var number in range1)
            //{
            //input.Add(number.ToString());
            //}
            //input.Add("1");
            //input.Add("2");
            //input.Add("3");
            //input.Add("1");
            //input.Add("2");
            //input.Add("4");
            //input.Add("0 0");
            string[] input = File.ReadAllLines("./randomTestData.txt");
            //File.AppendAllLines("./randomTestData.txt", input);
            var cds = new Kattis.CD.Cds();
            foreach (var item in input)
            {
                cds.Execute(item);

            }
        }
    }
}