using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();

            moto.speedPublic = 100;
            //moto.speedPrivate = 100; Ошибка, доступ ограничен. имеет модификатор private и класс Program ее не видит
            //moto.speedProtected = 100; Ошибка, доступ ограничен. класс Program не является классом-наследником класса Motocycle
            moto.speedInternal = 100;
            moto.speedProtIntern = 100;
            //moto.speedPrivProt = 100; Ошибка, доступ ограничен. класс Program не является классом-наследником класса Motocycle

            moto.odometrInternal = 70_000;
            moto.odometrProtIntern = 70_000;
            moto.odometrPublic = 70_000;

            moto.StartEngineInternal();
            moto.StartEngineProtIntern();
            moto.StartEnginePublic();

            moto.vinNumerInternal = "ASHDGJHG-37486T-SFJFKSJD";
            moto.vinNumerProtIntern = "hecfwuic-crwe-3c244c";
            moto.vinNumerPublic = "324ghjg-345jkhjghj5-243g";
        }
    }

    class SportBike : Motorcycle
    {
        static void Main(string[] args)
        {
            SportBike sMoto = new SportBike();
            sMoto.speedPublic = 120;
            //moto.speedPrivate = 100; Ошибка, доступ ограничен. имеет модификатор private и класс SportBike ее не видит
            sMoto.speedInternal = 120;
            sMoto.speedPrivProt = 120;
            sMoto.speedProtected = 120;
            sMoto.speedProtIntern = 120;

            sMoto.StartEngineInternal();
            sMoto.StartEnginePrivProt();
            sMoto.StartEngineProtected();
            sMoto.StartEngineProtIntern();
            sMoto.StartEnginePublic();
            
        }
    }
}
