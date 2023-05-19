using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tests.CD
{
    public class CD_GenerateTestData
    {
        Random random = new Random();
        CD_TestData<int> testData;
        string initialRow;
        string endOfFile = "0 0";
        string filename = "smallRandomTestData.txt";
        public CD_GenerateTestData(CD_TestData<int> _testData)
        {
            testData = _testData;
            initialRow = $"{testData.JacksCds} {testData.JillsCds}";
            GenerateRandomTestData();
            SaveToFile(filename);
        }
        public void GenerateRandomTestData()
        {
            for (int i = 0; i < testData.JacksCds; i++)
            {
                testData.AddJack(random.Next(1, 1000000000));
            }
            for (int i = 0; i < testData.JillsCds; i++)
                testData.AddJill(random.Next(1, 1000000000));
            testData.SortLists();

        }
        public void SaveToFile(string filename)
        {
            if (File.Exists(filename))
                File.Delete(filename);
            File.AppendAllText(filename, initialRow + "\n");
            //File.AppendAllLines(filename, testData.jacksCollection);
            //File.AppendAllLines(filename, testData.jillsCollection);
            List<string> lines = new List<string>();
            lines = testData.jacksCollection.ConvertAll(x => x.ToString());
            File.AppendAllLines(filename, lines);
            lines.Clear();

            lines = testData.jillsCollection.ConvertAll(x => x.ToString());
            File.AppendAllLines(filename, lines);
            lines.Clear();
            //foreach (var line in testData.jacksCollection)
            //{
            //    File.AppendAllText(filename, line.ToString());
            //}
            //foreach (var line in testData.jillsCollection)
            //{
            //    File.AppendAllText(filename, line.ToString());
            //}
            File.AppendAllText(filename, endOfFile);
        }
    }
    public class CD_TestData<T>
    {
        public List<T> jillsCollection;
        public List<T> jacksCollection;
        public int JacksCds { get; init; }
        public int JillsCds { get; init; }
        public CD_TestData(int jillsCds, int jacksCds)
        {
            jillsCollection = new List<T>();
            jacksCollection = new List<T>();
            JacksCds = jacksCds;
            JillsCds = jillsCds;
        }
        public void AddJack(T value)
        {
            jacksCollection.Add(value);
        }
        public void AddJill(T value)
        {
            jillsCollection.Add(value);
        }
        public void Add(Lists addToList, T value)
        {

            if (Lists.Jack == addToList)
            {
                if (!jacksCollection.Exists(x => x.Equals(value)))
                    jacksCollection.Add(value);
            }
            else
            {
                if (!jillsCollection.Exists(x => x.Equals(value)))
                    jillsCollection.Add(value);
            }
        }
        public void SortLists()
        {
            jacksCollection.Sort();
            jillsCollection.Sort();
        }
        bool Equals(int value, int other)
        {
            if (value == other)
                return true;
            return false;
        }
        bool Equals(string value, string other)
        {
            if (value == other) return true;
            return false;
        }
        bool Compare<U>(U value1, U value2)
        {
            if (value1 == null || value2 == null)
                return false;

            if (IsNumeric(value1))
                return Equals(Convert.ToInt32(value1), Convert.ToInt32(value2));
            else if (IsString(value1))
                return Equals(value1.ToString(), value2.ToString());

            return false;
        }
        bool IsNumeric(object o)
        {
            switch (Type.GetTypeCode(o.GetType()))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }
        bool IsString(object o)
        {
            if (Type.GetTypeCode(o.GetType()) == TypeCode.String)
                return true;
            else
                return false;
        }
    }

    public enum Lists
    {
        Jill,
        Jack
    }
}
