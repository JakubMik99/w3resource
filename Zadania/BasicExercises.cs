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
        //10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z
        public string Zad10(int firstNumb, int secondNumb, int thirdNumb)
        {
            return $"Result of specifiednumbers {firstNumb}, {secondNumb} and {thirdNumb}, (x+y)*z is {(firstNumb+secondNumb)*thirdNumb}and x*y+y*z is{firstNumb*secondNumb+secondNumb*thirdNumb}";
        }
        //11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
        public string Zad11(byte age) => $"You look older than {age}";
        //12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times
        public void Zad12(int digit)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{digit}{digit}{digit}{digit}");
                Console.WriteLine($"{digit} {digit} {digit} {digit}");
            }
        }
        //13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit. 
        public void Zad13(int number)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i==0 || i==4)
                    Console.WriteLine($"{number}{number}{number}");
                else
                    Console.WriteLine($"{number} {number}");
                    
            }
        }
        //14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
        public void Zad14(int celsiusTemp)
        {
            Console.WriteLine($"Kelvin = {CelsToKel(celsiusTemp)}");
            Console.WriteLine($"Fahrenheit = {CelsToFahr(celsiusTemp)}");
        }
        private float CelsToKel(int celsius) => celsius+273.15f;
        private float CelsToFahr(int celsius) => celsius*(9/5)+32;
        //15. Write a C# program remove specified a character from a non-empty string using index of a character
        public string Zad15(string word, int indexToRemove)
        {
            if (!String.IsNullOrEmpty(word))
            {
                if (indexToRemove<0 || indexToRemove>=word.Length)
                    return word.Remove(indexToRemove,1);
                else
                    return "index out of boundary";
            }
            else
                return "string is empty";
                
        }
        //16. Write a C# program to create a new string from a given string where the first and last characters will change their positions.
        public string Zad16(string word)
        {
            if(String.IsNullOrEmpty(word))
                return "String is empty";
            else if(word.Length<2)
                return word;
            else
                return word[^1]+word[1..^1]+word[0];
        }
        //Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
        public string Zad17(string sentence) => sentence[0] + sentence + sentence[0];
        //18. Write a C# program to check two given integers and return true if one is negative and one is positive.
        public bool Zad18(int firstNumb, int secondNumb)
        => (IsPositive(firstNumb) && !IsPositive(secondNumb)) ^(!IsPositive(firstNumb) && IsPositive(secondNumb));
        private static bool IsPositive( int numb) => numb>=0;
        //19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
        public int Zad19(int firstVal, int secondVal) 
        => firstVal==secondVal ? 3*(firstVal+secondVal) : firstVal+secondVal;
        //20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number
        public int Zad20(int firstVal, int secondVal)
        =>firstVal> secondVal? 2*Math.Abs(firstVal-secondVal) :Math.Abs(firstVal-secondVal);
        //21. Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
        public bool Zad21(int firstVal, int secondVal)
        => firstVal==20 || secondVal==20 || firstVal+secondVal==20;
        //22. Write a C# program to check if an given integer is within 20 of 100 or 200. 
    }
}