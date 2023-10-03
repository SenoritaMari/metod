using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashaMetod
{
    public class Avto
    {
        private string nom;//номер
        private float bak;//колличество бензина в баке
        private float ras;// расход на 100

        public void info(string nom, float bak, float ras)
        {
            this.nom = nom;
            this.bak = bak;
            this.ras = ras;
        }
        public void Outinfo()
        {
            Console.WriteLine($"Номер: {this.nom}\nБак: {this.bak} \nРасход: {this.ras}");
        }
        public void Zapravka(float top)
        {
            this.bak += top;
        }
        public void Move(float km)
        {
            float ostatok = this.bak - (km * (this.ras / 100));
            if (ostatok > 0)
            {
                Console.WriteLine($"Мы доехали до места назначения и в баке осталось: {ostatok:F2}");
                Console.WriteLine($"Пункт назначения: {km} км");
            }
            if (ostatok <= 0)
            {
                Console.WriteLine($"Пункт назначения: {km} км");
                Console.WriteLine("Сколько заправим топлива: ");
                Zapravka(Convert.ToSingle(Console.ReadLine()));
                ostatok = this.bak - (km * (this.ras / 100));
                if (ostatok > 0)
                {
                    Console.WriteLine($"Мы доехали до места назначения и в баке осталось: {ostatok:F2}");
                    Console.WriteLine($"Пункт назначения: {km} км");
                }
                if (ostatok < 0)
                {
                    Console.WriteLine($"Пункт назначения: {km} км");
                    Console.WriteLine($"Не хватило до пункта назначения {ostatok * -1}");

                }

                
            }
        }
        public void Octatok(float Octatok)
        {

        }

    }
}