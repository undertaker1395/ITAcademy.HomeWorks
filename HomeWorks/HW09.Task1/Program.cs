using System;

namespace HW09.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Passport passport = new Passport();
            Cosmodrome cosmodrome = new Cosmodrome();
            GenerateTicket generateTicket = new GenerateTicket();
            TimeTable timeTable = new TimeTable();
            Greeting greeting = new Greeting();
            TimeHours time = new TimeHours();
            int gotTicket = 0;
            string actualGreeting = greeting.GreetingH(time.Hours(DateTime.Now.TimeOfDay));
            link1:
            Console.WriteLine("Вас приветствует международный Космодром Луна-1. Введите свои ФИО через пробел.");
            passport.name = Console.ReadLine();



            Console.WriteLine(actualGreeting + passport.name + ", если вы хотите провести онлайн регистрацию, нажмите \"1\" а затем Enter" +
                "\n Если вы хотите посмотреть расписание вылета межпланетарного шаттла Луна-Марс, нажмите \"2\" а затем Enter" +
                "\n Если вы хотите провести регистрацию непосредственно по прибытию на космодром Лйна-1, нажмите \"3\" а затем Enter" +
                "\n Что бы покинуть диалоговое окно, нажмите\"0\" а затем Enter");
            int selection;
            string selectionS = Console.ReadLine();
            bool checkSelection = int.TryParse(selectionS, out selection);
            while (checkSelection == false || selection < 0 || selection > 3)
            {
                Console.WriteLine("ОШИБКА! Попробуйте снова.");
                selectionS = Console.ReadLine();
                checkSelection = int.TryParse(selectionS, out selection);
            }
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Вы решили пройти регистрацию онлайн, для завершения регистрации заполните следующие данные:" +
                        "\nВведите дату вашего рождения в формате ГГГГ.ММ.ДД");
                    passport.birthday = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("\nУкажите ваш пол М/Ж");
                    passport.gender = Console.ReadLine().ToUpper();
                    Console.WriteLine("\nВведите серию и номер паспорта");
                    passport.serialNumber = Console.ReadLine();
                    Console.WriteLine("\nУ вас имеется при себе багаж? Да/Нет");
                    string baggage = Console.ReadLine();
                    if (cosmodrome.CheckIn(passport.name, passport.birthday, passport.gender, baggage))
                    {
                        generateTicket.PrintTicket(passport.name, passport.birthday, passport.gender, baggage);
                        Console.WriteLine("\nПо прибытию на космодром Луна-1, пройдите на стойку регистрации и сдайте багаж если он имеется и проходите в зону досмотра, предьявив ваш билет");
                        gotTicket = 1;
                    }
                    else
                    {
                        Console.WriteLine("К сожалению вы не достигли необходимого возраста для межпланетарных перелётов.");
                        goto link1;
                    }
                    break;
                case 2:
                    Console.WriteLine(timeTable.timetable);
                    goto link1;
                case 3:
                    Console.WriteLine("По прибытию на космодром Луна-1, пройдите на стойку регистрации при себе необходимо иметь паспорт.");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Вы прибыли на космодром Луна - 1.");
            if (gotTicket > 0) Console.WriteLine("Предьявив билет, сдайте багаж на стойке регистрации и проходите в зону досмотра");
            else
            {
                Console.WriteLine("Пройдите на стойку регистрации для прохождения чекин, при себе необходимо иметь паспорт" +
                        "\nУкажите следующие данные" +
                        "\nДата вашего рождения");
                passport.birthday = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\nваш пол М/Ж");
                passport.gender = Console.ReadLine().ToUpper();
                Console.WriteLine("\nсерию и номер паспорта");
                passport.serialNumber = Console.ReadLine();
                Console.WriteLine("\nУ вас имеется при себе багаж? Да/Нет");
                string baggage = Console.ReadLine().ToUpper();
                if (cosmodrome.CheckIn(passport.name, passport.birthday, passport.gender, baggage))
                {
                    generateTicket.PrintTicket(passport.name, passport.birthday, passport.gender, baggage);
                    Console.WriteLine("\nПроходите в зону досмотра, предьявив ваш билет");
                    gotTicket = 1;
                }
                else
                {
                    Console.WriteLine("К сожалению вы не достигли необходимого возраста для межпланетарных перелётов.");
                    goto link1;
                }

            }
            Console.WriteLine("Вы прошли в зону досмотра");
            Console.WriteLine("Имеете ли вы при себе запрещённые к транспортировке предметы? Да/Нет");
            string prohibitedItems = Console.ReadLine().ToUpper();
            if(cosmodrome.SecurityCheck(prohibitedItems)) Console.WriteLine("Проходите на паспортный контроль.");
            else
            {
                Console.WriteLine("К сожалению вы не допущены к перелёту");
                goto link1;
            }
            Console.WriteLine("Вас приветствует паспортный контроль космодрома Луна-1");
            Console.WriteLine("Укажите срок действия вашего паспорта");
            passport.expired = Convert.ToDateTime(Console.ReadLine());
            if(cosmodrome.PassportConrole(passport.serialNumber, passport.expired, gotTicket))
            {
                Console.WriteLine("Поздравляем, вам разрешён доступ на межпланетарный шатл " + generateTicket.shuttle + " Ориентировочное время пути 200 дней, приятного полета!!!");
            }
            else
            {
                Console.WriteLine("К сожалению вам отказано в допуске, срок действия вашего документа меньше 360 дней.");
                goto link1;
            }
        }
    }

    class Greeting
    {
        internal string GreetingH(int t)
        {
            int timeH = t;
            string greeting;
            if (timeH >= 4 && timeH < 12)
            {
                greeting = "Доброе утро! ";
            }
            else
            {
                if (timeH >= 12 && timeH < 17)
                {
                    greeting = "Добрый день! ";
                }
                else
                {
                    if (timeH >= 17 && timeH <= 23)
                    {
                        greeting = "Добрый вечер! ";
                    }
                    else
                    {
                        greeting = "Здравствуйте! ";
                    }
                }
            }
            return greeting;
        }
    }

    class TimeHours
    {
        internal int Hours(TimeSpan dayTime)
        {
            int h = dayTime.Hours;
            return h;
        }
    }
}
