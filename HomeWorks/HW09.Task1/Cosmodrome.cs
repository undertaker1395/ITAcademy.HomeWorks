using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task1
{
    class Cosmodrome
    {
        Passport passport = new Passport();
        internal string shuttle = string.Empty;
        internal bool CheckIn(string name, DateTime birthday, string gender, string baggage)
        {
            const int legalAge = 21;
            DateTime dateNow = DateTime.Today;
            string userName = name;
            string userGender = gender;
            DateTime userBirthday = birthday;
            int age = dateNow.Year - birthday.Year;
            string userBaggage = baggage;
            if (age >= legalAge)
            {
                return true;
            }
            else return false;
        }

        internal bool SecurityCheck(string prohibitedItems)
        {
            if (prohibitedItems == "НЕТ")
            {
                return true;
            }
            else return false;
        }

        internal bool PassportConrole(string serialNumber, DateTime expired, int gotTicket)
        {
            DateTime dateNow = DateTime.Today;
            if (serialNumber != string.Empty && gotTicket == 1)
            {
                if ((dateNow - expired).TotalDays >= 365)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return false;
           
        }

    }

    class GenerateTicket
    {
        internal string shuttle = string.Empty;
        string Ticket(string name, DateTime birthday, string gender, string baggage)
        {
            Random rnd = new Random();
            shuttle = "MM-" + Convert.ToString(rnd.Next(1000, 9999));
            string ticket = "**************Билет Луна-Марс**************" +
                "\nПассажир: " + name +
                "\nПол: " + gender +
                "\nДата рождения: " + birthday +
                "\nРейс: " + shuttle + 
                "\nБагаж: " + baggage +
                "\n******************************************";
            return ticket;
        }
        internal void PrintTicket(string name, DateTime birthday, string gender, string baggage)
        {
            GenerateTicket generate = new GenerateTicket();
            Console.WriteLine(generate.Ticket(name, birthday, gender, baggage));
        }
    }
    
}
