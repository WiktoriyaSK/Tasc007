int f(int n)
{
    if (n == 2) return 1;
    else if (n % 2 == 0) return f(n - 1) + f(n / 2);
    else return f(n - 1);
}

System.Console.WriteLine(f(10));