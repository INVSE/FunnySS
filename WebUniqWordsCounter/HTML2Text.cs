using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WebUniqWordsCounter
{
    class HTML2Text
    {
        public string Texturization()
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            try
            {
                HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(Directory.GetCurrentDirectory() + @"\" + "web.html");
                return document.DocumentNode.InnerText;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.ToString());
                return null;
            }
        }

        public void Counter()
        {
            string txt = Texturization();
            var result = Calc(txt);
            result.Remove("");
            foreach (var pair in result)
            Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
        }

        static Dictionary<string, int> Calc(string words)
        {
            var res = new Dictionary<string, int>();

            foreach (var word in words.Split(' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t').Skip(1))
            {
                var count = 0;
                res.TryGetValue(word, out count);
                res[word] = count + 1;
            }

            return res;
        }
    }
}
