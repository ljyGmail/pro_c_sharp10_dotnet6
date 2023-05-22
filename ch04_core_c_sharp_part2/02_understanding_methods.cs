class FunWithMethods
{
    static FunWithMethods()
    {
        Console.WriteLine("***** Fun with Methods *****");
    }

    // Recall that static methods can be called directly
    // without creating a class instance.
    // static returnType MethodName(parameter list) { /* Implementation */ }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    // Understanding Expression-Bodied Members
    public static int Add2(int x, int y) => x + y;

    // Understanding Local Functions (New 7.0, Updated 9.0)
    static int AddWrapper(int x, int y)
    {
        // Do some validation here
        return Add();

        int Add()
        {
            return x + y;
        }
    }

    /*
    #nullable enable
    private static void Process(string?[] lines, string mark)
    {
        foreach (var line in lines)
        {
            if (IsValid(line))
            {
                // Processing logic...
            }
        }

        bool IsValid([NotNullWhen(true)] string? line)
        {
            return !string.IsNullOrEmpty(line) && line.Length >= mark.Length;
        }
    }
    */

    // Understanding Static Local Functions (New 8.0)
    static int AddWrapperWithSideEffect(int x, int y)
    {
        // Do some validation here
        return Add();

        int Add()
        {
            x += 1;
            return x + y;
        }
    }

    static int AddWrapperWithStatic(int x, int y)
    {
        // Do some validation here
        return Add(x, y);

        static int Add(int x, int y)
        {

            return x + y;
        }
    }

}