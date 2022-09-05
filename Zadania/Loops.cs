namespace Zadania
{
    public class Loops
    {
        //1. Write a program in C# Sharp to display the first 10 natural numbers.
        public void Zad1(int length)
        {
            if (length>=0)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write($"{i} ");
                }
            }
        }
        //2. Write a C# Sharp program to find the sum of first 10 natural numbers
        public int Zad2(int length)
        {
            int sum=0;
            if(length>=0)
            {
                for (int i = 0; i < length; i++)
                {
                    sum+=i;
                }
            }
            return sum;
        }
        //3. Write a program in C# Sharp to display n terms of natural number and their sum.
        public void Zad3(int length)
        {
            Zad1(length);
            Console.WriteLine($"Sum of them equals {Zad2(length)}");
        }
        //4. Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
        public void Zad4()
        {
            for (int i = 0; i < ; i++)
            {
                
            }
        }














    }
}