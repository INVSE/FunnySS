using System;

namespace WebUniqWordsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string WelcomeString =
@"Программа скачает на ваш компьютер указанную веб-страницу и
покажет количество встречаемых уникальных слов на ней.

Введите адрес страницы, например - https://www.simbirsoft.com/

>> ";
            Console.Write(WelcomeString);
            string URL = Console.ReadLine();

            URL_Checker urlcheck = new URL_Checker();
            urlcheck.CheckUrl(URL);

            HTML_Downloader html_Downloader = new HTML_Downloader();
            html_Downloader.SaveHTML(URL);

            Console.WriteLine("Найденные уникальные слова на странице:");

            HTML2Text h2t = new HTML2Text();
            h2t.Counter();

            Console.WriteLine("Программа завершила свою работу. Нажмите любую кнопку чтобы выйти.");
            Console.ReadKey();
        }
    }
}
