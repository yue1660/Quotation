using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quotation
{
    public static class Common
    {
        public static void ConsoleLog(string str)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "：" + str);
        }

        public static string GetGUID()
        {
            return Guid.NewGuid().ToString();
        } 



    }
}
