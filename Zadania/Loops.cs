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
        public void Zad4(int length)
        {
            int value, sum=0, average=0;
            if (length>=1)
            {
                for (int i = 0; i < length ; i++)
                {
                    value = Parsing.ParsowanieInt($"Number {i+1}: ");
                    value +=sum;
                }
                average = sum/length;
                Console.WriteLine($"Sum {sum} \nAverage {average}");
            }
            else
            {
                Console.WriteLine($"Wrong length");
            }
            
        }
        //5. Write a program in C# Sharp to display the cube of the number up to given an integer.
        public string Zad5(int number) => $"Number is {number} and cufe of it is {Math.Pow(number,3)}";
        //6. Write a program in C# Sharp to display the multiplication table of a given integer.
        public void Zad6(int value)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{value}X{i}={value*i}");
            }
        }
        //7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n
        public void Zad7(int value)
        {
            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= value; i++)
                {
                    Console.WriteLine($"{j}X{i}={j*i}");
                }
            }
        }
        //8. Write a program in C# Sharp to display the n terms of odd natural number and their sum
        public void Zad8(int howManyOdds)
        {
            int counter =0,oddVal=1,sum=0;
                Console.Write($"Odd numbers are: ");
            do
            {
                Console.Write($"{oddVal} ");
                sum +=oddVal;
                oddVal+=2;
                counter++;
                
            } while (counter<howManyOdds);
            Console.WriteLine($"\nSum of them equals {sum}");
            
        }
        //9. Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk
        public void Zad9(int length)
        {
            int asteriskCount=1;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < asteriskCount; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
                asteriskCount++;
            }
        }
        //10. Write a program in C# Sharp to display the pattern like right angle triangle with a number.
        public void Zad10(int length)
        {
            int valueCount=1;

            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j <= valueCount; j++)
                {
                    Console.Write(j);
                }
                valueCount++;
                Console.WriteLine();
            }
        }
        //11. Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row
        public void Zad11(int length)
        {
            int valueCount=1;

            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= valueCount; j++)
                {
                    Console.Write(i);
                }
                valueCount++;
                Console.WriteLine();
            }
        }
        //12. Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1.
        public void Zad12(int length)
        {
            int valueCount=1, counter=1;

            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= valueCount; j++)
                {
                    Console.Write($"{counter++} ");
                }
                valueCount++;
                Console.WriteLine();
            }
        }
        //13. Write a program in C# Sharp to make such a pattern like a pyramid with numbers increased by 1.
        public void Zad13(int length)
        {
            int spaceCounter =length, value =1;
            for (int i = 1; i <= length; i++)
            {
                for (int j = 0; j < spaceCounter; j++)
                {
                    Console.Write(" ");
                }
                spaceCounter--;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{value++} ");
                }
                Console.WriteLine();
                
            }
        }
        //14. Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.
        public void Zad14(int length)
        {
            int spaceCounter =length;
            for (int i = 1; i <= length; i++)
            {
                for (int j = 0; j < spaceCounter; j++)
                {
                    Console.Write(" ");
                }
                spaceCounter--;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }
        }
        //15. Write a C# Sharp program to calculate the factorial of a given number.
        public int Zad15(int value)
        {
            int factorial=1;
            for (int i = 1; i <= value; i++)
            {
                factorial*=i;
            }
            return factorial;
        }
        //16. Write a program in C# Sharp to display the n terms of even natural number and their sum.
        public void Zad16(int howManyEvens)
        {
            int counter =0,evenVal=0,sum=0;
                Console.Write($"Even numbers are: ");
            do
            {
                Console.Write($"{evenVal} ");
                sum +=evenVal;
                evenVal+=2;
                counter++;
                
            } while (counter<howManyEvens);
            Console.WriteLine($"\nSum of them equals {sum}");
        }
        //17. Write a program in C# Sharp to make such a pattern like a pyramid with a number which will repeat the number in the same row. 
        public void Zad17(int length)
        {
            int spaceCounter =length;
            for (int i = 1; i <= length; i++)
            {
                for (int j = 0; j < spaceCounter; j++)
                {
                    Console.Write(" ");
                }
                spaceCounter--;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
        //19. Write a program in C# Sharp to display the n terms of harmonic series and their sum
        public void Zad19(decimal value)
        {
            decimal sum =0;
            for (int i = 1; i <= value; i++)
            {
                Console.Write($"1/{i} + ");
                sum += 1/i;
            }
            Console.WriteLine($"Sum of series upto {value} terms: {sum}");
            
        }
        //21. Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
        public double Zad21(int series)
        {
            double sum =0, value=9;
            for (int i = 0; i < series; i++)
            {
                sum+=value;
                value= (value*10)+9;
            }
            return sum;
        }
        //27. Write a C# Sharp program to check whether a given number is perfect number or not.
        public bool Zad27(int value)
        {
            int sum=0;
            for (var i = 1; i <= (value/2)+1; i++)
            {
                if (value%i==0)
                {
                    sum+=i;
                }
            }
            return sum!=1 &&sum==value;
        }
        //28. Write a C# Sharp program to find the perfect numbers within a given range of number.
        public void Zad28(int start, int finish)
        {
            for (var i = start; i <= finish; i++)
            {
                if(Zad27(i))
                {
                Console.Write($"{i} ");
                }
            }
        }
        //29. Write a C# Sharp program to check whether a given number is an Armstrong number or not.
        public bool Zad29(int value)
        {
            int armstrong=0, valueCopy=value;
            do
            {
                armstrong+= (int)Math.Pow(value%10,3);
                value/=10;
            } while (value>0);
            return armstrong == valueCopy;
        }
        //30. Write a C# Sharp program to find the Armstrong number for a given range of number.
        public void Zad30(int start, int finish)
        {
            for (var i = start; i <= finish; i++)
            {
                if (Zad29(i))
                {
                    Console.WriteLine($"{i} ");
                }
            }
        }
        //32. Write a C# Sharp program to determine whether a given number is prime or not. ==> IsPrime in BasicExercises
        //34. Write a program in C# Sharp to find the prime numbers within a range of numbers.
        public void Zad34(int start, int finish)
        {
            BasicExercises BE = new BasicExercises();
            Console.WriteLine($"Prime numbers between {start} and {finish} are:");
            
            for (var i = start; i <= finish; i++)
            {
                
                if (BE.IsPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
        //35. Write a program in C# Sharp to display the first n terms of Fibonacci series.
        public int Fib(int whichNumber)
        {

            int x1=1,x2=1, counter =2, temp;
            if (whichNumber<3)
            {
                return x1;
            }
            else
            {
                do
                {
                    temp = x1;
                    x1=x2;
                    x2 = temp+x2;
                    counter++;
                } while (counter<whichNumber);
            }
            return x2;
        }
        public void Zad35(int howMany)
        {
            for (var i = 0; i < howMany; i++)
            {
                Console.Write($"{Fib(i)} ");
            }
        }
        //37. Write a program in C# Sharp to display the number in reverse order.
        public int Zad37(int value)
        {
            int reversed=0;
            do
            {
                reversed*=10;
                reversed+=value%10;
                value/=10;
                
            } while (value>0);
            return reversed;
            // or int.Parse(value.ToString().Reverse());
        }
        //38. Write a program in C# Sharp to check whether a number is a palindrome or not.
        public bool Zad38(int value)
        {
            string word = value.ToString();
          for (int i = 0; i < word.Length/2; i++)
          {
            if(word[i]!=word[^(i+1)])
                return false;
          }  
          return true;
        }    
        //39. Write a program in C# Sharp to find the number and sum of all integer between 100 and 200 which are divisible by 9.
        public void Zad39(int lower, int upper, int divisibleBy)
        {
            if (upper>lower)
            {
                    int sum=0;
                for (var i = lower; i < upper; i++)
                {
                    if (i%divisibleBy==0)
                    {
                        Console.Write($"{i} ");
                        sum+=i;
                    }
                }
                Console.WriteLine($"Sum: {sum}");
            }
            else
                Console.WriteLine($"upper boundry must be greater than lower");
        }
        //43. Write a C# Sharp program to find HCF (Highest Common Factor) of two numbers.
        public int Zad43(int firstVal, int secondVal)
        {
            int min = Math.Min(firstVal,secondVal);
            for (var i = min; i >0; i--)
            {
                if (firstVal%i==0 && secondVal%i==0)
                    return i;
            }
            return -1;
        } 
        //44. Write a program in C# Sharp to find LCM of any two numbers.
        public int Zad44(int firstVal, int secondVal)
        {
            int max=Math.Max(firstVal,secondVal);
            for (var i = max; i <= firstVal*secondVal; i++)
            {
                if (i%firstVal==0 && i%secondVal==0)
                    return i;
            }
            return -1;
        }   
        //Zad15 47. Write a C# Sharp program to check whether a number is a Strong Number or not.
        public bool Zad47(int val)
        {
            int sum=0, valCopy= val;
            do
            {
                sum += Zad15(val%10);
                val/=10;
            } while (val>0);
            return valCopy==sum;
        }
        //48. Write a C# Sharp program to find Strong Numbers within a range of numbers.
        public void Zad48(int lower, int upper)
        {
            if (upper>lower)
            {
                
                for (var i = lower; i < upper; i++)
                {
                 if(Zad47(i))
                    Console.Write($"{i} ");
                       
                }
            }
        }
        //49. Write a C# Sharp program to find out the sum of in A.P. series.
        public int Zad49(int start, int numberOfValues, int diff)
        {
            int sum=0;
            for (var i = 0; i < numberOfValues; i++)
            {
                sum+=start;
                start+=diff;
            }
            return sum;
        }
       //52. Write a program in C# Sharp to find the Sum of GP series
        public int Zad52(int start, int numberOfValues, int ratio)
        {
                        int sum=0;
            for (var i = 0; i < numberOfValues; i++)
            {
                sum+=start;
                start*=ratio;
            }
            return sum;
        }










    }
}