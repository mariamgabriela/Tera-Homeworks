using System.Reflection.Metadata.Ecma335;

class Mariami
{
    /*გამარჯობა, მე ვარ მარიამი,
     * ეს არის ჩემი პირველი დავალება
     * */

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, This is My firt Line!"); //ასე შემიძლია კომენტარის გაწერა
        Console.WriteLine();                             // ამით შემიძლია ცარიელი სტრიქონი გამოვიყვანო.
        Console.WriteLine("This is second line");



        /// <summary>
        /// ამ ფორმულით შემიძლია დავაკომენტარო მეთოდი
        /// </summary>
        static void secondmethod()
        {
            Console.WriteLine();
        }
    }

    
}
