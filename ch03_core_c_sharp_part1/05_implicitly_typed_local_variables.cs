class ImplicitlyTypedLocalVars
{
    static ImplicitlyTypedLocalVars()
    {
        System.Console.WriteLine("***** Fun with Implicit Typing *****");
    }

    public static void DeclareExplicitVars()
    {
    }

    public static void DeclareImplicitVars()
    {
        // Implicitly typed local variables
        // are declared as follows:
        // var variableName = initialValue;
        var myInt = 0;
        var myBool = true;
        var myString = "Time, marches on...";

        // Print out the underly type.
        Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
        Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
        Console.WriteLine("myString is a: {0}", myString.GetType().Name);
    }

    public static void DeclareImplicitNumerics()
    {
        // Implicitly typed numeric variables.
        var myUInt = 0u;
        var myInt = 0;
        var myLong = 0L;
        var myDouble = 0.5;
        var myFloat = 0.5F;
        var myDecimal = 0.5M;

        // Print out the underlying type.
        Console.WriteLine("myUInt is a: {0}", myUInt.GetType().Name);
        Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
        Console.WriteLine("myLong is a: {0}", myLong.GetType().Name);
        Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
        Console.WriteLine("myFloat is a: {0}", myFloat.GetType().Name);
        Console.WriteLine("myDecimal is a: {0}", myDecimal.GetType().Name);
    }

    public static void ImplicitTypingIsStringTyping()
    {
        // The compiler knows "s" is a System.String.
        var s = "This variable can only hold string data!";
        s = "This is fine...";

        // Can invoke any member of the underlying type.
        string upper = s.ToUpper();

        // Error! Can't assign numerical data to a string!
        // s = 44;
    }

    public static void LinqQueryOverInts()
    {
        int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

        // LINQ query!
        var subset = from i in numbers where i < 10 select i;

        Console.Write("Value in subset: ");
        foreach (var i in subset)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();

        // Hmm... what type is subset?
        Console.WriteLine("subset is a: {0}", subset.GetType().Name);
        Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
    }
}

/*
class ThisWillNeverCompile
{
    // Error! var cannot be used as filed data!
    private var myInt = 10;

    // Error! var cannot be used as a return value
    // or parameter type!
    public var MyMethod(var x, var y) { }
}

// Error! Must assign a value!
var myData;

// Error! Must assign value at exact time of declation!
var myInt;
myInt = 0;

// Error! Can't assign null as initial value!
var myObj = null;

// OK, if SportsCar is a reference type!
var myCar = new SportsCar();
myCar = null;

// Also OK!
var myInt = 0;
var anotherInt = myInt;

string myString = "Wake up!";
var myData = myString;

static int GetAnInt()
{
    var retVal = 9;
    return retVal;
}
*/