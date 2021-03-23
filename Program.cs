using System;

namespace myDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            myDic<int, string> myDict = new myDic<int, string>();

            myDict.Add(123, "Hilal");
            myDict.Add(1234, "Yusuf");
            myDict.Add(1235, "Kenan");
            myDict.Add(1236, "Gülce");

            myDict.List();

        }
    }
}
