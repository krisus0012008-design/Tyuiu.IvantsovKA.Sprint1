using Tyuiu.IvantsovKA.Sprint1.Task3.V18.Lib;
namespace Tyuiu.IvantsovKA.Sprint1.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Иванцов К. А. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Иванцов Кирилл Андреевич | ИБКСб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной C  *");
            Console.WriteLine("* можно разместить внутри прямоугольника с размерами A x B без наложений. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

                Console.Write("Введите сторону A: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите сторону B: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите сторону C: ");
                double c = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество квадратов = " + ds.HowManySquares(a, b, c));

            Console.ReadKey();
        }
    }
}
