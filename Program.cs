using System;

namespace Git_kr
{
    static class Programm
    {
        public static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            int answer;
            Console.WriteLine("Добрый день," + Environment.UserName + "сегодня " + today.ToString("D"));
            Console.WriteLine("Сколько будет 2 умножить на 18");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer != 36) Console.WriteLine("Вы не правы!");
            else
            {
                Console.WriteLine("Вы молодчина!");
            }
        }
    }
}