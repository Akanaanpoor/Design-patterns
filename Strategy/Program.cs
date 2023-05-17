using Strategy.Business.Sorts;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start!");

            SortContext sortContext = new SortContext(new MergeSort());
            sortContext.Add(new List<string>() { "Aref", "Mosi", "Sori", "Moji" });
            sortContext.Sort();


            Console.ReadKey();
        }
    }
}