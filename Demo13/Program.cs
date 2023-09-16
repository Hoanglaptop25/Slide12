namespace Demo13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo List");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
                
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);

            Console.WriteLine(list.Contains(4));
            Console.WriteLine(list.Contains(10));
            Console.WriteLine(list[3]);
            Console.ReadKey();
        }
    }
}