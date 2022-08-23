namespace Zadania
{
    public class BasicExercises
    {
        //1. Write a C# Sharp program to print Hello and your name in a separate line
        public void Zad1(string imie, string nazwisko)
        {
            Console.WriteLine($"Hello {imie} {nazwisko}");
        }
        //2. Write a C# Sharp program to print the sum of two numbers
        public void Zad2(int firstDig, int secondDig)
        {
            Console.WriteLine($"{firstDig}+{secondDig}={firstDig+secondDig}");
        }
        //3. Write a C# Sharp program to print the result of dividing two numbers.
        public void Zad3(float firstDig, float secondDig)
        {
            Console.WriteLine($"{firstDig}/{secondDig}={firstDig/secondDig}");
        }
        //4. Write a C# Sharp program to print the result of the specified operations       
        public void Zad4()
        {
            Console.WriteLine(-1 + 4 * 6 );
            Console.WriteLine(( 35+ 5 ) % 7 );
            Console.WriteLine(14 + -4 * 6 / 11 );
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2  );
        }
        //5. Write a C# Sharp program to swap two numbers.
        public void Zad5(ref int firstNumb,ref int secondNumb)
        {
            int temp = firstNumb;
            firstNumb = secondNumb;
            secondNumb = temp;
        }
        //6. Write a C# Sharp program to print the output of multiplication of three numbers 
        public void Zad6(int firstNumb, int secondNumb,int thirdNumb)
        {
            System.Console.WriteLine($"{firstNumb}X{secondNumb}X{thirdNumb}={firstNumb*secondNumb*thirdNumb}");
        }
        //7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers
        public void Zad7(int firstNumb, int secondNumb)
        {
            System.Console.WriteLine($"{firstNumb}+{secondNumb}={firstNumb+secondNumb}");
            System.Console.WriteLine($"{firstNumb}-{secondNumb}={firstNumb-secondNumb}");
            System.Console.WriteLine($"{firstNumb}X{secondNumb}={firstNumb*secondNumb}");
            System.Console.WriteLine($"{firstNumb}/{secondNumb}={firstNumb/secondNumb}");
            System.Console.WriteLine($"{firstNumb}mod{secondNumb}={firstNumb%secondNumb}");
        }
        //8. Write a C# Sharp program that takes a number as input and print its multiplication table
        public void Zad8(int numbToMultiply)
        {
            for (int i = 0; i < 11; i++)
                System.Console.WriteLine($"{numbToMultiply}X{i}={numbToMultiply*numbToMultiply}");
        }
        //9. Write a C# Sharp program that takes four numbers as input to calculate and print the average
        public float Zad9(int[] tab)
        {
            int suma=0;
            float avg = 0;
            foreach(int item in tab)
            {
                suma+=item;
            }
            avg = suma/tab.Length;
            return tab.Length<=0 ? float.MinValue :avg; 
            
        }


    }
}