namespace Itog_Console
{
class Program
{
    static void Main()
    {
        Razdel1();
        Razdel2();
        Razdel3();
        Razdel4();
    }

    static void Razdel1()
    {
        Console.WriteLine("Раздел 1");
        Random rnd = new Random();
        
        Task1();
        Task2();
        Task3();
        Task4(rnd.Next(5, 155));
        Task5(rnd.Next(100, 999));
        Task6();
        
        
        void Task1()
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите число для определения его четности");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x % 2 == 0 ? "Четное" : "Нечетное"); 
        }

        void Task2()
        {
            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("Введите 2 числа. Ответом будет то число, которое ближе к 10");
            Console.Write("Первое число: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(x1 - 10) < Math.Abs(x2 - 10) ? "Близжайшее к 10 число = "+x1 : "Близжайшее к 10 число = "+x2);
        }

        void Task3()
        {
            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("Введите 3 числа для решения квадратного уравнения");
            Console.Write("Первое число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0) {
                Console.WriteLine($"x1 = {(-b - Math.Sqrt(D))/(2*a)}; x2 = {(-b + Math.Sqrt(D))/(2*a)}");
            } else {
                if (D == 0) {
                    Console.WriteLine($"x = {-b/(2*a)}");
                } else {
                    Console.WriteLine("Корней нет");
                }
            }
        }
        
        void Task4(int n)
        {
            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("Попало ли случайно выбранное из отрезка [5;155] целое число в интервал (25;100)?");
            Console.WriteLine("Число = " + n);
            Console.WriteLine(n <= 100 && n >= 25 ? "Попало" : "Мимо");
        }

        void Task5(int n)
        {
            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("Случайное трехзначное число и наибольшая цифра в нем");
            Console.WriteLine("Число = "+n);
            int[] a = new int[n.ToString().Length];
            for (int i = 0; i < a.Length; i++) {
                a[i] = n % 10;
                n /= 10;
            }
            Console.WriteLine("Наибольшая цифра = "+a.Max());
        }

        void Task6()
        {
            Console.WriteLine("\nЗадание 6");
            Console.WriteLine("Введите три попарно неравных числа");
            Console.Write("Первое число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[] arr =  {a, b, c};
            Array.Sort(arr);
            
            Console.WriteLine("Отсортированные в порядке возростания числа:");
            foreach (var i in arr) {
                Console.Write(i + " ");
            }
        }
    }

    static void Razdel2()
    {
        Console.WriteLine("\nРаздел 1");
        
        Task1();
        Task2();
        Task3();
        Console.WriteLine(Task4());
        Task5();

        
        void Task1()
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Все четырёхзначные числа последовательности 1000 1003 1006 ...");
            for (int i = 1000; i < 9999; i = i + 3) {
                Console.Write(i + ", ");
            }
        }
        
        void Task2()
        {
            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("Все неотрицательные элементы последовательности 90 85 80 75 ...");
            for (int i = 90; i >= 0; i -= 5) {
                Console.Write(i + " ");
            }
        }
        
        void Task3(){
            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("Первые 20 элементов последовательности 2 4 8 16 ...");
            for (int i = 1; i <= 20; i++) {
                Console.Write($"{Math.Pow(2, i)} ");
            }
        }
        
        string Task4()
        {
            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("Проверка на \"простоту\" числа");
            Console.Write("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < x; i++) {
                if (x % i == 0)
                    return "Не простое";
            }
            return "Простое";
        }
        
        void Task5()
        {
            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("12 первых элементов последовательности");
            
            int a = 3;
            for (int i = 1; i <= 12; i++) {
                Console.Write(a + " ");
                a = (2*a-2)/2;
            }
        }
    }

    static void Razdel3()
    {
        Random rnd = new Random();

        Console.WriteLine("Раздел 3");

        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();






        void Task1()
        {
            Console.WriteLine("Задание 1");
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arr[i] = (i + 1) * 2;
            }

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        void Task2()
        {
            Console.WriteLine("\nЗадание 2");
            int[] arr = new int[50];
            for (int i = 0; i < 50; i++)
            {
                arr[i] = i * 2 + 1;
            }

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("");

            Array.Reverse(arr);
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }

        void Task3()
        {
            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("15 случайных целых чисел из отрезка [0;9]");
            int count = 0;
            int[] arr = new int[15];
            for (int i = 0; i < 15; i++)
            {
                arr[i] = rnd.Next(0, 9);
            }

            foreach (var i in arr)
            {
                Console.Write(i + " ");
                if (i % 2 == 0 && i != 0)
                {
                    count++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Количество четных чисел = " + count);
        }

        void Task4()
        {
            Console.WriteLine("\nЗадание 4");
            Console.WriteLine(
                "8 случайных целых чисел из отрезка [1;10]. Заменить каждый элемент с нечётным индексом на ноль.");

            int[] arr = new int[8];
            for (int i = 0; i < 8; i++)
            {
                arr[i] = rnd.Next(1, 10);
            }

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    arr[i] = 0;
                }

                Console.Write(arr[i] + " ");
            }
        }

        void Task5()
        {
            Console.WriteLine("\nЗадание 5");
            Console.WriteLine(
                "2 массива из 5 случайных целых чисел из отрезка [0;5] каждый. Среднее арифметическое элементов каждого массива");

            int[] arr1 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr1[i] = rnd.Next(0, 5);
                Console.Write(i + " ");
            }

            Console.WriteLine("");

            int[] arr2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr2[i] = rnd.Next(0, 5);
                Console.Write(i + " ");
            }

