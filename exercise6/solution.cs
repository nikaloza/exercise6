using System;

class Program
{
    static int Add(int x, int y)          => x + y;
    static int Subtract(int x, int y)     => x - y;
    static int Multiply(int x, int y)     => x * y;
    static int Divide(int x, int y)       => x / y;
    static int Mod(int x, int y)          => x % y;

    static bool AndFunc(bool x, bool y)   => x && y;
    static bool OrFunc(bool x, bool y)    => x || y;
    static bool NotFunc(bool x)           => !x;

    static bool GreaterThan(int x, int y) => x > y;
    static bool LessEqual(int x, int y)   => x <= y;
    static bool Equal(int x, int y)       => x == y;

    static void Main()
    {
        int a = 5, b = 3, c = 7, d = 4, e = 2, f = 10;
        bool x = true, y = false, z = true, isAdmin = false;

        bool expected1 = (a + b * c) > (d - e) && x || y;
        bool actual1 =
            OrFunc(
                AndFunc(
                    GreaterThan(
                        Add(a, Multiply(b, c)),
                        Subtract(d, e)
                    ),
                    x
                ),
                y
            );
        Console.WriteLine($"Expected1: {expected1}, Actual1: {actual1}");


        bool expected2 = (a - b) * (c + d) <= e && z && !x;
        bool actual2 =
            AndFunc(
                AndFunc(
                    LessEqual(
                        Multiply(
                            Subtract(a, b),
                            Add(c, d)
                        ),
                        e
                    ),
                    z
                ),
                NotFunc(x)
            );
        Console.WriteLine($"Expected2: {expected2}, Actual2: {actual2}");

        bool expected3 = (a + b + c) % d == 0 || (f > e && isAdmin);
        bool actual3 =
            OrFunc(
                Equal(
                    Mod(
                        Add(Add(a, b), c),
                        d
                    ),
                    0
                ),
                AndFunc(
                    GreaterThan(f, e),
                    isAdmin
                )
            );
        Console.WriteLine($"Expected3: {expected3}, Actual3: {actual3}");

        bool expected4 = !(x || y) && (a * a > b * c);
        bool actual4 =
            AndFunc(
                NotFunc(
                    OrFunc(x, y)
                ),
                GreaterThan(
                    Multiply(a, a),
                    Multiply(b, c)
                )
            );
        Console.WriteLine($"Expected4: {expected4}, Actual4: {actual4}");
    }
}