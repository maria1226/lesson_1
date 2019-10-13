using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zdravei");
            Console.WriteLine(6 + 8);
            Console.WriteLine("6" + 8);//konkatenaciq
            Console.WriteLine(6 + 8+"14");//konkatenaciq
            int ocenka=5;//declaraciq i nachalna inicializaciq
            int ocenka2;
            
            ocenka2 = int.Parse(Console.ReadLine());//vavejdane ot klaviaturata
            Console.WriteLine("sumata e ="+(ocenka + ocenka2));
        }
    }
}
