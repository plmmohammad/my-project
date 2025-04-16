using System;

class Program
{
    static void Main()
    {
        // برای اجرا شدن، یکی از متدها رو فراخوانی کنید
        Exercise1();
    }

    // تمرین 1: کوچک‌ترین عدد از 20 عدد
    static void Exercise1()
    {
        double min = double.MaxValue;
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Enter number: ");
            double num = double.Parse(Console.ReadLine());
            if (num < min)
                min = num;
        }
        Console.WriteLine("smallest numer: " + min);
        Console.ReadKey();
    }

    // تمرین 2: بزرگ‌ترین عدد از 20 عدد
    static void Exercise2()
    {
        double max = double.MinValue;
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Enter number: ");
            double num = double.Parse(Console.ReadLine());
            if (num > max)
                max = num;
        }
        Console.WriteLine("Largest Number: " + max);
    }

    // تمرین 3: میانگین 20 عدد
    static void Exercise3()
    {
        double total = 0;
        for (int i = 0; i < 20; i++)
        {
            Console.Write("عدد را وارد کن: ");
            double num = double.Parse(Console.ReadLine());
            total += num;
        }
        Console.WriteLine("میانگین: " + (total / 20));
    }

    // تمرین 4: اعداد با رقم یکان 5
    static void Exercise4()
    {
        Console.Write("Enter a Number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 10 == 5)
                Console.WriteLine(i);
        }
    }

    // تمرین 5: فاکتوریل
    static void Exercise5()
    {
        Console.Write("Enter a Number: ");
        int num = int.Parse(Console.ReadLine());
        long fact = 1;
        for (int i = 1; i <= num; i++)
            fact *= i;
        Console.WriteLine("Factoriel: " + fact);
    }

    // تمرین 6: تعداد ارقام عدد
    static void Exercise6()
    {
        Console.Write("Enter a Number: ");
        string num = Console.ReadLine();
        Console.WriteLine("Count of number: " + num.Length);
    }

    // تمرین 7: وارونه عدد
    static void Exercise7()
    {
        Console.Write("Enter a Number: ");
        string num = Console.ReadLine();
        char[] arr = num.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine("Varoone: " + new string(arr));
    }

    // تمرین 8: عدد اول یا نه
    static void Exercise8()
    {
        Console.Write("Enter a Number: ");
        int num = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (num < 2) isPrime = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0) { isPrime = false; break; }
        }
        Console.WriteLine(isPrime ? "Number is aval." : "Number is't aval.");
    }

    // تمرین 9: نمایش اعداد 1 تا 100
    static void Exercise9()
    {
        for (int i = 1; i <= 100; i++)
            Console.WriteLine(i);
    }

    // تمرین 10: اعداد چهار رقمی قرینه
    static void Exercise10()
    {
        for (int i = 1000; i <= 9999; i++)
        {
            string s = i.ToString();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            if (s == new string(arr))
                Console.WriteLine(i);
        }
    }

    // تمرین 11: سری 1-2+3-4+...
    static void Exercise11()
    {
        Console.Write("Enter the number of sentences. : ");
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= N; i++)
            sum += (i % 2 == 0) ? i : -i;
        Console.WriteLine("Total series: " + sum);
    }

    // تمرین 12: مجموع سری 1 + 1/2 + 1/3 + ... + 1/N
    static void Exercise12()
    {
        Console.Write(" Enter the number N.: ");
        int N = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= N; i++)
            sum += 1.0 / i;
        Console.WriteLine("Total series: " + sum);
    }

    // تمرین 13: مقسوم‌علیه‌ها و تعدادشان
    static void Exercise13()
    {
        Console.Write("Enter the number N.: ");
        int N = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= N; i++)
        {
            if (N % i == 0)
            {
                Console.WriteLine(i);
                count++;
            }
        }
        Console.WriteLine("number: " + count);
    }

    // تمرین 14: چندمین روز سال
    static void Exercise14()
    {
        Console.Write("Enter the day: ");
        int R = int.Parse(Console.ReadLine());
        Console.Write("Enter the month: ");
        int M = int.Parse(Console.ReadLine());
        int[] days = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int total = R;
        for (int i = 0; i < M - 1; i++)
            total += days[i];
        Console.WriteLine("Day " + total + " is the year.");
    }

    // تمرین 15: معکوس عدد بدون استفاده از رشته
    static void Exercise15()
    {
        Console.Write("Enter the number: ");
        int num = int.Parse(Console.ReadLine());
        int reverse = 0;
        while (num > 0)
        {
            reverse = reverse * 10 + num % 10;
            num /= 10;
        }
        Console.WriteLine("turns: " + reverse);
    }

    // تمرین 16: تعداد ارقام زوج عدد
    static void Exercise16()
    {
        Console.Write("Enter the number: ");
        string num = Console.ReadLine();
        int count = 0;
        foreach (char c in num)
        {
            if ((c - '0') % 2 == 0)
                count++;
        }
        Console.WriteLine("Number of even digits: " + count);
    }

    // تمرین 17: مجموع ارقام یک عدد
    static void Exercise17()
    {
        Console.Write("Enter the number: ");
        string num = Console.ReadLine();
        int sum = 0;
        foreach (char c in num)
            sum += c - '0';
        Console.WriteLine("Sum of numbers: " + sum);
    }

    // تمرین 18: حاصلضرب ارقام یک عدد
    static void Exercise18()
    {
        Console.Write(" Enter the number: ");
        string num = Console.ReadLine();
        int product = 1;
        foreach (char c in num)
            product *= c - '0';
        Console.WriteLine("Product of numbers: " + product);
    }

    // تمرین 19: تعداد ارقام فرد و زوج
    static void Exercise19()
    {
        Console.Write("Enter the number: ");
        string num = Console.ReadLine();
        int even = 0, odd = 0;
        foreach (char c in num)
        {
            if ((c - '0') % 2 == 0)
                even++;
            else
                odd++;
        }
        Console.WriteLine("even number: " + even + ", fard: " + odd);
    }

    // تمرین 20: بررسی مضرب بودن دو عدد
    static void Exercise20()
    {
        Console.Write("First number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("The second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine((a % b == 0 || b % a == 0) ? "One is a multiple of the other." : "They are not multiples.");
    }

    // تمرین 21: بررسی توان 2 بودن عدد
    static void Exercise21()
    {
        Console.Write("Enter the number: ");
        int n = int.Parse(Console.ReadLine());
        bool isPower = false;
        for (int i = 1; i <= n; i *= 2)
        {
            if (i == n)
            {
                isPower = true;
                break;
            }
        }
        Console.WriteLine(isPower ? "It is a power of 2." : "It is not a power of 2..");
    }

    // تمرین 22: پیدا کردن رقم بیشینه در عدد
    static void Exercise22()
    {
        Console.Write("Enter the number: ");
        string num = Console.ReadLine();
        char maxDigit = '0';
        foreach (char c in num)
            if (c > maxDigit)
                maxDigit = c;
        Console.WriteLine("The highest number: " + maxDigit);
    }

    // تمرین 23: بررسی صعودی بودن ارقام عدد
    static void Exercise23()
    {
        Console.Write("Enter the number: ");
        string num = Console.ReadLine();
        bool isAscending = true;

        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] <= num[i - 1])
            {
                isAscending = false;
                break;
            }
        }

        if (isAscending)
            Console.WriteLine("is ascending.");
        else
            Console.WriteLine("isn't ascending.");
    }

    // تمرین 24: بررسی یکنواخت بودن ارقام عدد
    static void Exercise24()
    {
        Console.Write("Enter the number: ");
        string num = Console.ReadLine();
        bool allSame = true;
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] != num[0])
            {
                allSame = false;
                break;
            }
        }
        Console.WriteLine(allSame ? "All figures are equal." : "Figures are different.");
    }

    // تمرین 25: پیدا کردن تعداد اعداد اول کوچکتر از n
    static void Exercise25()
    {
        Console.Write("Enter the number N.: ");
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 2; i < n; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                count++;
        }
        Console.WriteLine("The number of prime numbers less than N: " + count);
    }

    // تمرین 26: محاسبه عدد فیبوناچی nام
    static void Exercise26()
    {
        Console.Write("Enter the number N. : ");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine("عضو " + n + " ام فیبوناچی: " + (n == 0 ? a : b));
    }

    // تمرین 27: نمایش n عدد اول فیبوناچی
    static void Exercise27()
    {
        Console.Write("Enter the number of Fibonacci members.: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1;
        Console.WriteLine(a);
        if (n > 1)
            Console.WriteLine(b);
        for (int i = 3; i <= n; i++)
        {
            int c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }

    // تمرین 28: بررسی عدد کامل
    static void Exercise28()
    {
        Console.Write("Enter the number: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < n; i++)
            if (n % i == 0)
                sum += i;
        Console.WriteLine(sum == n ? "is a whole number." : "The number is not whole.");
    }
}
