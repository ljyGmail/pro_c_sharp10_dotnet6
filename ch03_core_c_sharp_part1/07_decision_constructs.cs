class DecisionConstructs
{
    static DecisionConstructs()
    {
        Console.WriteLine("***** Working with Decision Constructors and the Relational/Equality Operators *****");
    }

    public static void IfElseExample()
    {
        string stringData = "My textual data";
        if (stringData.Length > 0)
        {
            Console.WriteLine("string is greater than 0 characters");
        }
        else
        {
            Console.WriteLine("string is not greater than 0 characters");
        }
        Console.WriteLine();
    }

    public static void IfElsePatternMatching()
    {
        Console.WriteLine("===If Else Pattern Matching===");
        object testItem1 = 123;
        object testItem2 = "Hello";

        if (testItem1 is string myStringValue1)
        {
            Console.WriteLine($"{myStringValue1} is a string");
        }
        if (testItem1 is int myIntValue1)
        {
            Console.WriteLine($"{myIntValue1} is an int");
        }
        if (testItem2 is string myStringValue2)
        {
            Console.WriteLine($"{myStringValue2} is a string");
        }
        if (testItem2 is int myIntValue2)
        {
            Console.WriteLine($"{myIntValue2} is an int");
        }
        Console.WriteLine();
    }

    public static void IfElsePatternMatchingUpdatedInCSharp9()
    {
        Console.WriteLine("====== C# 9 If Else Pattern Matching Improments ======");
        object testItem1 = 123;
        Type t = typeof(string);
        char c = 'f';

        // Type patterns
        if (t is Type)
        {
            Console.WriteLine($"{t} is a Type");
        }

        // Relational, Conjuctve, and Disjunctive patterns
        if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
        {
            Console.WriteLine($"{c} is a character");
        }

        // Parenthesized patterns
        if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
        {
            Console.WriteLine($"{c} is a character or separator");
        }

        // Negative patterns
        if (testItem1 is not string)
        {
            Console.WriteLine($"{testItem1} is not a string");
        }

        if (testItem1 is not null)
        {
            Console.WriteLine($"{testItem1} is not null");
        }
        Console.WriteLine();
    }

    public static void ExecuteIfElseUsingConditionalOperator()
    {
        string stringData = "My textual data";
        Console.WriteLine(stringData.Length > 0
        ? "string is greater than 0 characters"
        : "string is not greater than 0 characters");
        Console.WriteLine();
    }

    public static void ConditionalRefExample()
    {
        var smallArray = new int[] { 1, 2, 3, 4, 5 };
        var largeArray = new int[] { 10, 20, 30, 40, 50 };

        int index = 7;
        ref int refValue = ref ((index < 5)
        ? ref smallArray[index]
        : ref largeArray[index - 5]);
        refValue = 0;

        index = 2;
        ((index < 5)
        ? ref smallArray[index]
        : ref largeArray[index - 5]) = 100;

        Console.WriteLine(string.Join(" ", smallArray));
        Console.WriteLine(string.Join(" ", largeArray));
    }

    // Switch on a numerical value.
    public static void SwitchExample()
    {
        Console.WriteLine("1 [C#], 2 [VB]");
        Console.Write("Please pick your language preference: ");

        string langChoice = Console.ReadLine();
        int n = int.Parse(langChoice);

        switch (n)
        {
            case 1:
                Console.WriteLine("Good choice, C# is a fine language.");
                break;
            case 2:
                Console.WriteLine("VB: OOP, multithreading, and more!");
                break;
            default:
                Console.WriteLine("Well...good luck with that!");
                break;
        }
    }

    public static void SwitchOnStringExample()
    {
        Console.WriteLine("C# or VB");
        Console.Write("Please pick your language preference: ");
        string langChoice = Console.ReadLine();
        switch (langChoice.ToUpper())
        {
            case "C#":
                Console.WriteLine("Good choice, C# is a fine language.");
                break;
            case "VB":
                Console.WriteLine("VB: OOP, multithreading and more!");
                break;
            default:
                Console.WriteLine("Well...good luck with that!");
                break;
        }
    }

    public static void SwitchOnEnumExample()
    {
        Console.Write("Enter your favorite day of the week: ");
        DayOfWeek favDay;
        try
        {
            favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Bad input!");
            return;
        }

        switch (favDay)
        {
            case DayOfWeek.Sunday:
                Console.WriteLine("Football!!");
                break;
            case DayOfWeek.Monday:
                Console.WriteLine("Another day, another dollar");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("At least it is not Monday");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("A fine day.");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Almost Friday...");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Yes, Friday rules!");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("Great day indeed.");
                break;
        }
        Console.WriteLine();
    }

    public static void SwitchWithGoto()
    {
        var foo = 5;
        switch (foo)
        {
            case 1:
                // do something
                Console.WriteLine("111");
                goto case 2;
            case 2:
                Console.WriteLine("222");
                // do something else
                break;
            case 3:
                Console.WriteLine("333");
                // yet another action
                goto default;
            default:
                Console.WriteLine("default");
                // default action
                break;
        }
    }

    public static void ExecutePatternMatchingSwitch()
    {
        Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
        Console.Write("Please choose an option: ");
        string userChoice = Console.ReadLine();
        object choice;
        // This is a standard constant pattern switch statement to set up the example
        switch (userChoice)
        {
            case "1":
                choice = 5;
                break;
            case "2":
                choice = "Hi";
                break;
            case "3":
                choice = 2.5M;
                break;
            default:
                choice = 5;
                break;
        }

        // This is the new pattern matching switch statement
        switch (choice)
        {
            case int i:
                Console.WriteLine("Your choice is an integer {0}.", i);
                break;
            case string s:
                Console.WriteLine("Your choice is a string {0}.", s);
                break;
            case decimal d:
                Console.WriteLine("Your choice is a decimal {0}.", d);
                break;
            default:
                Console.WriteLine("Your choice is something else.");
                break;
        }
        Console.WriteLine();
    }

    public static void ExecutePatternMatchingSwitchWithWhen()
    {
        Console.WriteLine("1 [C#], 2 [VB]");
        Console.Write("Please pick your language preference: ");

        object langChoice = Console.ReadLine();
        var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

        switch (choice)
        {
            case int i when i == 2:
            case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                Console.WriteLine("VB: OOP, multithreading, and more!");
                break;
            case int i when i == 1:
            case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                Console.WriteLine("Good choice, C# is a fine language.");
                break;
            default:
                Console.WriteLine("Well...good luck with that!");
                break;
        }
        Console.WriteLine();
    }

    // Using switch Expressions
    public static string FromRainbowClassic(string colorBand)
    {
        switch (colorBand)
        {
            case "Red":
                return "#FF0000";
            case "Orange":
                return "#FF7F00";
            case "Yellow":
                return "#FFFF00";
            case "Green":
                return "#00FF00";
            case "Blue":
                return "#0000FF";
            case "Indigo":
                return "#4B0082";
            case "Violet":
                return "#9400D3";
            default:
                return "#FFFFFF";
        }
    }

    // new switch expression in C# 8
    public static string FromRainbow(string colorBand)
    {
        return colorBand switch
        {
            "Red" => "#FF0000",
            "Orange" => "#FF7F00",
            "Yellow" => "#FFFF00",
            "Green" => "#00FF00",
            "Blue" => "#0000FF",
            "Indigo" => "#4B0082",
            "Violet" => "#9400D3",
            _ => "#FFFFFF",
        };
    }

    // Switch expression with Tuples
    public static string RockPaperScissors(string first, string second)
    {
        return (first, second) switch
        {
            ("rock", "paper") => "Paper wins.",
            ("rock", "scissors") => "Rock wins.",
            ("paper", "rock") => "Paper wins.",
            ("paper", "scissors") => "Scissors wins.",
            ("scissors", "rock") => "Rock wins.",
            ("scissors", "paper") => "Scissors wins.",
            (_, _) => "Tie.",
        };
    }
}