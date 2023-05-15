// Display a simple message to the user.
Console.WriteLine("***** My First C# App ****");
Console.WriteLine("Hello World!");
Console.WriteLine();
// Process any incoming args.
// for (int i = 0; i < args.Length; i++)
// {
//     Console.WriteLine("Arg: {0}", args[i]);
// }

// foreach (string arg in args)
// {
//     Console.WriteLine("Arg: {0}", arg);
// }
// Console.ReadLine();
// Console.WriteLine("========");

// Get arguments using System.Environment.
// string[] theArgs = Environment.GetCommandLineArgs();
// foreach (string arg in theArgs)
// {
//     Console.WriteLine("Arg: {0}", arg);
// }

// ShowEnvironmentDetails();

// Local method within the Top-level statements

static void ShowEnvironmentDetails()
{
    // Print out the drives on this machine,
    // and other interesting details.
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive: {0}", drive);
    }
    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
    Console.WriteLine(".NET Core Version: {0}", Environment.Version);
}

// Wait for Enter key to be pressed before shutting down.
// Console.ReadLine();

// BasicIO.GetUserData();
// BasicIO.FormatNumericalData();

// BasicDataTypes.LocalVarDeclarations();
// BasicDataTypes.DefaultDeclarations();
// BasicDataTypes.NewingDataTypes();
// BasicDataTypes.NewingDataTypesWith9();
// BasicDataTypes.ObjectFunctionality();
// BasicDataTypes.DataTypeFunctionality();
// BasicDataTypes.CharFunctionality();
// BasicDataTypes.ParseFromString();
// BasicDataTypes.ParseFromStringWithTryParse();
// BasicDataTypes.UseDatesAndTimes();
// BasicDataTypes.UseBigInteger();
// BasicDataTypes.DigitSeparators();
// BasicDataTypes.BinaryLiterals();

// FunWithStrings.BasicStringFunctionality();
// FunWithStrings.StringConcatenation();
// FunWithStrings.EscapeChars();
// FunWithStrings.StringInterpolationWithDefaultInterpolatedStringHandler();
// FunWithStrings.VerbatimStrings();
// FunWithStrings.StringEquality();
// FunWithStrings.StringEqualitySpecifyingCompareRules();
// FunWithStrings.StringsAreImmutable();
// FunWithStrings.StringsAreImmutable2();
FunWithStrings.FunWithStringBuilder();