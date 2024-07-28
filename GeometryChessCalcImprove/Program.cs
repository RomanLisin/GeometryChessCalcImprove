
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeometryChessCalcImprove
{
	internal class Program
	{
		static bool running = true;
		static void Main(string[] args)
		{
			Console.Title = "GeometryChessCalc";
			Console.Write("Введите ширину: ");
			int num = int.Parse(Console.ReadLine());

			//  *****
			//  *****
			//  *****
			//  *****
			//  *****

			Console.WriteLine();
			Console.Write("0)");
			Console.WriteLine();

			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			//  *
			//  **
			//  ***
			//  ****
			//  *****

			Console.Write("1)");
			Console.WriteLine();
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			//  *****
			//  ****
			//  ***
			//  **
			//  *			

			Console.Write("2)");
			Console.WriteLine();
			for (int i = 0; i < num; i++)
			{
				for (int j = i; j < num; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			//  *****
			//   ****
			//    ***
			//     **
			//      *

			Console.Write("3)");
			Console.WriteLine();
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					Console.Write(j < i ? " " : "*");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			//  *
			//  **
			//  ***
			//  ****
			//  *****			

			Console.Write("4)");
			Console.WriteLine();
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j <= num; j++)
				{
					Console.Write(num - j > i ? " " : "*");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			//      /\
			//     /  \
			//    /    \
			//   /      \
			//  /        \
			//  \        /
			//   \      /
			//    \    /
			//     \  /
			//      \/

			Console.Write("5)");
			Console.WriteLine();
			for (int i = 0; i < num; i++)
			{
				for (int j = i; j <= num; j++) Console.Write(j == num ? "/" : " ");
				for (int j = 0; j <= 2 * i; j++) Console.Write(j == 2 * i ? "\\" : " ");
				Console.WriteLine();
			}
			for (int i = 1; i <= num; i++)
			{
				for (int j = 0; j <= i; j++) Console.Write(j == i ? "\\" : " ");
				for (int j = 2 * i; j <= 2 * num; j++) Console.Write(j == 2 * num ? "/" : " ");
				Console.WriteLine();
			}
			Console.WriteLine();

			//  +-+-+
			//  -+-+-
			//  +-+-+
			//  -+-+-
			//  +-+-+

			Console.Write("6)");
			Console.WriteLine();
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					Console.Write(i % 2 == j % 2 ? "+ " : "- ");
				}
				Console.WriteLine();
			}

			//  ┌──────────┐
			//  │██  ██  ██│
			//  │  ██  ██  │
			//  │██  ██  ██│
			//  │  ██  ██  │
			//  │██  ██  ██│
			//  └──────────┘

			Console.WriteLine();
			Console.Write("7)");
			Console.WriteLine();
			//num += 1;

			//Console.OutputEncoding = Encoding.UTF8;

			////Светлый высокий прямоугольник: █ (U + 2588) 219
			////Вертикальная полоска: │ (U + 2502) 179
			////Горизонтальная полоска: ─ (U + 2500) 196
			////Верхний левый угол: ┌ (U + 250C) (218)
			////Верхний правый угол: ┐ (U + 2510) (191)
			////Нижний левый угол: └ (U + 2514) 192
			////Нижний правый угол: ┘ (U + 2518)  217

			//for (int i = 0; i <= num; i++)
			//{
			//	for (int j = 0; j <= num; j++)
			//	{
			//		if (i == 0 && j == 0) Console.Write((char)0x250C);
			//		else if (i == 0) Console.Write(j != num ? new string((char)0x2500, 2) : new string((char)0x2510, 1));
			//		else if (j != 0 && j != num && i != num) Console.Write(i % 2 == j % 2 ? new string((char)0x2588, 2) : "  "); // 219 - long , 223 - short
			//		else if (i == num && j == 0) Console.Write((char)0x2514);
			//		else if (i == num) Console.Write(j != num ? new string((char)0x2500, 2) : new string((char)0x2518, 1));
			//		else Console.Write((char)0x2502);
			//	}
			//	Console.WriteLine();
			//}

			//num -= 1;

			// Верхняя граница
			Console.WriteLine((char)0x250C + new string((char)0x2500, num * 2) + (char)0x2510);

			for (int i = 0; i < num; i++)
			{
				Console.Write((char)0x2502); // Левая граница (вертикальная линия)

				for (int j = 0; j < num; j++)
				{
					// Определяем, какой символ использовать для клетки
					if ((i + j) % 2 == 0)
						Console.Write(new string((char)0x2588, 2)); // Светлая клетка
					else
						Console.Write("  "); // Темная клетка
				}

				Console.Write((char)0x2502); // Правая граница
				Console.WriteLine(); // Переход на новую строку
			}

			// Нижняя граница
			Console.WriteLine((char)0x2514 + new string((char)0x2500, num * 2) + (char)0x2518);

			//     * * *       * * *
			//     * * *       * * *
			//     * * *       * * *
			//           * * *
			//           * * *
			//           * * *
			//     * * *       * * *
			//     * * *       * * *
			//     * * *       * * *

			int boardSize = num;
			int cellSize = boardSize;

			for (int i = 0; i < boardSize; i++)
			{
				for (int row = 0; row < cellSize; row++) // для каждой строки  летки
				{
					for (int j = 0; j < boardSize; j++)
					{
						string cellContent;

						if ((i + j) % 2 == 0)
						{
							// Темная клетка: '* * * '
							cellContent = string.Concat(Enumerable.Repeat("* ", cellSize)).TrimEnd();
							// Enumrable.Repeat("* ", cellSize) -> "* ", "* ", "* "   - повторяем cellSize раз
							// string.Concat(Enumrable.Repeat("* ", cellSize)) -> "* * * " - конкатинируем
							// Concat(Enumerable.Repeat("* ", cellSize)).TrimEnd() -> "* * *" - обрезаем пробел в конце
						}
						else
						{
							// Светлая клетка: '     '
							cellContent = new string(' ', cellSize * 2 - 1);
						}

						// Выводим строку текущей клетки
						Console.Write(cellContent + " "); // Добавляем дополнительный пробел между клетками

						//		Console.Write(new string('*', cellSize) ); // тёмная клетка
						//	}
						//	else
						//	{
						//		Console.Write(new string(' ', cellSize) + new string(' ',1)); // светлая клетка
						//	}
					}
					Console.WriteLine();
				}
			}

			// Calculator

			Console.WriteLine();
			Console.Write("Calc");
			//bool running = true;
			// Запуск потока для обработки нажатий клавиш
			Thread keyListener = new Thread(KeyListener);
			keyListener.Start();
			Console.WriteLine("Введите выражение (например, 5 + 3) или нажмите Esc для выхода:");

			while (running)
			{
				//if (Console.KeyAvailable)
				//{
				//	var key = Console.ReadKey(true).Key;

				//	if (key == ConsoleKey.Escape)
				//	{
				//		running = false;
				//		break; //continue;
				//	}
				//}

				Console.Write("Введите выражение: ");
				string input = Console.ReadLine();

				if (input == null) continue; // если строка пуста, запрашиваем ввод снова
				double num_1, num_2, result = double.NaN;
				char operation;

				// разделение ввода на части
				string[] parts = input.Split(' ');

				// парсинг чисел и операции
				if (parts.Length == 3 &&
					double.TryParse(parts[0], out num_1) &&
					char.TryParse(parts[1], out operation) &&
					double.TryParse(parts[2], out num_2))
				{
					switch (operation)
					{
						case '+':
							result = num_1 + num_2;
							break;
						case '-':
							result = num_1 - num_2;
							break;
						case '*':
							result = num_1 * num_2;
							break;
						case '/':
							if (num_2 != 0)
							{
								result = num_1 / num_2;
							}
							else
							{
								Console.WriteLine("На ноль делить нельзя.");
								return;
							}
							break;
						case '%':
							if (num_2 != 0)
							{
								result = num_1 % num_2;
							}
							else
							{
								Console.WriteLine("На ноль делить нельзя.");
								return;
							}
							break;
						default:
							Console.WriteLine("Выражение написано неправильно.");
							return;
					}

					// Проверка на NaN и вывод результата
					if (double.IsNaN(result))
					{
						Console.WriteLine("Результат не является числом (NaN).");
					}
					else
					{
						Console.WriteLine($"Результат выражения -> {num_1} {operation} {num_2} = {result}");
					}
				}
				else
				{
					Console.WriteLine("Выражение написано неправильно.");
				}
			}
			Console.WriteLine("Конец программы");
		}
		static void KeyListener()
		{
			while (running)
			{
				if (Console.KeyAvailable)
				{
					var key = Console.ReadKey(true).Key;
					if (key == ConsoleKey.Escape)
					{
						running = false;
					}
				}
			}
		}
	}
}


