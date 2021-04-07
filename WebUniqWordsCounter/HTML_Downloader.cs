using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebUniqWordsCounter
{
    public class HTML_Downloader
    {
        public void SaveHTML(string Adress)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string directory = Directory.GetCurrentDirectory();
                    string path = directory + @"\" + "web.html";
                    Console.WriteLine("Сохранение: " + Adress.ToString());
                    string html = client.DownloadString(Adress.ToString());
                    File.WriteAllText(path, html);
                    Console.WriteLine("Файл загружен и готов к анализу");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.ToString());
            }
        }
    }
}
