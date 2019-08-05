using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     var time = DateTimeOffset.Now.ToOffset(TimeSpan.FromHours(10));

                 foreach(var timeZone in TimeZoneInfo.GetSystemTimeZones())
                 {
                     if(timeZone.GetUtcOffset(time)
                         == time.Offset)
                     {
                         Console.WriteLine(timeZone);
                     }
                 } */

            /*   var date = "9/10/2019 10:00:00 PM";

               var parseDate = DateTime.ParseExact(date, "M/d/yyyy h:mm:ss tt",
                   CultureInfo.InvariantCulture,
                   DateTimeStyles.AdjustToUniversal); */

            /*   var parseDate = DateTimeOffset.ParseExact(date, "M/d/yyyy h:mm:ss tt",
                   CultureInfo.InvariantCulture,
                   DateTimeStyles.AdjustToUniversal); 

               parseDate = parseDate.ToOffset(TimeSpan.FromHours(10));

               var formattedDate = parseDate.ToString("o");

               Console.WriteLine(formattedDate); */

            /*   Console.WriteLine(parseDate);
               Console.WriteLine(parseDate.Kind); */

        /*    var now = DateTimeOffset.Now;

            Console.WriteLine(now.ToUniversalTime()); */
        }
    }
}
