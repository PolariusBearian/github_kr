using System;

namespace Git_kr
{
    static class Programm
    {
        public static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Добрый день," + Environment.UserName + "сегодня " + today.ToString("D"));
        }
    }
}