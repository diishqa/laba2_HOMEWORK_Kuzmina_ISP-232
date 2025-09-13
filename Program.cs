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
                string password1= Console.ReadLine();
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

            }
            Console.ReadLine();
        }
        
    }
}
