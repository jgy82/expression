using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Action myAction = new Action(Console.WriteLine);        // 用委托实现对Console.WriteLine方法提取
            System.Windows.Forms.Form myForm = new Form();      // 本例用.操作符调用并返回名称空间

        }
    }
}
