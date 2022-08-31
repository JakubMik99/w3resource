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
        public bool Zad22(int value) => IsBetween(value,80,120) || IsBetween(value,180,220);
        public bool IsBetween(int value, int lowerBoundry, int highierBoundry) => value<=highierBoundry && value >=lowerBoundry; 
        //23. Write a C# program to convert a given string into lowercase.
        public string Zad23(string sentence) => sentence.ToLower();
        //24. Write a C# program to find the longest word in a string.
        public string Zad24(string sentence)
        {
            int index=0, maxWordLength=0;
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length>maxWordLength)
                {
                    index= i;
                    maxWordLength= words[i].Length;
                }
            }
            return words[index];
        }
        //25. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line
        public void Zad25()
        {
            for (int i = 1; i <= 100; i+=2)
                Console.WriteLine(i);
        }
        //26. Write a C# program to compute the sum of the first 500 prime numbers.
        public int Zad26()
        {
            int counter=0, sumOfPrimes=0;

          for (int i = 0; counter < 500; i++)
          {
            if (IsPrime(i))
            {
                counter++;
                sumOfPrimes+=i;
            }
          }      
          return sumOfPrimes;
        }
        private bool IsPrime(int value)
        {
            if (value<2)
                return false;
            else if(value==2)
                return true;
            for (int i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value%i==0)
                {
                    return false;
                }                
            }
            return true;
        }
        //27. Write a C# program and compute the sum of the digits of an integer.
        public int Zad27(int value)
        {
            int sumOfDigits=0;
            do
            {
                sumOfDigits+=value%10;
                value/=10;
            } while (value>0);
            return sumOfDigits;
        }
        //28. Write a C# program to reverse the words of a sentence.
        public string Zad28(string sentence)
        {
            string[] words = sentence.Split(' ');
            return string.Join(' ', words.Reverse());
        }
        //29. Write a C# program to find the size of a specified file in bytes. 
        public void Zad29(string fileName)
        {
            FileInfo file = new FileInfo(fileName);
            Console.WriteLine($"size of the file is: {file.Length}");
        }
        //30. Write a C# program to convert a hexadecimal number to decimal number.
        public int Zad30(string hexNumb)
        {
            return Convert.ToInt32(hexNumb,16);
            
        }
        //31. Write a C# program to multiply corresponding elements of two arrays of integers.
        public int[] Zad31(int[]tab1, int[]tab2)
        {
            int[] sum;
            if(tab1.Length==tab2.Length)
            {
                sum = new int[tab1.Length];
                for (int i = 0; i < tab1.Length; i++)
                {
                    sum[i] = tab1[i]*tab2[i];
                }
                return sum;
            }
            return tab1;
        }
        //32. Write a C# program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one.
        public string Zad32(string sentence)
        {
            string lastPart="";
            if (sentence.Length<4)
                return $"{sentence}{sentence}{sentence}{sentence}";
            else
            {
                lastPart= sentence[^4..];
                return $"{lastPart}{lastPart}{lastPart}{lastPart}";
            }
        }
        //33. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7
        public bool Zad33(int value)
        {
            return IsPositive(value)? (value%3==0 || value%7==0):false;
        }
        //34. Write a C# program to check if a string starts with a specified word. 
        public bool Zad34(string sentence, string startsWith)=> sentence.StartsWith(startsWith);
        //35. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
        public bool Zad35(int firstVal, int secondVal)=>(firstVal<100 && secondVal>200) ^ (secondVal<100 && firstVal>200);
        //36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
        public bool Zad36(int firsVal, int secondVal) => IsBetween(firsVal,-10,10) || IsBetween(secondVal,-10,10);
        //37. Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP"
        public string Zad37(string sentence)
        {
            if(!(sentence.Length<3))
            {
                if (sentence[1..3]=="HP")
                {
                return sentence.Remove(1,2);
                }
                else
                {
                return sentence;
                }
            }
                return sentence;
        }
        //38. Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH".
        public string Zad38(string sentence)
        {
            return sentence.StartsWith("PH")? sentence.Remove(2): sentence;
        }
        //39. Write a C# program to find the largest and lowest values from three integer values. 
        public void Zad39(int firstVal, int secondVal, int thirdVal)
        {
            int lowest = Math.Min(firstVal,Math.Min(secondVal,thirdVal));
            int largest = Math.Max(firstVal,Math.Max(secondVal,thirdVal));
            Console.WriteLine($"Lowest value: {lowest}\nLargest value: {largest}");
            
        }
        //40. Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same. 
        public int Zad40(int firstVal, int secondVal, int thirdVal)
        {
            if (firstVal==secondVal || secondVal==thirdVal || firstVal==thirdVal)
            {
                return 0;
            }
            else
            {
                if (Math.Abs(firstVal-20)<Math.Abs(secondVal-20) && Math.Abs(firstVal-20)<Math.Abs(thirdVal-20))
                    return firstVal;
                else if (Math.Abs(secondVal-20)<Math.Abs(firstVal-20) && Math.Abs(secondVal-20)<Math.Abs(thirdVal-20))
                    return secondVal;
                else
                    return thirdVal;
            }
        }
        //41. Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times.
        public bool Zad41(string sentence)
        {
            int licznik=0;
            foreach (char item in sentence)
            {
                    
                if (item=='w')
                {
                    if (licznik++>3)
                    {
                        return false;
                    }
                }
            }
            return IsBetween(licznik,1,3);
        }
        //42. Write a C# program to create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case.
        public string Zad42(string sentence) => sentence.Length<4 ? sentence.ToUpper() : sentence[0..4].ToLower() + sentence[4..];
        //43. Write a C# program to check if a given string starts with "w" and immediately followed by two "ww"
        public bool Zad43(string sentence) => sentence.Length<5? false: sentence[0..5]=="wwwww";
        //44. Write a C# program to create a new string of every other character (odd position) from the first position of a given string.
        public string Zad44(string sentence)
        {
            string everyOdd = string.Empty;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (i%2==0)
                {
                    everyOdd +=sentence[i];
                }
            }
            return everyOdd;
        }
        //45. Write a C# program to count a specified number in a given array of integers
        public int Zad45(int searchedNumb, IEnumerable<int> array)
        {
            int counter=0;
            foreach (var item in array)
            {
                if (item==searchedNumb)
                {
                    counter++;
                }
            }
            return counter;
        }
        //46. Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more
        public bool Zad46(int searchedNumb, IEnumerable<int> array)
        => array.First()==searchedNumb || array.Last()==searchedNumb;
        //47. Write a C# program to compute the sum of all the elements of an array of integers.
        public int Zad47(IEnumerable<int> array)
        {
            int sum=0;
            foreach (int number in array)
                sum+=number;
            return sum;
        }
        //48. Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more
        public bool Zad48(IEnumerable<int> array) =>array.First()==array.Last(); 
        //49. Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.
        public bool Zad49(IEnumerable<int> arrayA,IEnumerable<int> arrayB)
            =>(IsNotNullAndEmpty(arrayA)&&IsNotNullAndEmpty(arrayB))? arrayA.First()==arrayB.First() || arrayA.Last()==arrayB.Last(): false; 
        private bool IsNotNullAndEmpty(IEnumerable<int> array) =>(array !=null && array.Any());
        //50. Write a C# program to rotate an array (length 3) of integers in left direction.
        public int[] Zad50(int[] array)
        {
            int temp= array.First();
            for (int i = 0; i <array.Length-1; i++)
                array[i]=array[i+1];
             array[^1]=temp;
            return array;
        }
        //51. Write a C# program to get the larger value between first and last element of an array (length 3) of integers. 
        public int Zad51(IEnumerable<int> array)=> Math.Max(array.First(),array.Last());
        //52. Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
        public int[] Zad52(int[] arr1, int[] arr2, int[] arr3) => new int[] {arr1[1],arr2[1],arr3[1]};
        //53. Write a C# program to check if an array contains an odd number.
        public bool Zad53(IEnumerable<int> array)
        {
            foreach (int number in array)
            {
                if (number%2!=0)
                {
                    return true;
                }
            }
            return false;
        }
        //54. Write a C# program to get the century from a year. 
        public int Zad54(int year)=> year%100!=0? (year/100)+1: year/100;
        //55. Write a C# program to find the pair of adjacent elements that has the largest product of an given array which is equal to a given value.
        public int Zad55(int[] array)
        {
            int product=array[0]*array[1];
            if (array.Length<2)
                return int.MinValue;
            if (array.Length==2)
                return product;

            for (int i = 1; i < array.Length-1; i++)
                product= array[i]*array[i+1]>product? array[i]*array[i+1]:product;

            return product;
        }
        //56. Write a C# program to check if a given string is a palindrome or not. 
        public bool Zad56(string word)
        {
          for (int i = 0; i < word.Length/2; i++)
          {
            if(word[i]!=word[^(i+1)])
                return false;
          }  
          return true;
        }
        //58. Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range.
        public List<int> Zad58(List<int> array)
        {
            int min = int.MaxValue, max = int.MinValue;
            List<int> missingNumbers = new List<int>();
            foreach (int value in array)
            {
                min = value<min? value: min;
                max = value>max? value: max;
            }
            for (int i = min+1; i < max; i++)
            {
                if (!array.Contains(i))
                    missingNumbers.Add(i);
            }
            return missingNumbers;
        }
        //59. Write a C# program to check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array.
        public static bool Zad59(int[] sequence)
        {
            int x = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                    x++;
                if (i + 2 < sequence.Length && sequence[i] >= sequence[i + 2])
                    x++;
            }
            return x <= 2;
        }
        //60. Write a C# program to calculate the sum of all the integers of a rectangular matrix except those integers which are located below an intger of value 0
        public static int Zad60(int[,] matrix)
        {
            int sum=0;
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]>0)
                        sum+=matrix[i,j];
                }
            }
         
           return sum;
        }
        //61. Write a C# program to sort the integers in ascending order without moving the number -5.
        public int[] Zad61(int[] array)
        {
            int[] num = array.Where(x => x != -5).OrderBy(x => x).ToArray();
            int ctr = 0;

            return array.Select(x => x >= 0 ? num[ctr++] : -5).ToArray();
        }
        //62. Write a C# program to reverse the strings contained in each pair of matching parentheses in a given string and also remove the parentheses within the given string.
        public string Zad62(string sentence)
        {
            int lParenth =sentence.IndexOf('('),rParenth;
            if (lParenth==-1)
                return sentence;
            else
            {
                rParenth= sentence.IndexOf(')');
                string reverse = new string(sentence[(lParenth+1)..(rParenth)].Reverse().ToArray());
                return sentence[0..lParenth] + reverse + sentence[(rParenth+1)..];
            }
        }
        //63. Write a C# program to check if a given number present in an array of numbers
        public bool Zad63(IEnumerable<int> array, int searchedNumb)
        {
            foreach (var item in array)
            {
                if (searchedNumb==item)
                    return true;
            }
            return false;
        }
        //64. Write a C# Sharp program to get the file name (including extension) from a given path.
        public string Zad64(string path) => path.Split('\\').Last();
        //65. Write a C# Sharp program to multiply all of elements of a given array of numbers by the array length.
        public int[] Zad65(int[] collection)
        {
            int length = collection.Length;
            int[] multipliedCollection = new int[length];
            for (var i = 0; i < length; i++)
            {
                multipliedCollection[i] = collection[i]*length;
            }
            return multipliedCollection;
        }
        //66. Write a C# Sharp program to find the minimum value from two given two numbers, represented as string.
        public string Zad66(string firstVal, string secondVal) => Math.Min(ParseToInt(firstVal),ParseToInt(secondVal)).ToString();
        private int ParseToInt(string value)
        {
            int result;
            if (int.TryParse(value, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine($"Could not parse the string to int");
                return int.MinValue;
            }
        }
        //67. Write a C# Sharp program to create a coded string from a given string, using specified formula. Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.
        public string Zad67(string word)
        {
            string codedString= string.Empty;
            foreach (char item in word)
            {
                switch (item)
                {
                    case 'P':
                    codedString+='9';
                    break;
                    case 'T':
                    codedString+='0';
                    break;
                    case 'S':
                    codedString+='1';
                    break;
                    case 'H':
                    codedString+='6';
                    break;
                    case 'A':
                    codedString+='8';
                    break;
                    
                    default:
                    codedString+=item;
                    break;
                }
            }
                return codedString;
        }
        //68. Write a C# Sharp program to count a specified character (both cases) in a given string
        public int Zad68(string word, char searchedChar)
        {
            int counter = 0;
         foreach (char item in word)
         {
            if (char.ToLower(item)==char.ToLower(searchedChar))
                counter++;
         }
         return counter;   
        }
        //69. Write a C# Sharp program to check if a given string contains only lowercase or uppercase characters.
        public bool Zad69(string word) => word==word.ToLower() || word==word.ToUpper();
        //70. Write a C# Sharp program to remove the first and last elements from a given string.
        public string Zad70(string word)
        {
            if (String.IsNullOrEmpty(word)|| word.Length==1)
                return string.Empty;
            else
                return word[1..^1];
        }
        //71. Write a C# Sharp program to check if a given string contains two similar consecutive letters.
        public bool Zad71(string word)
        {
            for (var i = 0; i < word.Length-1; i++)
            {
                if (char.ToLower(word[i])==char.ToLower(word[i+1]))
                    return true;
            }
            return false;
        }
        //72. Write a C# Sharp program to check whether the average value of the elements of a given array of numbers is a whole number or not.
        public bool Zad72(IEnumerable<int> collection) => Average(collection)%1==0;
        private decimal Average(IEnumerable<int> collection)
        {
            decimal sum = 0, count = 0;
            decimal average =0;
            foreach (int value in collection)
            {
                count++;
                sum +=value;
            }
            average = (decimal)(sum/count);
            return average;
        }
        //73. Write a C# Sharp program to convert the letters of a given string (same case-upper/lower) into alphabetical order.
        public string Zad73(string word)
        {
            string alphabetical= string.Empty;
            int lengthAtBeg = word.Length, lowestId=-1, lowestVal=int.MaxValue;
            do
            {
                for (var i = 0; i < word.Length; i++)
                {
                    if (lowestVal>word[i])
                    {
                        lowestVal=word[i];
                        lowestId=i;
                    }
                }
                alphabetical+=word[lowestId];
                word = word.Remove(lowestId,1);
                lowestVal=int.MaxValue;
            } while (alphabetical.Length<lengthAtBeg);
            return alphabetical;
            //return new string(word.OrderBy(x=>x).ToArray());
        }
        //74. Write a C# Sharp program to check the length of a given string is odd or even. Return 'Odd length' if the string length is odd otherwise 'Even length'.
        public string Zad74(string word) => word.Length%2==0? "Even length" : "Odd length";
        //75. Write a C# Sharp program which takes a positive number and return the nth odd number.
        public int Zad75(int whichOddNumber) => (whichOddNumber*2)-1;
        //76. Write a C# Sharp program to get the ASCII value of a given character.
        public int Zad76(char character) => (int)character;
        //77. Write a C# Sharp program to check whether a given word is plural or not.
        public bool Zad77(string word) => word.EndsWith('s');
        //78. Write a C# Sharp program to find sum of squares of elements of a given array of integers.
        public int Zad78(IEnumerable<int> collection) => collection.Sum(x =>x*x);
        //79. Write a C# Sharp program to convert an integer to string and a string to an integer.
        public void Zad79(string word) => ParseToInt(word);
        public void Zad79(int value) => value.ToString();
        //80. Write a C# Sharp program to convert all the values of a given array of mixed values to string values
        public string Zad80(IEnumerable<object> collection)
        {
            string valueTypes = string.Empty;
            foreach (var item in collection)
            {
                valueTypes += $"value: {item} | type: {item.GetType()}\n";
            }
            return valueTypes;

        }
        //81. Write a C# Sharp program to swap a two digit given number and check whether the given number is greater than its swap value.
        public bool Zad81(int value)
        {
            int switchedVal;
            if (value<10||value>100)
                return false;
            switchedVal = (value%10)*10 + value/10;
            return switchedVal < value;
        }
        //82. Write a C# Sharp program to remove all characters which are non-letters from a given string
        public string Zad82(string word)
        {
            for (var i = word.Length-1; i >= 0; i--)
            {
                if (!(IsLower(word[i])|| IsUpper(word[i])))
                {
                    word = word.Remove(i,1);
                }
            }
            return word;
        }
        private bool IsLower(char letter) => letter>96 && letter<122;
        private bool IsUpper(char letter) => letter>64 && letter<91;
        //83. Write a C# Sharp program to remove all vowels from a given string.
        public string Zad83(string sentence)
        {
            char[] vowels = {'a','e','i','o','u','y'};
            for (var i = 0; i < sentence.Length; i++)
            {
                if(vowels.Contains(sentence[i]))
                    sentence = sentence.Remove(i,1);
            }
            return sentence;
        }
        //84. Write a C# Sharp program to get the index number of all lower case letters in a given string.
        public List<int> Zad84(string sentence)
        {
            List<int> indexList = new List<int>();
            for (var i = 0; i < sentence.Length; i++)
            {
                indexList.Add(i);
            }
            return indexList;
        }
        //85. Write a C# Sharp program to find the cumulative sum of an array of number.
        public List<int> Zad85(IEnumerable<int> collection)
        {
            int sum=0;
            List<int> cumulativeSum = new List<int>();
            foreach (int item in collection)
            {
                sum +=item;
                cumulativeSum.Add(sum);
            }
            return cumulativeSum;
        }
        //86. Write a C# Sharp program to get the number of letters and digits in a given string.
        public string Zad86(string sentence)
        {
            int digitCounter=0, letterCounter=0;
            foreach (char item in sentence)
            {
                if (IsUpper(item)||IsLower(item))
                    letterCounter++;

                else if(IsDigit(item))
                    digitCounter++;
            }
            return $"Digits in sentence {digitCounter}\nLetters in counter{letterCounter}";
        }
        private bool IsDigit(char character) => character>47 && character <58;
        //87. Write a C# Sharp program to reverse a boolean value. 
        public bool Zad87(bool value) => !value;
        //88. Write a C# Sharp program to find the sum of the interior angles (in degrees) of a given Polygon. Input number of straight line(s).
        public int Zad88(int numberOfSides) => 180*(numberOfSides-2);
        //89. Write a C# Sharp program to count positive and negative numbers in a given array of integers.
        public string Zad89(IEnumerable<int> collection,out int positiveCounter, out int negativeCounter)
        {
            positiveCounter=0;
            negativeCounter = 0;
            foreach (int item in collection)
            {
                if (item>0)
                    positiveCounter++;

                else if(item<0)
                    negativeCounter++;
            }
            return $"Amount of positive numbers: {positiveCounter}\nAmount of negative numbers: {negativeCounter}";
        }
        //90. Write a C# Sharp program to count number of ones and zeros in the binary representation of a given integer.
        public string Zad90(int value,out int oneCounter, out int zeroCounter)
        {
            oneCounter= 0; zeroCounter=0;
            string binaryValue = Convert.ToString(value,2);
            foreach (char item in binaryValue)
            {
                if (item=='1')
                    oneCounter++;
                else
                    zeroCounter++;
            }
            return $"Number of ones {oneCounter}\nNumber of zeros {zeroCounter}";
        }
        //91. Write a C# Sharp program to remove all the values except integer values from a given array of mixed values.
        public List<int> Zad91(IEnumerable<object> collection)
        {
            List<int> onlyNumbers = new List<int>();
            foreach(var item in collection)
            {
                if (item is int)
                    onlyNumbers.Add((int)item);
            }
            return onlyNumbers;
            //alternatywnie mogę zastosować             return collection.OfType<int>().ToArray();    przez co bym musiał zamienić liste int na array
        }
        //92. Write a C# Sharp program to find the next prime number of a given number. If the given number is a prime number, return the number.
        public int Zad92(int value)
        {
            if(IsPrime(value))
                return value;
            else
            {
                do
                {
                } while (!IsPrime(++value));
                return value;
            }
        }
        
        

        











    }

}