using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KimiaRazi.Helpers
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public static class PersianNumeralHelper
    {
        public static string ConvertNumerals(this string input)
        {
            if (new string[] { "fa" }.Contains(Thread.CurrentThread.CurrentUICulture.Name))
            {
                return input.Replace('0', '۰')
                    .Replace('1', '۱')
                    .Replace('2', '۲')
                    .Replace('3', '۳')
                    .Replace('4', '۴')
                    .Replace('5', '۵')
                    .Replace('6', '۶')
                    .Replace('7', '۷')
                    .Replace('8', '۸')
                    .Replace('9', '۹');
            }
            else return input;
        }
    }
}
