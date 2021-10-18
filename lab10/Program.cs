using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{

    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(0, 0, 0);
            angle.SetParams();
            angle.ToRadians();
            Console.ReadKey();
        }
    }
    class Angle
    {
        public int grad;
        public int min;
        public int sec;

        public Angle(int g, int m, int s)
        {
            grad = g;
            min = m;
            sec = s;
        }

        public void SetParams()
        {
            try
            {
                Console.WriteLine("Введите градус угла");
                grad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение минут угла");
                min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение секунд угла");
                sec = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ToRadians()
        {
            if (grad < 0 || min < 0 || sec < 0)
            {
                Console.WriteLine("Угол не может быть отрицательным");
            }
            else
            {
                double gms = grad + (double)min / 60 + (double)sec / 3600;
                double AR = gms * (Math.PI) / 180;
                Console.WriteLine("Заданный угол {0} градусов {1} минут {2} секунд равен {3:f4} радиан", grad, min, sec, AR);
            }

        }



    }
}
