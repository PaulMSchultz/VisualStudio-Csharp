using System;
using System.IO;

namespace Prestige.Biz
{
    class Program
    {
        public const int ConstantNumber = 100;
        public static readonly int ReadOnlyNumber = 0;

        static Program()
        {
            ReadOnlyNumber = 5;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(ConstantNumber);
            //Console.WriteLine(ReadOnlyNumber);

            //Agency agency = null;
            //Console.WriteLine(agency?.Name); // checking for null more gracefully using ?

            //FileStream fs1 = new FileStream(@"c:\test\TheAgency.txt", FileMode.Open);
            //FileStream fs2 = new FileStream(@"c:\test\TheAgency.txt", FileMode.Open);
            using (FileStream fs1 = new FileStream(@"c:\test\TheAgency.txt", FileMode.Open))
            {
                // Do something
            }
            using (FileStream fs2 = new FileStream(@"c:\test\TheAgency.txt", FileMode.Open))
            {
                // Do something
            }


        }
    }
}
