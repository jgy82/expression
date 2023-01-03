using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 语句固定,但程序根据输入情况会呈现不同的控制流
// using指令不是语句,用于在程序首引入名称空间
// 只有在方法内以分号;结尾的才是语句,否则不是语句

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                double score = double.Parse(input);
                if (score>60)
                {
                    Console.WriteLine("Pass!");
                }
                else
                {
                    Console.WriteLine("Failed!");
                }
            }
            catch 
            {

                Console.WriteLine("Not a number!");
            }
        }
    }
}
