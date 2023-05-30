class FunWithEnums
{
    static FunWithEnums()
    {
        Console.WriteLine("***** Fun with Enums *****");
    }

    public static void Entry()
    {
        // Make an EmpTypeEnum variable.
        EmpTypeEnum emp = EmpTypeEnum.Contractor;
        AskForBonus(emp);

        // Print storage for the enum.
        Console.WriteLine("EmpTypeEnum uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
        // This time use typeof to extract a Type.
        Console.WriteLine("EmpTypeEnum uses a {0} for storage", Enum.GetUnderlyingType(typeof(EmpTypeEnum)));

        // Prints out "emp is a Contractor"
        Console.WriteLine("emp is a {0}", emp.ToString());

        // Prints out "Contractor = 2".
        Console.WriteLine("{0} = {1}", emp.ToString(), (int)emp);

        // These types are enums in the System namespace.
        DayOfWeek day = DayOfWeek.Monday;
        ConsoleColor cc = ConsoleColor.Gray;

        EvaluateEnum(emp);
        EvaluateEnum(day);
        EvaluateEnum(cc);
    }

    private static void AskForBonus(EmpTypeEnum e)
    {
        switch (e)
        {
            case EmpTypeEnum.Manager:
                Console.WriteLine("How about stock options instead?");
                break;
            case EmpTypeEnum.Grunt:
                Console.WriteLine("You have got to be kidding...");
                break;
            case EmpTypeEnum.Contractor:
                Console.WriteLine("You already get enough cash...");
                break;
            case EmpTypeEnum.VicePresident:
                Console.WriteLine("VERY GOOD, Sir!");
                break;
        }
    }

    /*
    static void ThisMethodWillNotCompile()
    {
        // Error! SalesManager is not in the EmpTypeEnum enum!
        EmpTypeEnum emp = EmpTypeEnum.SalesManager;

        // Error! Forgot to scope Grunt value to EmpTypeEnum enum!
        emp = Grunt;
    }
    */

    // This method will print out the details of any enum.
    public static void EvaluateEnum(System.Enum e)
    {
        Console.WriteLine("=> Information about {0}", e.GetType().Name);

        Console.WriteLine("Underlying storage stype: {0}", Enum.GetUnderlyingType(e.GetType()));

        // Get all name-value pairs for incoming parameter.
        Array enumData = Enum.GetValues(e.GetType());
        Console.WriteLine("This enum has {0} members.", enumData.Length);

        // Now show the string name and associated value, using the D format
        // flag (see Chapter 3)
        for (int i = 0; i < enumData.Length; i++)
        {
            Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
        }
    }
}

enum EmpTypeEnum
{
    Manager, // = 0
    Grunt, // = 1
    Contractor, // = 2
    VicePresident // = 3
}

/*
// Begin with 102.
enum EmpTypeEnum
{
    Manager = 102,
    Grunt, // = 103
    Contractor, // = 104
    VicePresident // = 105
}
*/

/*
// Elements of an enumeration need not be sequential!
enum EmpTypeEnum
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9
}
*/

/*
// This time, EmpTypeEnum maps to an underlying byte.
enum EmpTypeEnum : byte
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9
}
*/

/*
// Compile-time error! 999 is too big for a byte!
enum EmpTypeEnum : byte
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 999
}
*/