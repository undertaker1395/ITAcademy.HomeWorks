using System;
using AssemblyOne;


namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();

            moto.speedPublic = 100;
            //moto.speedPrivate = 100; //Ошибка, доступ ограничен. имеет модификатор private и не доступна в данном проекте
            //moto.speedProtected = 100; //Ошибка, доступ ограничен. класс Program не является классом-наследником класса Motocycle
            //moto.speedInternal = 100; //Ошибка, доступ ограничен. модификатор Internal и не доступен из другого проекта
            //moto.speedProtIntern = 100; //Ошибка, доступ ограничен. класс Program не является классом-наследником класса Motocycle
            //moto.speedPrivProt = 100; //Ошибка, доступ ограничен. имеет модификатор private и не доступна в данном проекте

            moto.odometrPublic = 100;

            SportMoto sMoto = new SportMoto();
        }
    }

    class SportMoto : Motorcycle
    {
        static void Main(string[] args)
        {
            SportMoto sMoto = new SportMoto();
            sMoto.speedPublic = 135;
            sMoto.speedProtected = 135;
            sMoto.speedProtIntern = 135;
            //sMoto.speedPrivate = 100; //Ошибка, доступ ограничен. имеет модификатор private и не доступна в данном проекте
            //sMoto.speedPrivProt = 100; //Ошибка, доступ ограничен. имеет модификатор private и не доступна в данном проекте
            //sMoto.speedInternal = 100; //Ошибка, доступ ограничен. модификатор Internal и не доступен из другого проекта

            sMoto.StartEngineProtected();
            sMoto.StartEngineProtIntern();
            sMoto.StartEnginePublic();
        }
    }
    
}
