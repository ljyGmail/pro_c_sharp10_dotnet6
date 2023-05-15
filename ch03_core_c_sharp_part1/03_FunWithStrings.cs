using System.Runtime.CompilerServices;
using System.Text;

class FunWithStrings
{
    public static void BasicStringFunctionality()
    {
        Console.WriteLine("=> Basic String Functionality:");

        string firstName = "Freddy";
        Console.WriteLine("Value of firstName: {0}", firstName);
        Console.WriteLine("firstName has {0} characters.", firstName.Length);
        Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
        Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
        Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
        Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
        Console.WriteLine();
    }

    public static void StringConcatenation()
    {
        Console.WriteLine("=> String concatenation:");
        string s1 = "Programming the ";
        string s2 = "PsychoDrill (PTP)";
        // string s3 = s1 + s2;
        string s3 = String.Concat(s1, s2);
        Console.WriteLine(s3);
        Console.WriteLine();
    }

    public static void EscapeChars()
    {
        Console.WriteLine("=> Escape character:");
        string strWithTabs = "Model\tColor\tSpeed\tPet Name";
        Console.WriteLine(strWithTabs);

        Console.WriteLine("Everyone loves \"Hello World\"");
        Console.WriteLine("C:\\MyApp\\bin\\Debug");

        // Adds a total of 4 blank lines (3 escaped, 1 from WriteLine)
        Console.WriteLine("All finished.\n\n\n");
        Console.WriteLine("");
        Console.WriteLine("End");

        // Adds 4 more blank lines.
        Console.WriteLine("All finished for real this time.{0}{0}{0}", Environment.NewLine);
    }

    public static void StringInterpolation()
    {
        Console.WriteLine("=> String interpolation:\a");

        // Some local variables we will plug into our larger string
        int age = 4;
        string name = "Soren";

        // Using curly-bracket syntax
        string greeting = string.Format("Hello {0}\t you are {1} years old.", name, age);
        Console.WriteLine(greeting);

        // Using string interpolation
        string greeting2 = $"Hello {name}\t you are {age} years old.";
        Console.WriteLine(greeting2);

        string greeting3 = $"Hello {name.ToUpper()}\t you are {age} years old.";
        Console.WriteLine(greeting3);
    }

    public static void StringInterpolationWithDefaultInterpolatedStringHandler()
    {
        Console.WriteLine("=> String interpolation under the covers:\a");
        int age = 4;
        string name = "Soren";

        var builder = new DefaultInterpolatedStringHandler(3, 2);
        builder.AppendLiteral("\tHello ");
        builder.AppendFormatted(name);
        builder.AppendLiteral(" you are ");
        builder.AppendFormatted(age);
        builder.AppendLiteral(" years old.");
        var greeting = builder.ToStringAndClear();
        Console.WriteLine(greeting);
    }

    public static void VerbatimStrings()
    {
        // The following string is pritned verbatim,
        // thus all escape characters are displayed.
        Console.WriteLine(@"C:\MyApp\bin\Debug");

        // Whitespace is preserved with verbatim strings.
        string myLongString = @"This a very
            very
                very
                    long string";
        Console.WriteLine(myLongString);

        // Directly insert a double quote by doubling the " token.
        Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");

        // Verbatim strings can also be interpolated strings
        string interp = "interpolation";
        string myLongString2 = $@"This a very
            very
                long string with {interp}";
        Console.WriteLine(myLongString2);

    }

    public static void StringEquality()
    {
        Console.WriteLine("=> String equality:");
        string s1 = "Hello!";
        string s2 = "Yo!";
        Console.WriteLine("s1 = {0}", s1);
        Console.WriteLine("s2 = {0}", s2);
        Console.WriteLine();

        // Test these strings for equality.
        Console.WriteLine("s1 == s2: {0}", s1 == s2);
        Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
        Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
        Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
        Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
        Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    }

    public static void StringEqualitySpecifyingCompareRules()
    {
        Console.WriteLine("=> String equality (Case Insensitive:)");
        string s1 = "Hello!";
        string s2 = "HELLO!";
        Console.WriteLine("s1 = {0}", s1);
        Console.WriteLine("s2 = {0}", s2);
        Console.WriteLine();

        // Check the results of changing the default compare rules.
        Console.WriteLine("Default rules: s1={0},s2={1} s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
        Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
        Console.WriteLine();
        Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
        Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
        Console.WriteLine();
    }

    public static void StringsAreImmutable()
    {
        Console.WriteLine("=> Immutable Strings:\a");
        // Set initial string value.
        string s1 = "This is my string.";
        Console.WriteLine("s1 = {0}", s1);

        // Uppercase s1?
        string upperString = s1.ToUpper();
        Console.WriteLine("upperString = {0}", upperString);

        // Nope! s1 is in the same format!
        Console.WriteLine("s1 = {0}", s1);
    }

    public static void StringsAreImmutable2()
    {
        Console.WriteLine("=> Immutable Strings 2:\a");
        string s2 = "My other string";
        s2 = "New string value";
        Console.WriteLine(s2);
    }

    public static void FunWithStringBuilder()
    {
        Console.WriteLine("=> Using the StringBuilder:");
        StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);
        sb.Append('\n');
        sb.AppendLine("Half Life");
        sb.AppendLine("Morrowid");
        sb.AppendLine("Deus Ex" + "2");
        sb.AppendLine("System Shock");
        Console.WriteLine(sb.ToString());
        sb.Replace("2", " Invisible War");
        Console.WriteLine(sb.ToString());
        Console.WriteLine("sb has {0} char.", sb.Length);
        Console.WriteLine();
    }
}