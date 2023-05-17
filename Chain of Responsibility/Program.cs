

using Chain_of_Responsibility.Business.Services;
using Chain_of_Responsibility.Model;
using System.Globalization;

namespace Chain_of_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!\r\n");

            var user = new User("Aref Kanaanpoor",
                "870101XXXX",
            new RegionInfo("US"),
                new DateTimeOffset(1987, 01, 29, 00, 00, 00, TimeSpan.FromHours(2)));

            var processor = new UserProcess();

            var result = processor.Register(user);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}