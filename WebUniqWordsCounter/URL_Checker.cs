using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUniqWordsCounter
{
    class URL_Checker
    {
        public void CheckUrl(string checkurl)
        {
            string BadURL = 
@"Программа более не может продолжить свое выполнение, 
Пожалуйста, перезапустите программу и введите корректный URL-адрес";
            string pattern = @"^(http|http(s)?://)+([\w-]+\.)+(\[\?%&=]*)?";

                if (Regex.IsMatch(checkurl, pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Valid URL");
                }
                else
                {
                    Console.WriteLine("URL введен неверно!");
                    Console.WriteLine(BadURL);
                    Console.ReadKey();
                    Environment.Exit(0);
            }
        }
    } 
}
