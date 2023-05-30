class FunWithMethodParameters
{
    static FunWithMethodParameters()
    {
        Console.WriteLine("***** Fun with Method Parameters *****");
    }

    // Understanding the Default Parameter-Passing Behavior

    // The Default Behavior for Value Types

    // Value type arguments are passed by value by default.
    public static int Add(int x, int y)
    {
        int ans = x + y;
        // Caller will not see these changes
        // as you are modifying a copy of the
        // original data.
        x = 10000;
        y = 88888;
        return ans;
    }

    // The Default Behavior for Reference Types

    // Using the out Modifier (Updated 7.0)
    public static void AddUsingOutParam(int x, int y, out int ans)
    {
        ans = x + y;
    }

    // Returning multiple output parameters.
    public static void FillTheseValues(out int a, out string b, out bool c)
    {
        a = 9;
        b = "Enjoy your string";
        c = true;
    }

    /*
    public static void ThisWontCompile(out int a)
    {
        Console.WriteLine("Error! Forgot to assign output arg!");
    }
    */

    // Discarding out Parameters (New 7.0)

    // The out Modifier in Constructors and Initializers (New 7.3)

    // Using the ref Modifier

    // Reference parameters.
    public static void SwapStrings(ref string s1, ref string s2)
    {
        string tempStr = s1;
        s1 = s2;
        s2 = tempStr;
    }

    // Using the in Modifier (New 7.2)

    public static int Add2(int x, int y)
    {
        x = 10000;
        y = 88888;
        int ans = x + y;
        return ans;
    }

    public static int AddReadOnly(in int x, in int y)
    {
        // Error! Cannot assign to variable 'in int' because it is a readonly variable
        // x = 10000;
        // y = 88888;
        int ans = x + y;
        return ans;
    }

    public static double CalculateAverage(params double[] values)
    {
        Console.WriteLine("You sent me {0} double arguments.", values.Length);

        double sum = 0;
        if (values.Length == 0)
        {
            return sum;
        }
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        return (sum / values.Length);
    }

    public static void EnterLogData(string message, string owner = "Programmer")
    {
        Console.WriteLine("Error: {0}", message);
        Console.WriteLine("Owner of Error: {0}", owner);
    }

    /*
    // Error! The default value for an optional argument must be know at compile time!
    public static void EnterLogData(string message, string owner = "Programmer", DateTime timeStamp = DateTime.Now)
    {
        Console.WriteLine("Error: {0}", message);
        Console.WriteLine("Owner of Error: {0}", owner);
        Console.WriteLine("Time of Error: {0}", timeStamp);
    }
    */

    // Note: To avoid ambiguity, optional parameters must always be placed at the end of a method signature.

    public static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
    {
        // Store old colors to restore after message is printed.
        ConsoleColor oldTextColor = Console.ForegroundColor;
        ConsoleColor oldBackgroundColor = Console.BackgroundColor;
        // Set new colors and print message.
        Console.ForegroundColor = textColor;
        Console.BackgroundColor = backgroundColor;
        Console.WriteLine(message);
        // Restore previous colors.
        Console.ForegroundColor = oldTextColor;
        Console.BackgroundColor = oldBackgroundColor;
    }

    // Method overloading
    public static int Multiply(int x, int y)
    {
        return x * y;
    }

    public static int Multiply(int x, int y, int z = 5)
    {
        return x * y * z;
    }

    public static double Multiply(double x, double y)
    {
        return x * y;
    }

    public static long Multiply(long x, long y)
    {
        return x * y;
    }

    /*
    // These can not exist at the same time
    public static int Multiply(ref int x) { return 0; }
    public static int Multiply(out int x) { x = 0; return 0; }
    */

    // OK, if only one method uses in, ref, or out, the compiler can distinguish between the signatures.
    public static int Multiply(ref int x) { return 0; }
    public static int Multiply(int x) { return 0; }

    // Checking Parameters for Null (Updated 10.0)
    public static void EnterLogData2(string message, string owner = "Programmer")
    {
        /*
        if (message == null)
        {
            throw new ArgumentNullException(message);
        }
        */
        ArgumentNullException.ThrowIfNull(message);
        Console.WriteLine("Error: {0}", message);
        Console.WriteLine("Owner of Error: {0}", owner);
    }
}