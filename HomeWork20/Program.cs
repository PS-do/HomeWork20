using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20
{
    internal class Program
    {

        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            
            MyDelegate myDelegate = S_round;
            myDelegate += L_round ;
            myDelegate += V_sphere;
            myDelegate(5.0);
            Console.ReadKey();
            //            В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
            //            -метод получает входным параметром переменную типа double;
            //            -метод возвращает значение типа double, которое является результатом вычисления.
            //Методы должны быть объявлены как статические.
        }

        //Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
        static double L_round(double R)
        //-длину окружности по формуле D = 2 * π* R;
        {
            double r = 2 * Math.PI * R;
            Console.WriteLine($"-длина окружности по формуле D = 2 * π* R. L={r}");
            return r;
        }
        static double S_round(double R)
        //-площадь круга по формуле S = π * R²;
        {
            double r = Math.PI * R * R;
            Console.WriteLine($"-площадь круга по формуле S = π * R². S={r}");
            return r;
        }
        static double V_sphere(double R)
        //-объем шара.Формула V = 4 / 3 * π * R³.
        {
            double r = 4.0 / 3.0 * Math.PI * R * R * R;
            Console.WriteLine($"-объем шара.Формула V = 4 / 3 * π * R³. V={r}");
            return r;
        }

    }
}
