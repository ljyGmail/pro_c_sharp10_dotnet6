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
}