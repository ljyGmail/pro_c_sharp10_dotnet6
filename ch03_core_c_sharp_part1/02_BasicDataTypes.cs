class BasicDataTypes
{
    public static void LocalVarDeclarations()
    {
        Console.WriteLine("****** Fun with Basic Data Types *****");

        Console.WriteLine("=> Data Declarations:");
        // Local variables are declared as initialized as follows:
        // dataType varName = initialValue;
        int myInt = 0;

        // You can also declare and assign on two lines.
        string myString;
        myString = "This is my character data";

        // Declare 3 bools on a single line.
        bool b1 = true, b2 = false, b3 = b1;

        // Use System.Boolean data type to declare a bool.
        System.Boolean b4 = false;

        Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);

        Console.WriteLine();
    }

    public static void DefaultDeclarations()
    {
        Console.WriteLine("=> Default Declarations:");
        int myInt = default;
        Console.WriteLine(myInt);
    }
}