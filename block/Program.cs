using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace block
{
    class Program
    {
        static void Main(string[] args)
        {
            // block语句,编译器会看作一条语句
            {
                //hello: Console.WriteLine("Hello World!");       // 标签语句labeled-statement
                //goto hello;     // 形成死循环,占用大量cpu
            }
            // switch语句
            int score = 0;
            switch (score/10)       // switch表达式,决定case值数据格式,表达式数据格式不能是浮点类型
            {
                case 10:        // case值是常量,不能是变量
                    {
                        if (score <= 100 && score >= 0)
                        {
                            goto case 9;
                        }
                        else
                            goto default;
                    }
                case 9:
                case 8:
                    Console.WriteLine("A");
                    break;
                case 7:
                case 6:
                    Console.WriteLine("B");
                    break;
                case 5:
                case 4:
                    Console.WriteLine("C");
                    break;
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
            // 枚举类型合并switch用法
            Level myLevel = Level.High;
            switch (myLevel)
            {
                case Level.High:
                    Console.WriteLine("High level");
                    break;
                case Level.Mid:
                    Console.WriteLine("Mid level");
                    break;
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;
                default:
                    break;
            }
            // 调用包含try语句检测的方法
            Caculator cac = new Caculator();
            int c = cac.Add(null, "222");      // 当输入值不合理时会执行指定代码
            // 使用throw抛出的异常
            int r;
            try
            {
                r = cac.Add("999999999999999999", "100");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            Console.WriteLine(c);
        }
    }
    // enum类型
    enum Level
    {
        High,
        Mid,
        Low
    }
    // try语句,用于检测错误并在检测出错误后执行特定语句,令程序更强壮
    class Caculator
    {
        public int Add(string arg1, string arg2)
        {
            int a = 0;
            int b = 0;
            bool error = false;
            try
            {
                a = int.Parse(arg1);
                b = int.Parse(arg2);
            }
            /* 通用类型catch子句
            catch
            {
                Console.WriteLine("Your argument(s) have error!");
            }
            */

            // 捕捉特定类型catch.比如当string类型值转换为int类型时,存在三种类型异常Exception,ArgumentNullException/FormatException/OverflowException
            // 编程时具体异常需要参照C#文档
            catch (ArgumentNullException ane)       // ane是可选标识符identifier,是类型ArgumentNullException的实例化变量
            {
                /* ArgumentNullException的实例才有Message方法
                 * 调用ane方法Message,打印ArgumentNullException系统信息
                ArgumentNullException ar = new ArgumentNullException();
                Console.WriteLine(ar.Message);
                */
                Console.WriteLine(ane.Message);
                error = true;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                error = true;
            }
            catch (OverflowException oe)
            {
                //Console.WriteLine(oe.Message);
                //error = true;
                throw oe;       // 抛出异常,由调用Add方法的语句接手处理,throw编写方式灵魂,可以有变量oe,也可直接写throw,效果一样
            }
            finally     // finally子句,可以实现两个目的:执行因异常跳过的逻辑(比如无论程序是否异常,都会释放数据库链接),日志记录(日志记录可以看出值是正常执行得出,还是程异常或数据溢出造成)
            {
                if (error)
                {
                    Console.WriteLine("Excution has error!");
                }
                else
                {
                    Console.WriteLine("Done!");
                }
            }
            int result = a + b;
            return result;
        }
    }
}
