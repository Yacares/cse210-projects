using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction1 = new Fraction();
        Fraction myFraction2 = new Fraction();
        Fraction myFraction3 = new Fraction();

        myFraction1.SetTopValue(1);
        myFraction1.SetBottomValue(1);

        myFraction2.SetTopValue(6);
        myFraction2.SetBottomValue(1);

        myFraction3.SetTopValue(6);
        myFraction3.SetBottomValue(7);

        // Console.WriteLine(myFraction1.GetTopValue());
        // Console.WriteLine(myFraction1.GetBottomValue());
        // Console.WriteLine(myFraction2.GetTopValue());
        // Console.WriteLine(myFraction2.GetBottomValue());   
        // Console.WriteLine(myFraction3.GetTopValue());
        // Console.WriteLine(myFraction3.GetBottomValue());

        Console.WriteLine(myFraction1.GetFractionString());
        Console.WriteLine(myFraction1.GetDecimalValue());
        Console.WriteLine(myFraction2.GetFractionString());
        Console.WriteLine(myFraction2.GetDecimalValue());
        Console.WriteLine(myFraction3.GetFractionString());
        Console.WriteLine(myFraction3.GetDecimalValue());
    }
}


// public class Person
// {
//     private string _title;
//     private string _firstName;
//     private string _lastName;

//     public Person()
//     {
//         _title = "";
//         _firstName = "Anonymous";
//         _lastName = "Unknown";
//     }

//     public Person(string first, string last)
//     {
//         _title = "";
//         _firstName = first;
//         _lastName = last;
//     }

//     public Person(string title, string first, string last)
//     {
//         _title = title;
//         _firstName = first;
//         _lastName = last;
//     }
//     ...

// }