            Console.WriteLine("");



            float avg1 = arr1.Sum() / (float)5;
            float avg2 = arr2.Sum() / (float)5;

            if (avg1 > avg2)
            {
                Console.WriteLine($"Среднее арифметическое первого массива больше: {avg1}");
            }
            else
            {
                if (avg1 < avg2)
                {
                    Console.WriteLine($"Среднее арифметическое второго массива больше: {avg2}");
                }
                else
                {
                    Console.WriteLine($"Средние арифметические массивово равны: {avg1} и {avg2}");
                }
            }
        }

        void Task6()
        {
            Console.WriteLine("\nЗадание 6");
            Console.WriteLine(
                "Массив из 4 случайных целых чисел из отрезка [10;99]. Является ли массив строго возрастающей последовательностью?");

            int[] arr = new int[4];
            for (int i = 0; i < 4; i++)
            {
                arr[i] = rnd.Next(10, 99);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("");

            bool res = true;
            for (int i = 0; i < 3; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    res = false;
                }
            }

            if (res)
            {
                Console.WriteLine("Массив является строго возрастающей последовательностью");
            }
            else
            {
                Console.WriteLine("Массив НЕ является строго возрастающей последовательностью");
            }
        }

        void Task7()
        {
            Console.WriteLine("\nЗадание 7");
            Console.WriteLine("Массив из 12 случайных целых чисел из отрезка [-15;15].");
            int[] arr = new int[12];
            for (int i = 0; i < 12; i++) {
                arr[i] = rnd.Next(-15, 15);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
            
            Array.Sort(arr);
            Console.Write("Максимальный элемент массива: "+arr[11]+" ");
            for (int i = 0; i < 11; i++) {
                if (arr[i] == arr[11]) {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }

    static void Razdel4()
    {
        Console.WriteLine("Раздел 4");

        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        

        void Task1()
        {
            Console.WriteLine("\nЗадание 1");
            Console.WriteLine("Две переменные х, у. Найти наименьшее из х, у");
            Console.Write("Введите число x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Наименьшее число: "+Math.Min(x, y));
        }

        void Task2()
        {
            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("Две переменные х, у. Найти наименьшее из х+у, х*у*0,5");
            Console.Write("Введите число x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Наименьшее число: "+Math.Min(Math.Min(x+y, x*y), 0.5));
        }

        void Task3()
        {
            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("Две переменные х, у. Найти наименьшее из 2х, |х-у|, 4.5, (x+y)/3.");
            Console.Write("Введите число x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Наименьшее число: "+Math.Min(Math.Min(2*x, Math.Abs(x-y)), Math.Min(4.5, (x+y)/3)));
        }

        void Task4()
        {
            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("Вычислить z = max (х, 2у — х) + max (5х + Зу, у)");
            Console.Write("Введите число x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = 0;
            
            Console.WriteLine(max(x, 2*y - x) + max(5*x + 3*y, y));
        }

        int max(int a, int b)
        {
            int res;
            if (a > b) {
                res = a;
            } else {
                res = b;
            }

            return res;
        }
        
        void Task5()
        {
            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("Вычислить √6+6/2 + √13+13/2 + √21+21/2");
            
            Console.WriteLine((snglSqrt(6)+6)/2 + (snglSqrt(13)+13)/2 +  (snglSqrt(21)+21)/2);
            Console.WriteLine("Или если я неправильно понял:");
            Console.WriteLine(dblSqrt(6)/2 + dblSqrt(13)/2 +  dblSqrt(21)/2);
        }

        double dblSqrt(double n)
        {
            double res;
            res = Math.Sqrt(Math.Sqrt(n) + n);
            return res;
        }

        double snglSqrt(double n)
        {
            return Math.Sqrt(n);
        }
    }
}
}
