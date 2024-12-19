using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Привет, мир!
            PrintHelloWorld();

            // 2. Сумма двух целых чисел
            Console.WriteLine(Sum(3, 5));

            // 3. Длина строки
            Console.WriteLine(StringLength("Пример строки"));

            // 4. Среднее значение массива
            Console.WriteLine(Average(new int[] { 1, 2, 3, 4, 5 }));

            // 5. Проверка на четность числа
            Console.WriteLine(IsEven(4));

            // 6. Большее из двух чисел
            Console.WriteLine(Max(3, 5));

            // 7. Строка в верхнем регистре
            Console.WriteLine(ToUpperCase("hello"));

            // 8. Произведение двух чисел
            Console.WriteLine(Multiply(4, 5));

            // 9. Количество строк в массиве
            Console.WriteLine(CountStrings(new string[] { "apple", "banana", "cherry" }));

            // 10. Обратный порядок строки
            Console.WriteLine(ReverseString("hello"));

            // 11. Разность двух чисел
            Console.WriteLine(Subtract(10, 4));

            // 12. Минимальное значение в массиве
            Console.WriteLine(MinValue(new int[] { 5, 3, 8, 1 }));

            // 13. Проверка на палиндром
            Console.WriteLine(IsPalindrome("madam"));

            // 14. Сортировка массива строк
            SortStrings(new string[] { "banana", "apple", "cherry" });

            // 15. Генерация случайного числа
            Console.WriteLine(GenerateRandomNumber(1, 10));

            // 16. Замена пробелов на подчеркивания
            Console.WriteLine(ReplaceSpacesWithUnderscores("Hello world"));

            // 17. Элементы, присутствующие в обоих массивах
            var commonElements = CommonElements(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 });
            Console.WriteLine(string.Join(", ", commonElements));

            // 18. Количество гласных в строке
            Console.WriteLine(VowelCount("Hello world"));

            // 19. Факториал числа
            Console.WriteLine(Factorial(5));

            // 20. Массив четных чисел
            var evenNumbers = EvenNumbers(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(string.Join(", ", evenNumbers));

            // 21. Частота появления символов
            Console.WriteLine(CharFrequency("Hello"));

            // 22. Элементы, присутствующие только в первом массиве
            var uniqueInFirstArray = UniqueInFirstArray(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 });
            Console.WriteLine(string.Join(", ", uniqueInFirstArray));

            // 23. Строка в формате CamelCase
            Console.WriteLine(ToCamelCase("hello world"));

            // 24. Двоичное представление числа
            Console.WriteLine(ToBinary(5));

            // 25. Сумма положительных чисел в массиве
            Console.WriteLine(SumOfPositiveNumbers(new int[] { -1, 2, 3, -4, 5 }));

            // 26. Строка в формате Title Case
            Console.WriteLine(ToTitleCase("hello world"));

            // 27. Строка из первых букв слов
            Console.WriteLine(FirstLetters(new string[] { "apple", "banana", "cherry" }));

            // 28. Наибольший общий делитель (НОД)
            Console.WriteLine(GCD(12, 15));

            // 29. Массив квадратов чисел
            var squaredNumbers = SquaredNumbers(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(string.Join(", ", squaredNumbers));

            // 30. Строка без дубликатов символов
            Console.WriteLine(RemoveDuplicates("aabbcc"));
        }

        // 1. Привет, мир!
        static void PrintHelloWorld()
        {
            Console.WriteLine("Привет, мир!");
        }

        // 2. Сумма двух целых чисел
        static int Sum(int a, int b)
        {
            return a + b;
        }

        // 3. Длина строки
        static int StringLength(string str)
        {
            return str.Length;
        }
        // 4. Среднее значение массива
        static double Average(int[] arr)
        {
            return arr.Average();
        }

        // 5. Проверка на четность числа
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // 6. Большее из двух чисел
        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // 7. Строка в верхнем регистре
        static string ToUpperCase(string str)
        {
            return str.ToUpper();
        }

        // 8. Произведение двух чисел
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        // 9. Количество строк в массиве
        static int CountStrings(string[] arr)
        {
            return arr.Length;
        }

        // 10. Обратный порядок строки
        static string ReverseString(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        // 11. Разность двух чисел
        static int Subtract(int a, int b)
        {
            return a - b;
        }

        // 12. Минимальное значение в массиве
        static int MinValue(int[] arr)
        {
            return arr.Min();
        }

        // 13. Проверка на палиндром
        static bool IsPalindrome(string str)
        {
            var reversed = new string(str.Reverse().ToArray());
            return str == reversed;
        }

        // 14. Сортировка массива строк
        static void SortStrings(string[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine(string.Join(", ", arr));
        }

        // 15. Генерация случайного числа
        static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // 16. Замена пробелов на подчеркивания
        static string ReplaceSpacesWithUnderscores(string str)
        {
            return str.Replace(' ', '_');
        }

        // 17. Элементы, присутствующие в обоих массивах
        static int[] CommonElements(int[] arr1, int[] arr2)
        {
            return arr1.Intersect(arr2).ToArray();
        }

        // 18. Количество гласных в строке
        static int VowelCount(string str)
        {
            return str.Count(c => "aeiouAEIOU".Contains(c));
        }

        // 19. Факториал числа
        static int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        // 20. Массив четных чисел
        static int[] EvenNumbers(int[] arr)
        {
            return arr.Where(n => n % 2 == 0).ToArray();
        }

        // 21. Частота появления символов
        static string CharFrequency(string str)
        {
            var frequency = str.GroupBy(c => c).Select(g => $"{g.Key}: {g.Count()}").ToArray();
            return string.Join(", ", frequency);
        }

        // 22. Элементы, присутствующие только в первом массиве
        static int[] UniqueInFirstArray(int[] arr1, int[] arr2)
        {
            return arr1.Except(arr2).ToArray();
        }

        // 23. Строка в формате CamelCase
        static string ToCamelCase(string str)
        {
            var words = str.Split(' ').Select(w => w.ToLower()).ToArray();
            words[0] = words[0].ToLower();
            for (int i = 1; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            return string.Join("", words);
        }

        // 24. Двоичное представление числа
        static string ToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }

        // 25. Сумма положительных чисел в массиве
        static int SumOfPositiveNumbers(int[] arr)
        {
            return arr.Where(n => n > 0).Sum();
        }
        // 26. Строка в формате Title Case
        static string ToTitleCase(string str)
        {
            var words = str.Split(' ').Select(w => char.ToUpper(w[0]) + w.Substring(1).ToLower()).ToArray();
            return string.Join(" ", words);
        }

        // 27. Строка из первых букв слов
        static string FirstLetters(string[] arr)
        {
            return string.Join("", arr.Select(w => w[0]));
        }

        // 28. Наибольший общий делитель (НОД)
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // 29. Массив квадратов чисел
        static int[] SquaredNumbers(int[] arr)
        {
            return arr.Select(n => n * n).ToArray();
        }

        // 30. Строка без дубликатов символов
        static string RemoveDuplicates(string str)
        {
            return new string(str.Distinct().ToArray());
        }
    }
}