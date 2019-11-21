using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous ?");
        var vacationType = Console.ReadLine();

        Console.WriteLine("How many are in your group");
        var groupSize = Convert.ToInt32(Console.ReadLine());
        var result = Console.ReadLine();

        if (vacationType == "musical" && groupSize <= 2)
        {
            result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take the first class to New Orleans";
        }

        if (vacationType == "tropical" && groupSize <= 5 && groupSize >= 3)
        {
            result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a helicopter to a Beach Vacation in Mexico";
        }

        if (vacationType == "adventurous" && groupSize <= 6)
        {
            result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a charter flight Whitewater Rafting the Grand Canyon";
        }
        Console.WriteLine(result);
    }
}
