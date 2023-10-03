using MashaMetod;
using System;

class Program
{
    static void Main()
    {
        Avto[] car = new Avto[6];
        Random random = new Random();

        for (int i = 0; i < car.Length; i++)
        {
        Console.WriteLine("Введи количество топлива в баке: ");
            car[i] = new Avto();
            car[i].info("222", float.Parse(Console.ReadLine()), 10);
            car[i].Outinfo();
            float dal = random.Next(1, 300);
            car[i].Move(dal);
        }
        /*car.info("222", float.Parse(Console.ReadLine()), 10);
        car.Outinfo();
        float dal = random.Next(1, 300);
        car.Move(dal);*/
        

        
    }
}