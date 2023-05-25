using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //소멸자 연습
            Product product1 = new Product("과자", 1000);
            Product product2 = new Product("용과", 7000);
            Product product3 = new Product("로제떡볶이", 8000);
            Product product4 = new Product("탕후루", 3000);
            Console.WriteLine("안녕하세용");
            Console.WriteLine("안녕하세용");
            Console.WriteLine("안녕하세용");
            Console.WriteLine("안녕하세용");
            Console.WriteLine("안녕하세용");
            Console.WriteLine("안녕하세용");
            Console.WriteLine("안녕하세용");
            Console.WriteLine("안녕하세용");

            //속성 property 실습
            Box box = new Box(10, 10);
            box.Width = 100;
            try
            {
                box.Height = -190;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
