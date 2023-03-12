using System;

class Homework3
{
  
    static void Main(string[] args)
    {
        Console.WriteLine();

        //დავალება 1
        //შევქმნათ ცვლადები და  კონსოლში გამოვიყვანოთ x+z*y
        Console.WriteLine("Task 1:");

        int x = 5;
        int z = 8;
        int y = 10;

        int sum = x + z * y;
        Console.WriteLine("x=5, z=8, y=10");
        Console.Write("x + z * y = ");
        Console.WriteLine(sum);
        Console.WriteLine();

        //დავალება 2
        //პროგრამამ მომხმარებელს უნდა შესთავაზოს სახელის, გვარის, ასაკის, სიმაღლის და წონის შეყვანა.
        //შემდეგ მოცემული მონაცემები გამოვიყვამოთ კონსოლში
        Console.WriteLine("Task 2: ");

        Console.Write("Please, enter your name: ");   //სახელი
        string name = Console.ReadLine();

        Console.Write("Please, enter your surname: "); //გვარი
        string surname = Console.ReadLine();

        Console.Write("Please, enter your age: ");  //ასაკი
        int age =Int32.Parse(Console.ReadLine());

        Console.Write("Please, enter your height in Meters: "); //სიმაღლე
        float height = float.Parse(Console.ReadLine());

        Console.Write("Please, enter your weigt in KG: ");
        float weight = float.Parse(Console.ReadLine()); //წონა

        Console.WriteLine();
        Console.WriteLine(name + " " + surname + " " + age + " " + height + " " + weight);
        Console.WriteLine();

        //დავალება 3
        //უნდა გამოვიყვანოთ BMI (Body Mass Index) ფორმულა
        //BMI ფორმულა  = weigth kg /height(2) meter

        Console.WriteLine("Task 3: ");

        Console.Write("Your BMI is:");
        Console.WriteLine(weight / ((height)*(height))); 
        Console.WriteLine();

        // დავალება 4

        Console.WriteLine("Task 4: ");

        Console.WriteLine();
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" 1 | 2 | 3 ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" 4 | 5 | 6 ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" 7 | 8 | 9 ");
        Console.WriteLine("   |   |   ");
    }


}
