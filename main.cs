using System;

class Program
{
    public static void Main(string[] args)
    {
        int X = 30; 
        
        for (int i = 1; i <= X; i++)
        {
            string output = i.ToString();
            
            if (i % 3 == 0 && i % 5 == 0)
            {
                output += " - FooBar";
            }
            else if (i % 3 == 0)
            {
                output += " - Foo";
            }
            else if (i % 5 == 0)
            {
                output += " - Bar";
            }
            
            Console.WriteLine(output);
        }
    }
}