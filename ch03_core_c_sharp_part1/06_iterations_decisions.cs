class IterationsAndDecisions
{
    static IterationsAndDecisions()
    {
        Console.WriteLine("***** Iterations and Decisions *****");
    }

    // A basic for loop.
    public static void ForLoopExample()
    {
        // Note! "i" is only visible within the scope of the for loop.
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Number is: {0}", i);
        }
        // "i" is not visible here.
    }

    // Iterator array items using foreach.
    public static void ForEachLoopExamle()
    {
        string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };

        foreach (string c in carTypes)
        {
            Console.WriteLine(c);
        }

        int[] myInts = { 10, 20, 30, 40 };

        foreach (int i in myInts)
        {
            Console.WriteLine(i);
        }
    }

    public static void LinqQueryOverInts()
    {
        int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

        // LINQ query!
        var subset = from i in numbers where i < 10 select i;
        Console.WriteLine("Values in subset: ");

        foreach (var i in subset)
        {
            Console.WriteLine("{0} ", i);
        }
    }

    public static void WhileLoopExample()
    {
        // string userIsDone = "";
        // // Test on a lower-class copy of the string.
        // while (userIsDone.ToLower() != "yes")
        // {
        //     Console.WriteLine("In while loop");
        //     Console.Write("Are you done? [yes] [no]: ");
        //     userIsDone = Console.ReadLine();
        // }
        int i = 0;
        int sum = 0;
        while (i <= 100)
        {
            sum += i;
            i++;
        }
        Console.WriteLine("Add 1 to 100 is: {0}", sum);
    }

    public static void DoWhileLoopExample()
    {
        // string userIsDone = "";

        // do
        // {
        //     Console.WriteLine("In do/while loop");
        //     Console.Write("Are you done? [yes] [no]: ");
        //     userIsDone = Console.ReadLine();
        // } while (userIsDone.ToLower() != "yes"); // Note the semicolon!
        int i = 0;
        int sum = 0;
        do
        {
            sum += i;
            i++;
        } while (i <= 100);
        Console.WriteLine("Add 1 to 100 is (do-while): {0}", sum);
    }
}