using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List <string> words = new List<string>();
        List <int> numbers = new List<int>();
        int total = 0;
        
        Console.WriteLine("Enter your numbers individually. Enter 0 when you are done.");
        
        while(true) 
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out int number)){
                if (number == 0){
                    break;
                }
                numbers.Add(number);
            }
            else{
                Console.WriteLine("Please enter an integer.");
            }
        }
        if (numbers.Count > 0){
            int lowest = numbers[0];
            int highest = numbers[0];

            foreach (int num in numbers){
                
                total += num;
                
                if (num > highest) highest = num;
                if (num < lowest || lowest > 0) lowest = num;
            } 

            double average = (double)total / numbers.Count;
            Console.WriteLine($"The total is {total}");
            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The highest value is {highest}");
            Console.WriteLine($"The lowest value is {lowest}");
        }
        else{
            Console.WriteLine("No numbers were entered.");
        }
    }
    
}