using System;

public class Class1
{
	public Class1()
	{
        int numberOne = 0;int numberTwo = 1;int numberThree;

        Console.WriteLine("fibonocee series is follows:");
        Console.Write(numberOne + "," + numberTwo);
        while (numberTwo < 100)
        {
            numberThree = numberOne + numberTwo;//0+1
            Console.Write("," + numberThree);//1
            numberOne = numberTwo;
            numberTwo = numberThree;
            
        }
        Console.ReadKey();

	}
}
