namespace laba2_HOMEWORK_Kuzmina_ISP_232
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                Console.Write("Введите число: ");
                int chislo = Convert.ToInt32(Console.ReadLine());
                if (chislo % 2 == 0)
                {
                    Console.WriteLine($"Число {chislo} четное");
                }
                else
                {
                    Console.WriteLine($"Число {chislo} нечетное");
                }
            }
            else if (number == 2)
            {
                Console.WriteLine("Введите пароль: ");
                string password1 = Console.ReadLine();
                Console.WriteLine("Введите подтверждение пароля: ");
                string password2 = Console.ReadLine();
                if (password1 == password2)
                {
                    Console.WriteLine("Пароль принят!");
                }
                else
                {
                    Console.WriteLine("Пароль не принят!");
                }
            }
            else if (number == 3)
            {
                Console.WriteLine("Введите четырехзначное число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int a = num / 1000;
                int b = (num / 100) % 10;
                int c = (num / 10) % 10;
                int d = num % 10;
                if ((a + d) == (b - c))
                {
                    Console.WriteLine("ДА");
                }
                else
                {
                    Console.WriteLine("НЕТ");
                }

            }
            else if (number == 4)
            {
                Console.Write("Введите ваш возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("Доступ разрешен");
                }
                else
                {
                    Console.WriteLine("Доступ запрещен");
                }
            }
            else if (number == 5)
            {
                Console.Write("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 > num2)
                {
                    Console.WriteLine($"Наименьшее число - {num2}");
                }
                else
                {
                    Console.WriteLine($"Наименьшее число - {num1}");
                }
            }
            else if (number == 6)
            {
                Console.Write("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите опрецию: ");
                string op = Console.ReadLine();

                if (op == "+")
                {
                    Console.WriteLine($"{num1}{op}{num2}={num1 + num2}");
                }
                else if (op == "-")
                {
                    Console.WriteLine($"{num1}{op}{num2}={num1 - num2}");
                }
                else if (op == "*")
                {
                    Console.WriteLine($"{num1}{op}{num2}={num1 * num2}");
                }
                else if (op == ":")
                {
                    Console.WriteLine($"{num1}{op}{num2}={num1 / num2}");
                }

            }
            else if (number == 7)
            {
                Console.Write("Введите номер дня недели: ");
                string day = Console.ReadLine();
                switch (day)
                {
                    case "1":
                        Console.WriteLine("Понедельник");
                        break;
                    case "2":
                        Console.WriteLine("Вторник");
                        break;
                    case "3":
                        Console.WriteLine("Среда");
                        break;
                    case "4":
                        Console.WriteLine("Четверг");
                        break;
                    case "5":
                        Console.WriteLine("Пятница");
                        break;
                    case "6":
                        Console.WriteLine("Суббота");
                        break;
                    case "7":
                        Console.WriteLine("Воскресенье");
                        break;
                }
            }
            else if (number == 8)
            {
                Console.Write("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите опрецию: ");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "+":
                        Console.WriteLine($"{num1}{op}{num2}={num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"{num1}{op}{num2}={num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"{num1}{op}{num2}={num1 * num2}");
                        break;
                    case ":":
                        Console.WriteLine($"{num1}{op}{num2}={num1 / num2}");
                        break;

                }
            }
            else if (number == 9)
            {
                Console.Write("Введите уровень сложности от 1 до 3: ");
                string level = Console.ReadLine();
                switch (level)
                {
                    case "1":
                        Console.WriteLine("Легкий уровень");
                        break;
                    case "2":
                        Console.WriteLine("Средний уровень");
                        break;
                    case "3":
                        Console.WriteLine("Сложный уровень");
                        break;
                }

            }
            else if (number == 10)
            {
                Console.WriteLine("Это задание в отдельном файле:(");
            }
            else if (number == 11)
            {
                Console.Write("Введите класс: ");
                string clas = Console.ReadLine();
                if (clas == "Воин" || clas == "Разбойник" || clas == "Паладин" || clas == "Варвар" || clas == "Друид")
                {
                    Console.WriteLine("Ближний боец");
                }
                else if (clas == "Маг" || clas == "Охотник" || clas == "Жрец")
                {
                    Console.WriteLine("Дальнобойщик");
                }
                else
                {
                    Console.WriteLine("Нет такого класса");
                }
            }
            else if (number == 12)
            {
                Console.WriteLine("Введите 3 числа: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());
                int n3 = Convert.ToInt32(Console.ReadLine());
                int summ = 0;
                if (n1 > 0)
                {
                    summ += n1;
                }
                if (n2 > 0)
                {
                    summ += n2;
                }
                if (n3 > 0)
                {
                    summ += n3;
                }
                Console.WriteLine($"Сумма положительный чисел - {summ}");
            }
            else if (number == 13)
            {
                Console.WriteLine("Выбирите в какой путь вам идти: ");
                Console.WriteLine("Путь A: Войти в комнату с огромным драконом.");
                Console.WriteLine("Путь B: Пойти по темному коридору");
                string p = Console.ReadLine();
                if (p == "Путь A")
                {
                    Console.WriteLine("Ответьте на загадку: ");
                    Console.WriteLine($"Кто не дышит, но живет; \n хоть не нужно — много пьет; \n и в  жизни, и в смерти тело как лед");
                    string zagadka = Console.ReadLine();
                    if (zagadka == "рыба")
                    {
                        Console.WriteLine("Правильно! Дракон открывает вам дверь в следующую комнату");
                        Console.WriteLine("Выбирите: Дверь 1 или Дверь 2 ");
                        string dver = Console.ReadLine();
                        if (dver == "Дверь 1")
                        {
                            Console.WriteLine("Вы нашли сокровища Dungeon Master’а! ");
                        }
                        else if (dver == "Дверь 2")
                        {
                            Console.WriteLine("Вы попали в ловушку с ядовитыми шипами!");
                        }
                        else
                        {
                            Console.WriteLine("Неправильно! Дракон вас съел!");
                        }
                    }
                }
                else if (p == "Путь B")
                {
                    Console.WriteLine("Выбирите: Дверь 1 или Дверь 2 ");
                    string dver = Console.ReadLine();
                    if (dver == "Дверь 1")
                    {
                        Console.WriteLine("Вы нашли сокровища Dungeon Master’а! ");
                    }
                    else if (dver == "Дверь 2")
                    {
                        Console.WriteLine("Вы попали в ловушку с ядовитыми шипами!");
                    }

                }










                Console.ReadLine();
            }

        }
    }
}
