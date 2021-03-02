using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();

            moto.speedPublic = 100;

            //имеет модификатор private и класс Program ее не видит
            //moto.speedPrivate = 100; Ошибка, доступ ограничен

            //класс Program не является классом-наследником класса Motocycle
            //moto.speedProtected = 100; Ошибка, доступ ограничен

            moto.speedInternal = 100;
            moto.speedProtIntern = 100;

            //класс Program не является классом-наследником класса Motocycle
            //moto.speedPrivProt = 100; Ошибка, доступ ограничен


        }
    }

    class SportBike : Motorcycle
    {

    }
}
