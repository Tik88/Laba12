using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
	public class Program
	{
		public static void Main()
		{
			try
			{
				Console.Write("Введите радиус окружности: ");
				double R = Convert.ToDouble(Console.ReadLine());
				if (R <= 0)
				{
					Console.Write("Ошибка! Радиус не может быть отрицательным!");
					return;
				}
				Console.Write("Введите координату Х точки: ");
				double x = Math.Abs(Convert.ToDouble(Console.ReadLine()));
				Console.Write("Введите координату Y точки: ");
				double y = Math.Abs(Convert.ToDouble(Console.ReadLine()));
				Circle.CircumferenceLength(R);
				Circle.Square(R);
				Circle.Position(R, x, y);
			}
			catch (FormatException)
			{
				Console.WriteLine("Неверный формат ввода.");
				return;
			}
		}

		static class Circle
		{
			public static void CircumferenceLength(double Radius)
			{
				double Circumferencelength = Math.PI * 2 * Radius;
				Console.WriteLine("Длина окружности равна {0:f2}", Circumferencelength);
			}
			public static void Square(double Radius)
			{
				double Square = Math.PI * Math.Pow(Radius, 2.0);
				Console.WriteLine("Площадь круга равна {0:f2}", Square);
			}
			public static void Position(double Radius, double positionX, double positionY)
			{
				if (positionX <= Radius && positionY <= Radius)
				{
					Console.WriteLine("Точка с координатами ({0},{1}) принадлежит кругу с радиусом {2}", positionX, positionY, Radius);
				}
				else
				{
					Console.WriteLine("Точка с координатами ({0},{1}) не принадлежит кругу с радиусом {2}", positionX, positionY, Radius);
				}
				Console.ReadKey();
			}
		}
	}

}
