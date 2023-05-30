Console.WriteLine("*****Chapter 4 Core C# Programming Constructs, Part 2******");

// FunWithArrays.SimpleArrays();
// FunWithArrays.ArrayInitialization();
// FunWithArrays.DeclareImplicitArrays();
// FunWithArrays.ArrayOfObjects();
// FunWithArrays.RectMultidimensionalArray();
// FunWithArrays.JaggedMultidimensionalArray();
// FunWithArrays.PassAndReceiveArrays();
// FunWithArrays.SystemArrayFunctionality();
// FunWithArrays.UsingIndicesAndRanges();

// FunWithMethods.Add(1, 2);

// Pass two variables in by value
// int x = 9, y = 10;
// Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
// Console.WriteLine("Answer is: {0}", FunWithMethodParameters.Add(x, y));
// Console.WriteLine("After call: X: {0}, Y: {1}", x, y);

// int ans;
// FunWithMethodParameters.AddUsingOutParam(90, 90, out ans);
// Console.WriteLine("Answer is {0}", ans);

// Starting with C# 7.0, out parameters do not need to be declared before using them.
// FunWithMethodParameters.AddUsingOutParam(90, 90, out int ans);
// Console.WriteLine("90 + 90 = {0}", ans);

// FunWithMethodParameters.FillTheseValues(out int i, out string str, out bool b);

// Console.WriteLine("Int is: {0}", i);
// Console.WriteLine("String is: {0}", str);
// Console.WriteLine("Boolean is: {0}", b);

// This only gets the value of a, and ignores the other two parameters.
// FunWithMethodParameters.FillTheseValues(out int a, out _, out _);
// Console.WriteLine($"The value of a is {a}");

// string str1 = "Flip";
// string str2 = "Flop";
// Console.WriteLine("Before: {0}, {1}", str1, str2);
// FunWithMethodParameters.SwapStrings(ref str1, ref str2);
// Console.WriteLine("After: {0}, {1}", str1, str2);

// Pass in a comma-delimited list of doubles...
// double average;
// average = FunWithMethodParameters.CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
// Console.WriteLine("Average of data is: {0}", average);
// .. or pass an array of doubles.
// double[] data = { 4.0, 3.2, 5.7 };
// average = FunWithMethodParameters.CalculateAverage(data);
// Console.WriteLine("Average of data is {0}", average);

// Average of 0 is 0!
// Console.WriteLine("Average of data is {0}", FunWithMethodParameters.CalculateAverage());

// Defining Optional Parameters
// FunWithMethodParameters.EnterLogData("Oh no! Grid can't find data");
// FunWithMethodParameters.EnterLogData("Oh no! I can't find the payroll data", "CFO");

// Using Named Arguments (Updated 7.2)
/*
FunWithMethodParameters.DisplayFancyMessage(message: "Wow! Very Fancy indeed!",
    textColor: ConsoleColor.DarkRed,
    backgroundColor: ConsoleColor.White);

FunWithMethodParameters.DisplayFancyMessage(backgroundColor: ConsoleColor.Green,
    message: "Testing...",
    textColor: ConsoleColor.DarkBlue);

// This is OK, as positional args are listed before named args.
FunWithMethodParameters.DisplayFancyMessage(ConsoleColor.Blue,
    message: "Testing...",
    backgroundColor: ConsoleColor.White);

// This is OK, all arguments are in the correct order.
FunWithMethodParameters.DisplayFancyMessage(textColor: ConsoleColor.White,
    backgroundColor: ConsoleColor.Blue,
    "Testing...");

// This is an ERROR, as positional args are listed after named args.
// FunWithMethodParameters.DisplayFancyMessage(message: "Testing...",
//     backgroundColor: ConsoleColor.White,
//     ConsoleColor.Blue);
*/

// Console.WriteLine("***** Fun with Method Overloading *****\n");

// Calls int version of Multiply()
// This will invoke Multipy(int x, int y) version, not Multipy(int x, int y, intz).
// Console.WriteLine(FunWithMethodParameters.Multiply(10, 10));

// Calls long version of Multiply() (using the new digit separator)
// Console.WriteLine(FunWithMethodParameters.Multiply(900_000_000_000, 900_000_000_000));

// Calls double version of Multiply()
// Console.WriteLine(FunWithMethodParameters.Multiply(4.3, 4.4));.

// FunWithEnums.Entry();

FunWithBitwiseOperations.Entry();