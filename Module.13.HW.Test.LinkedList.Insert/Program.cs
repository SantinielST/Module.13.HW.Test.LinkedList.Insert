using System.Diagnostics;

namespace Module._13.HW.Test.LinkedList.Insert
{
    internal class Program
    {
        // Объявим связанный список
        private static LinkedList<string> UsersNames = new LinkedList<string>();

        static void Main(string[] args)
        {
            // Добавляем в с писок имена
            UsersNames.AddFirst("Александр");
            var igor = UsersNames.AddFirst("Игорь");
            UsersNames.AddFirst("Виктор");

            var stopWatch = Stopwatch.StartNew(); // Запускаем таймер

            UsersNames.AddAfter(igor, "Павел"); // Вставляем новое имя

            Console.WriteLine($"Вставка в связанный список: {stopWatch.Elapsed.TotalMilliseconds}  мс"); // Выводим результат
        }
    }
}

