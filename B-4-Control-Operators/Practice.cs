using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
	partial class Practice
	{
		//B4-P1/25. If_TimeOfDayGreeting
		public static void B4_P1_25_If_TimeOfDayGreeting()
		{
			var timeOfDay = DateTime.Now;
			Console.WriteLine($"{timeOfDay.TimeOfDay}\n");
			if (timeOfDay.Hour < 6){
				Console.WriteLine("Добрая ночь");
			}else if (timeOfDay.Hour < 12){
				Console.WriteLine("Доброе утро");
			}else if (timeOfDay.Hour < 18){
				Console.WriteLine("Добрый день");
			}else{
				Console.WriteLine("Добрый вечер");
			}
			return;
		}

		//B4-P2/25. If_NumbersComparing
		public static void B4_P2_25_If_NumbersComparing()
		{
			int num1, num2;

			Console.WriteLine("Сравнение двух чисел");

			Console.Write("Введите первое число: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите второе число: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			if (num1 > num2)
			{
				Console.WriteLine($"Значение {num1} больше {num2} на {num1 - num2}");
			}
			else if (num1 < num2)
			{
				Console.WriteLine($"Значение {num1} меньше {num2} на {num2 - num1}");
			}
			else
			{
				Console.WriteLine("Значения равны");
			}
			return;
		}

		//B4-P3/25. If_PositiveNumbersComparing
		public static void B4_P3_25_If_PositiveNumbersComparing()
		{
			int num1, num2;

			Console.WriteLine("Сравнение двух чисел. Оба должны быть пололжительными");

			Console.Write("Введите первое число: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите второе число: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			if (num1 >= 0 && num2 >= 0)
			{
				if (num1 > num2)
				{
					Console.WriteLine($"Значение {num1} больше {num2} на {num1 - num2}");
				}
				else if (num1 < num2)
				{
					Console.WriteLine($"Значение {num1} меньше {num2} на {num2 - num1}");
				}
				else
				{
					Console.WriteLine("Значения равны");
				}
			}
			else if (num1 < 0 && num2 < 0)
			{
				Console.WriteLine("Оба числа некорректны");
			}
			else if (num1 < 0)
			{
				Console.WriteLine("Первое число некорректно");
			}
			else
			{
				Console.WriteLine("Второе число некорректно");
			}
			return;
		}

		//B4-P4/25. If_Akinator5Numbers
		public static void B4_P4_25_If_Akinator5Numbers()
		{
			int numToGuess, predictedNum = 1;

			Console.WriteLine("Здесь акинатор (бот?) угадывает загаданное число от 1 до 5");
			Console.Write("Загадывайте число: ");
			numToGuess = Convert.ToInt32(Console.ReadLine());
			if (numToGuess < 1 || numToGuess > 5)
			{
				Console.WriteLine("Введённое число некорректно");
				return;
			}
			while (true) {
				Console.WriteLine($"Бот: Допустим, ваше число {predictedNum}");
				if (numToGuess == predictedNum)
				{
					break;
				}
				else
				{
					Console.WriteLine("Вы: Не угадал. Попробуй ещё раз)");
					predictedNum++;
				}
			}
			Console.WriteLine("Вы: Угадал! А ты хорош)");
			return;
		}

		//B4-P5/25. Switch_DayOfWeek
		public static void B4_P5_25_Switch_DayOfWeek()
		{
			Console.WriteLine("Приветствие с учётом дня недели");

			var dayToday = DateTime.Today;
			switch ((int)dayToday.DayOfWeek) {
				case 0:
					Console.WriteLine("Доброго воскресенья, Оля!");
					break;
				case 1:
					Console.WriteLine("Доброго понедельника, Оля!");
					break;
				case 2:
					Console.WriteLine("Доброго вторника, Оля!");
					break;
				case 3:
					Console.WriteLine("Доброй среды, Оля!");
					break;
				case 4:
					Console.WriteLine("Доброго четверга, Оля!");
					break;
				case 5:
					Console.WriteLine("Доброя пятницы, Оля!");
					break;
				case 6:
					Console.WriteLine("Доброй субботы, Оля!");
					break;
			}
			return;
		}

		//B4-P6/25. Switch_GameNavigation
		public static void B4_P6_25_Switch_GameNavigation()
		{
			Console.WriteLine("Обработка движения wasd. Для выхода нажмите q");

			ConsoleKeyInfo key;

		tmplabel:

			key = Console.ReadKey();

			switch (key.KeyChar)
			{
				case 'w':
				case 'W':
					Console.WriteLine("\tИдём наверх");
					break;
				case 'a':
				case 'A':
					Console.WriteLine("\tИдём налево");
					break;
				case 's':
				case 'S':
					Console.WriteLine("\tИдём вниз");
					break;
				case 'd':
				case 'D':
					Console.WriteLine("\tИдём направо");
					break;
			}

			if (key.KeyChar != 'q')
			{
				goto tmplabel;
			}
			Console.WriteLine("\tКонец игры");
			return;
		}

		//B4-P7/25. For_10OddEven
		public static void B4_P7_25_For_10OddEven()
		{
			Console.WriteLine("Вывод чисел от 0 до 10 с параметром \"чётность\"");

			for (int counter = 0; counter <= 10; counter++)
			{
				if (counter % 2 == 0)
				{
					Console.WriteLine($"Число {counter} чётное");
				}
				else {
					Console.WriteLine($"Число {counter} нечётное");
				}
			}
			return;
		}


		//B4-P8/25. For_3DevideNumbers
		public static void B4_P8_25_For_3DevideNumbers()
		{
			Console.WriteLine("Вывод чисел от 30 до 0, которые делятся на 3");

			for (int i = 30; i > 0; i--)
			{
				if (i % 3 == 0)
				{
					Console.WriteLine($"Число {i} делится на 3 без остатка");
				}
			}
			return;
		}


		//B4-P9/25. For_Matrix10x10
		public static void B4_P9_25_For_Matrix10x10()
		{
			int enumerator = 0;
			Console.WriteLine("Вывод матрицы 10 на 10");
			for (int row = 0; row < 10; row++)
			{
				for (int col = 0; col < 10; col++)
				{
					Console.Write($"{enumerator++}\t");
				}
				Console.WriteLine();
			}
			return;
		}


		//B4-P10/25. For_HelloWorld
		public static void B4_P10_25_For_HelloWorld()
		{
			Console.WriteLine("Вывод фразы 6 раз");

			for (int i = 0; i < 6; i++)
			{
				Console.WriteLine("Hello, world!");
			}
			return;
		}


		//B4_P11/25. For_Afrochildren
		public static void B4_P11_25_For_Afrochildren()
		{
			Console.WriteLine("Считалка про 10 негритят");

			const int totalChildren = 10;

			for (int curAmountOfChildren = totalChildren; curAmountOfChildren > 0; curAmountOfChildren--)
			{
				if (curAmountOfChildren > 1)
				{
					Console.WriteLine($"{curAmountOfChildren} негритят пошли гулять на луг");
					Console.WriteLine($"С одним там что-то стало, осталось {curAmountOfChildren - 1} штук\n");
				}
				else
				{
					Console.WriteLine("Последний взял жену из племени Ну-Ну");
					Console.WriteLine($"Какой-то в спальне звук - их снова {totalChildren} штук)\n");
				}
			}
			return;
		}


		//B4-P12/25. For_Minus10OddEven
		public static void B4_P12_25_For_Minus10OddEven()
		{
			Console.WriteLine("Вывод чисел от 0 до -10 с параметром \"чётность\"");

			for (int counter = 0; counter >= -10; counter--)
			{
				if (counter % 2 == 0)
				{
					Console.WriteLine($"Число {counter} чётное");
				}
				else
				{
					Console.WriteLine($"Число {counter} нечётное");
				}
			}
			return;
		}


		//B4-P13/25 For_LettersCount
		public static void B4_P13_25_For_LettersCount()
		{
			Console.WriteLine("Считаем количество букв \"а\" в введённом слове");

			string inputedWord;
			int numOfLetters = 0;

			Console.Write("Введите слово: ");
			inputedWord = Console.ReadLine();

			foreach (char singleChar in inputedWord)
			{
				if (singleChar == ' ')
				{
					Console.WriteLine("Некорректная строка. Пробелы недопустимы");
					return;
				}
				else if (singleChar == 'а')
				{
					numOfLetters++;
				}
			}
			Console.WriteLine($"Символ \"а\" встречался в введённом слове {numOfLetters} раз");
			return;
		}


		//B4-P14/25 *For_AlphabetBack
		public static void B4_P14_25_For_AlphabetBack()
		{
			Console.WriteLine("Выводим английский алфавит в обратном порядке");

			for (int symbolNum = 0; symbolNum < 26; symbolNum++)
			{
				Console.Write($"{(char)((int)'z' - symbolNum)} ");
			}
			return;
		}


		//B4-P15/25 While_OddEventNumber
		public static void B4_P15_25_While_OddEventNumber()
		{
			Console.WriteLine("Все чётные числа от 1 до n");

			Console.WriteLine("Введите конец диапазона: ");
			int endNum = Convert.ToInt32(Console.ReadLine());

			if (endNum < 2)
			{
				Console.WriteLine("Нет чётных чисел в таком диапазоне");
				return;
			}

			for (int i = 1; i <= endNum; i += 2)
			{
				if (i == 1)
				{
					i++;
				}

				Console.Write($"{i} ");
			}
			return;
		}


		//B4-P16/25 DoWhile_OddEventNumber
		public static void B4_P16_25_DoWhile_OddEventNumber()
		{
			Console.WriteLine("Все нечётные числа от 1 до n");

			Console.WriteLine("Введите конец диапазона: ");
			int endNum = Convert.ToInt32(Console.ReadLine());

			if (endNum < 1)
			{
				Console.WriteLine("Нет чётных чисел в таком диапазоне");
				return;
			}

			for (int i = 1; i <= endNum; i += 2)
			{
				Console.Write($"{i} ");
			}
			return;
		}


		//B4-P17/25 While_HelloWorld
		public static void B4_P17_25_While_HelloWorld()
		{
			Console.WriteLine("Выводим фразу 6 раз через while");

			int i = 6;

			while (i > 0)
			{
				Console.WriteLine("Hello, world!");
				i--;
			}
			return;
		}


		//B4-P18/25 While_Multiplier
		public static void B4_P18_25_While_Multiplier()
		{
			Console.WriteLine("Возводим число в степень");

			Console.Write("Введите число: ");
			int num = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите степень: ");
			int exp = Convert.ToInt32(Console.ReadLine());
			int result = 1;

			int i = 0;

			while (i < exp)
			{
				result *= num;
				i++;
			}
			Console.WriteLine($"{num} в степени {exp} = {result}");
			return;
		}


		//B4-P19/25 While_SolveNumberAdding
		public static void B4_P19_25_While_SolveNumberAdding()
		{
			Console.WriteLine("Обучаем пользователя умножению\n");

			int guessedAnswer, correctAnswer = 4;

			while (true)
			{
				Console.Write("Сколько будет 2 x 2?  ");
				guessedAnswer = Convert.ToInt32(Console.ReadLine());

				if (guessedAnswer == correctAnswer)
				{
					break;
				}
				Console.WriteLine("Неверно. Подумай ещё раз\n");
			}
			Console.WriteLine("Молодчина!\n");
			return;
		}


		//B4-P20/25 While_DiceGame
		public static void B4_P20_25_While_DiceGame()
		{
			Console.WriteLine("Играем в настолку. Бросаем дайс до 25 очков\n");

			const int minDiceNum = 1, maxDiceNum = 6;
			int currentScore = 0, maxScore = 25, newDiceNum = 0;

			while (currentScore < maxScore)
			{
				Console.Write("Бросаем кубик. Выпало число: ");
				newDiceNum = Convert.ToInt32(Console.ReadLine());
				if (newDiceNum < minDiceNum || newDiceNum > maxDiceNum)
				{
					Console.WriteLine("Читер!!! Больше не играешь!");
					return;
				}
				currentScore += newDiceNum;
				Console.WriteLine($"Сейчас набрано {currentScore} очков из {maxScore}");
			}
			Console.WriteLine("\nВы победили! Мои поздравления");

			return;
		}


		//B4-P21/25 *While_DiceGameMultiplePlayers
		public static void dB4_P21_25_While_DiceGameMultiplePlayers()
		{
			Console.WriteLine("Играем в настолку. Теперь вдвоём. Бросаем дайс до 25 очков\n");

			const int minDiceNum = 1, maxDiceNum = 6;
			int currentScore1 = 0, currentScore2 = 0, maxScore = 25, newDiceNum = 0, curPlayer = 0;

			while (true)
			{
				for (curPlayer = 1; curPlayer <= 2; curPlayer++)
				{
					Console.Write($"Игрок{curPlayer} бросает кубик. Выпало число: ");
					newDiceNum = Convert.ToInt32(Console.ReadLine());
					if (newDiceNum < minDiceNum || newDiceNum > maxDiceNum)
					{
						Console.WriteLine($"Игрок{curPlayer} читер!!! Больше не играешь!");
						return;
					}
					if (curPlayer == 1)
					{
						currentScore1 += newDiceNum;
						Console.WriteLine($"У игрока{curPlayer} Сейчас набрано {currentScore1} очков из {maxScore}");
						if(currentScore1 >= maxScore)
						{
							Console.WriteLine($"\nИгрок{curPlayer}, вы победили! Мои поздравления");
							return;
						}
					}
					else
					{
						currentScore2 += newDiceNum;
						Console.WriteLine($"У игрока{curPlayer} Сейчас набрано {currentScore2} очков из {maxScore}\n");
						if (currentScore2 >= maxScore)
						{
							Console.WriteLine($"\nИгрок{curPlayer}, вы победили! Мои поздравления");
							return;
						}
					}
				}
			}
		}


		//B4-P22_25 *While_Akinator100Numbers
		public static void B4_P22_25_While_Akinator100Numbers()
		{
			int minLim = 0, maxLim = 100, tmpNum = 0, userNum;

			Console.WriteLine("Бот угадывает число от 0 до 100");

			Console.Write("Загадайте число: ");
			userNum = Convert.ToInt32(Console.ReadLine());

			if (userNum < 0 || userNum > 100)
			{
				Console.WriteLine("Число вне заданного диапазона");
				return;
			}

			while (true)
			{
				/*				Console.WriteLine($"\nБот: Ваше число {minLim}?");
								if (userNum > minLim)
								{
									Console.WriteLine("Вы: Нет, больше");
								}
								else
								{
									Console.WriteLine("Вы: Да, угадал");
									break;
								}

								Console.WriteLine($"Бот: Ваше число {maxLim}?");
								if (userNum < maxLim)
								{
									Console.WriteLine("Вы: Нет, меньше");
								}
								else
								{
									Console.WriteLine("Вы: Да, угадал");
									break;
								}
				*/

				tmpNum = (maxLim + minLim) / 2;

				Console.WriteLine($"\nБот: Ваше число {tmpNum}?");
				if (userNum > tmpNum)
				{
					Console.WriteLine("Вы: Нет, больше");
					minLim = tmpNum;
				}
				else if(userNum < tmpNum)
				{
					Console.WriteLine("Вы: Нет, меньше");
					maxLim = tmpNum;
				}
				else
				{
					Console.WriteLine("Вы: Да, угадал");
					break;
				}
			}
			return;
		}


		//B4-P23/25 IfElse_Calcultor
		public static void B4_P23_25_IfElse_Calcultor()
		{

		}


		//B4-P24_25 Switch_Calculator
		public static void B4_P24_25_Switch_Calculator()
		{

		}


		//B4-P25/25 Cycle_WordRevercse
		public static void B4_P25_25_Cycle_WordRevercse()
		{
		}
	}
}
