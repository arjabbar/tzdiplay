using System;
using ServiceStack;
using ServiceStack.Text;

namespace DisplaySystemTimeZones
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeZoneInfo.GetSystemTimeZones().ToJson().Print();
        }
    }
}
