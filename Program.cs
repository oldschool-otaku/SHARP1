namespace SHARP1
{
    internal static class Calc
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string perenos = Environment.NewLine;
                StreamWriter file = new("D:\\math.txt");
                file.Write($"{DateTime.Now}{perenos}");
                
                Console.WriteLine("Выберете пункт меню:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Проценты");
                Console.WriteLine("6. Возведение в степень");
                Console.WriteLine("7. Возведение под корень");
                {
                    char ch = char.Parse(Console.ReadLine() ?? string.Empty);
                    {
                        switch (ch)
                        {
                            case '1':
                            {
                                int num1 = int.Parse(Console.ReadLine() ?? string.Empty);
                                int num2 = int.Parse(Console.ReadLine() ?? string.Empty);
                                Console.Write($"Ответ: {num1 + num2}");
                                file.Write($"Ответ: {num1} + {num2} = {num1 + num2}");
                                break;
                            }
                            case '2':
                            {
                                int num1 = int.Parse(Console.ReadLine() ?? string.Empty);
                                int num2 = int.Parse(Console.ReadLine() ?? string.Empty);
                                Console.Write($"Ответ: {num1 - num2}");
                                file.Write($"Ответ: {num1} - {num2} = {num1 - num2}");
                                break;
                            }
                            case '3':
                            {
                                int num1 = int.Parse(Console.ReadLine() ?? string.Empty);
                                int num2 = int.Parse(Console.ReadLine() ?? string.Empty);
                                Console.Write($"Ответ: {num1 * num2}");
                                file.Write($"Ответ: {num1} * {num2} = {num1 * num2}");
                                break;
                            }
                            case '4':
                            {
                                int num1 = int.Parse(Console.ReadLine() ?? string.Empty);
                                int num2 = int.Parse(Console.ReadLine() ?? string.Empty);
                                Console.Write($"Ответ: {num1 / num2}");
                                file.Write($"Ответ: {num1}/ {num2} = {num1 / num2}");
                                break;
                            }
                            case '5':
                            {
                                int num = int.Parse(Console.ReadLine() ?? string.Empty);
                                int procent = int.Parse(Console.ReadLine() ?? string.Empty);
                                Console.WriteLine($" Ответ: {num / 100 * procent}");
                                file.Write($" Ответ: {num} / 100 * {procent} = {num / 100 * procent} ");
                                break;
                            }
                            case '6':
                            {
                                int num = int.Parse(Console.ReadLine() ?? string.Empty);
                                int pow = int.Parse(Console.ReadLine() ?? string.Empty);
                                Console.WriteLine($"Ответ: {Math.Pow(num, pow)}");
                                file.Write($"Ответ: {num} в степени {pow} = {Math.Pow(num, pow)}");
                                break;
                            }
                            case '7':
                            {
                                int num = int.Parse(Console.ReadLine() ?? string.Empty);
                                Console.WriteLine($"Ответ: {Math.Sqrt(num)}");
                                file.Write($"Ответ: Корень {num} =  {Math.Sqrt(num)}");

                                break;
                            }
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                        file.Close();
                        Console.WriteLine("Хотите продолжить? Y/N");
                        Console.Clear();
                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            continue;
                        }
                        break;
                    }
                }
            }
        }
    }
}