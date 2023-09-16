using System.Text;
namespace Demo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(4);
            list.AddLast(6);
            list.AddLast(8);
            Console.WriteLine("Số phần tử của danh sách liên kết: "+ list.Count);
            
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            list.RemoveFirst();
            Console.WriteLine("Số phần tử của danh sách liên kết: " + list.Count);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}