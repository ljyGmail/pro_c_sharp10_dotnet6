class NarrowingWideningDataTypeConversions
{
    static NarrowingWideningDataTypeConversions()
    {
        Console.WriteLine("***** Fun with type conversions *****");
    }


    public static void Main()
    {
        // Add two shorts and print the result.
        // short numb1 = 9, numb2 = 10;
        // Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));

        // Compile error below!
        // short numb1 = 30000, numb2=30000;
        // short answer = Add(numb1, numb2);
        // Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));

        // Explicitly cast the int into a short (and allow loss of data).
        short numb1 = 30000, numb2 = 30000;
        short answer = (short)Add(numb1, numb2);

        Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);

        NarrowingAttempt();
    }

    static int Add(int x, int y)
    {
        return x + y;
    }

    // Another compiler error!
    public static void NarrowingAttempt()
    {
        // byte myByte = 0;
        // int myInt = 200;
        // myByte = myInt;

        // Console.WriteLine("Value of myByte: {0}", myByte);

        byte myByte = 0;
        int myInt = 200;
        // Explicitly cast the int into a byte (no loss of data)
        myByte = (byte)myInt;

        Console.WriteLine("Value of myByte: {0}", myByte);
    }

    public static void ProcessBytes()
    {
        byte b1 = 100;
        byte b2 = 250;
        byte sum = (byte)Add(b1, b2);

        // sum should hold the vaue 350. However, we find the value 94!
        Console.WriteLine("sum = {0}", sum);
    }

    public static void ProcessBytes2()
    {
        byte b1 = 100;
        byte b2 = 250;

        // This time, tell the compiler to add CIL code
        // to throw an exception if overflow/underflow
        // takes place.
        try
        {
            byte sum = checked((byte)Add(b1, b2));
            Console.WriteLine("sum = {0}", sum);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void ProcessBytes3()
    {
        byte b1 = 100;
        byte b2 = 250;
        try
        {
            checked
            {
                byte sum = (byte)Add(b1, b2);
                Console.WriteLine("sum = {0}", sum);
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}