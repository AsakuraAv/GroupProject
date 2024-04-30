using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GroupProject
{
    public enum EnumZodiacs
    {
        None = 0,
        Козерог,
        Водолей,
        Рыбы,
        Овен,
        Телец,
        Близнецы,
        Рак,
        Лев,
        Дева,
        Весы,
        Скорпион,
        Стрелец

    }

    public class MonthAndDay
    {
        public int Month { get; set; }
        public int Day { get; set; }

        public MonthAndDay()
        {
                
        }

        public MonthAndDay(int day, int month)
        {
            this.Month = Month;
            this.Day = day;

        }

    }


        public static class ZodiacIdentifi
    {
        

        // у класса один статический метод
        public static void ZodiacIdentifier ()
        {
            Console.WriteLine("\n\nПО Гостева Никиты по определению Знака Зодиака");

            MonthAndDay dateOfBirth = new MonthAndDay();

            //Принимаем ввод данных от пользователя
            try
            {

                Console.WriteLine("\n\nДля определения Вашего знака зодиака");

                Console.WriteLine("Введите номер месяца вашего рождения");
                dateOfBirth.Month = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите дату месяца вашего рождения");
                dateOfBirth.Day = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Вы ввели недопустимое зачение");
            }

            // Проверяем лежат ли введеные данные в области допустимых значений
            if ( (dateOfBirth.Month > 0 && dateOfBirth.Month < 13) 
                && (dateOfBirth.Day > 0 && dateOfBirth.Day < 32))
            {
                Console.WriteLine("\n\nПриступаем к анализу через 3 секунды");

                for (int i = 3; i >= 1; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000); // Задержка на 1 секунду
                }
            }
            else { Console.WriteLine("Введены недопустимые данные, попробуйте снова"); }

            //создаем переменную типа EnumZodiacs куда запишем результат определения
            EnumZodiacs yourZodiac = EnumZodiacs.None;

            //Определяем знак зодиака по месяцу и дате месяца
            switch(dateOfBirth.Month)
            {
                case 1:
                    {
                        if (dateOfBirth.Day <= 20) { yourZodiac = EnumZodiacs.Козерог; }
                        else { yourZodiac = EnumZodiacs.Водолей; }
                    }
                    break;

                case 2:
                    {
                        if (dateOfBirth.Day <= 20) { yourZodiac = EnumZodiacs.Водолей; }
                        else { yourZodiac = EnumZodiacs.Рыбы; }
                    }
                    break;

                case 3:
                    {
                        if (dateOfBirth.Day <= 20) { yourZodiac = EnumZodiacs.Рыбы; }
                        else { yourZodiac = EnumZodiacs.Овен; }
                    }
                    break;

                case 4:
                    {
                        if (dateOfBirth.Day <= 20) { yourZodiac = EnumZodiacs.Овен; }
                        else { yourZodiac = EnumZodiacs.Телец; }
                    }
                    break;

                case 5:
                    {
                        if (dateOfBirth.Day <= 20) { yourZodiac = EnumZodiacs.Телец; }
                        else { yourZodiac = EnumZodiacs.Близнецы; }
                    }
                    break;

                case 6:
                    {
                        if (dateOfBirth.Day <= 21) { yourZodiac = EnumZodiacs.Близнецы; }
                        else { yourZodiac = EnumZodiacs.Рак; }
                    }
                    break;

                case 7:
                    {
                        if (dateOfBirth.Day <= 22) { yourZodiac = EnumZodiacs.Рак; }
                        else { yourZodiac = EnumZodiacs.Лев; }
                    }
                    break;

                case 8:
                    {
                        if (dateOfBirth.Day <= 23) { yourZodiac = EnumZodiacs.Лев; }
                        else { yourZodiac = EnumZodiacs.Дева; }
                    }
                    break;

                case 9:
                    {
                        if (dateOfBirth.Day <= 23) { yourZodiac = EnumZodiacs.Дева; }
                        else { yourZodiac = EnumZodiacs.Весы; }
                    }
                    break;

                case 10:
                    {
                        if (dateOfBirth.Day <= 23) { yourZodiac = EnumZodiacs.Весы; }
                        else { yourZodiac = EnumZodiacs.Скорпион; }
                    }
                    break;

                case 11:
                    {
                        if (dateOfBirth.Day <= 22) { yourZodiac = EnumZodiacs.Скорпион; }
                        else { yourZodiac = EnumZodiacs.Стрелец; }
                    }
                    break;

                case 12:
                    {
                        if (dateOfBirth.Day <= 21) { yourZodiac = EnumZodiacs.Стрелец; }
                        else { yourZodiac = EnumZodiacs.Козерог; }
                    }
                    break;

            }

            //выводим на экран результат
            Console.WriteLine($"Ваш знак зодиака: {yourZodiac}");
        }
    }


}
