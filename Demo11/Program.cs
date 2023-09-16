using System.Text;
namespace Demo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
           var names= new HashSet<string>() { "An", "Bình" , "Cường" , "Dũng" };
            names.Add("Đạt");
            names.Add("Giang");
            names.Add("Hùng");
            names.Add("Khương");
            names.Add("Hùng"); //Không được thêm vào set

            //Hiển thi set
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}