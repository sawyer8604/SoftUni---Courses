using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*За лятната ваканция в списъка със задължителна литература на 
             * Жоро има определен брой книги. Понеже Жоро предпочита да 
             * играе с приятели навън, вашата задача е да му помогнете 
             * да изчисли колко часа на ден трябва да отделя, 
             * за да прочете необходимата литература. */

            //1.Брой страници в текущата книга – цяло число в интервала[1…1000]
            //2.Страници, които прочита за 1 час – цяло число в интервала[1…1000]
            //3.Броят на дните, за които трябва да прочете книгата – цяло число в интервала[1…1000]

            //Да се отпечата на конзолата броят часове,
            //които Жоро трябва да отделя за четене всеки ден.

            int pagesOfBook = int.Parse(Console.ReadLine());
            int pagesReadForHour = int.Parse(Console.ReadLine());
            int daysForReading = int.Parse(Console.ReadLine());

            int hoursForReading = pagesOfBook / pagesReadForHour;
            int neededDays = hoursForReading / daysForReading;
            Console.WriteLine(neededDays);


        }
    }
}
