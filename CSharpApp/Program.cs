using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 在debug中查找CSharpApp.exe,用vs2019tools中的ildasm汇编查看器查看该文件的机器代码
// 机器代码中;后面为注释行
// 机器代码的每一行都是表达式不是语句,非常零散不利于阅读

namespace CSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = GetCylinderVolume(10, 100);
            Console.WriteLine(result);
        }
        static double GetCylinderVolume(double r, double h)
        {
            double area = 3.1416 * r * r;
            double volume = area * h;
            return volume;
        }
    }
}
