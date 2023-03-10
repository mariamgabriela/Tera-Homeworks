class Homework3
{
  
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        //დავალება 1
        //შევქმნათ ცვლადები და  კონსოლში გამოვიყვანოთ x+z*y
        
        int x = 5;
        int z = 8;
        int y = 10;

        int sum = x + z * y;
        Console.WriteLine(sum);
        Console.WriteLine();

        //დავალება 2
        //პროგრამამ მომხმარებელს უნდა შესთავაზოს სახელის, გვარის, ასაკის, სიმაღლის და წონის შეყვანა.
        //შემდეგ მოცემული მონაცემები გამოვიყვამოთ კონსოლში

        Console.Write("Please, enter your name: ");   //სახელი
        string name = Console.ReadLine();

        Console.Write("Please, enter your surname: "); //გვარი
        string surname = Console.ReadLine();

        Console.Write("Please, enter your age: ");  //ასაკი
        int age =Int32.Parse(Console.ReadLine());

        Console.Write("Please, enter your height: "); //სიმაღლე
        int height = Int32.Parse(Console.ReadLine());

        Console.Write("Please, enter your weigt: ");
        float weight = float.Parse(Console.ReadLine()); //წონა

        Console.WriteLine();
        Console.WriteLine(name + " " + surname + " " + age + " " + height + " " + weight);

        //დავალება 3
        //უნდა გამოვიყვანოთ BMI (Body Mass Index) ფორმულა

        Console.WriteLine();
        //BMI ფორმულა  = weigth kg /height(2) meter

        Console.WriteLine(weight / ((height/100) * 2 ));

    }

   
}
