using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System;
using System.Collections;
using System.Globalization;

namespace _25._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "2031-04-22 19:28";

            DateTime dt =DateTime.ParseExact(s, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine($"ParseExact: { dt}");
            string s1 = "03/11/2028 10:12:06";
            DateTime dt1 = DateTime.Parse(s1, CultureInfo.GetCultureInfo("en-US"));
            Console.WriteLine($"Parse:{dt1}");

            string s2 = "02/10/2020 09:52:36";

            DateTime dt2;
            if (DateTime.TryParse(s2, out dt2))
            {
                Console.WriteLine($"{dt2}");
            }
            else
                Console.WriteLine("Ошибка парсинга");


        }
    }
      
}
