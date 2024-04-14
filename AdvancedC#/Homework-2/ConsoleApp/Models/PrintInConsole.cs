namespace ConsoleApp.Models
{
    public class PrintInConsole<T>
    {
        public void Print(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintCollection(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}