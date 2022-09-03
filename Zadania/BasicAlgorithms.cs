namespace Zadania
{
    public class BasicAlgorithms
    {
        BasicExercises BA = new BasicExercises();
        //1. Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
        public int Zad1(int firstVal, int secondVal) => firstVal==secondVal? 3*(firstVal+secondVal) : firstVal+secondVal;
        //2. Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference. 
        public int Zad2(int value) => value<=51? 51-value : 3*(value-51);
        //3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
        public bool Zad3(int firstVal, int secondVal) => firstVal==30^secondVal==30 || firstVal+secondVal==30;
        //4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
        public bool Zad4(int value) => BA.IsBetween(value,90,110) || BA.IsBetween(value,190,210);
        //5. Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged.
        public string Zad5(string sentence) => sentence.StartsWith("if")? sentence : $"if {sentence}";
        //6. Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive.
        public string Zad6(string sentence, int indexToRemove) => BA.IsBetween(indexToRemove,0,(sentence.Length-1)) ? sentence.Remove(indexToRemove,1) : "Index out of boundry";
        //7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
        public string Zad7(string sentence)
        {
            if (sentence.Length<=1)
                return sentence;
            else if(sentence.Length==2)
                return $"{sentence[1]}{sentence[0]}";
            else
              return sentence[^1]+sentence[1..^1]+sentence[0];   
        }
        //8. Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string.
        public string Zad8(string sentence) => sentence.Length<2? sentence : sentence[0..2]+sentence[0..2]+sentence[0..2]+sentence[0..2];
        //9. Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
        public string Zad9(string sentence) => sentence.Length>0? sentence[^1] + sentence +sentence[^1] : string.Empty;
        //10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.
        public bool Zad10(int value) => value%3==0 || value%7==0;
        //11. Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there.
        public string Zad11(string sentence) => sentence.Length<3? sentence+sentence+sentence : sentence[0..3] + sentence + sentence[0..3];
        //12. Write a C# Sharp program to check if a given string starts with 'C#' or not.
        public bool Zad12(string sentence) => sentence.StartsWith("C#");
        //13. Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100.
        public bool Zad13(int firstTemp, int secondTemp) => (firstTemp<0 && secondTemp>100) ||(secondTemp<0 && firstTemp>100);
        //14. Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive. 
        public bool Zad14(int firstVal, int secondVal) => BA.IsBetween(firstVal,100,200) || BA.IsBetween(secondVal,100,200);
        //15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. Return true if 1 or more of them are in the said range otherwise false.
        public bool Zad15(IEnumerable<int> collection)
        {
            foreach(int item in collection)
            {
                if (BA.IsBetween(item,20,50))
                    return true;
            }
            return false;
        }
        //16. Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if 1 or other is in the said range otherwise false.
        public bool Zad16(int firstVal, int secondVal) => BA.IsBetween(firstVal,20,50) ^ BA.IsBetween(secondVal,20,50);
        //17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' otherwise return the original string.
        public string Zad17(string sentence) => sentence[1..3]=="yt"? sentence.Remove(1,2) : sentence;
        //18. Write a C# Sharp program to check the largest number among three given integers.
        public int Zad18(IEnumerable<int> collection)=>collection.Max();
        //19. Write a C# Sharp program to check which number nearest to the value 100 among two given integers. Return 0 if the two numbers are equal.
        public int Zad19(int firstVal, int secondVal) => firstVal==secondVal? 0 : (Math.Abs(firstVal-100)>Math.Abs(secondVal-100)? secondVal : firstVal);
        //20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive
        public  bool Zad20(int firstVal, int secondVal) => (BA.IsBetween(firstVal,40,50)&& BA.IsBetween(secondVal,40,50)) || (BA.IsBetween(firstVal,50,60)&& BA.IsBetween(secondVal,50,60));
        //21. Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, or return 0 if neither is in that range.
        public int Zad21(int firstVal, int secondVal)
        {
            if (BA.IsBetween(firstVal,20,30)&&BA.IsBetween(secondVal,20,30))
                return Math.Max(firstVal,secondVal);
            else if(BA.IsBetween(firstVal,20,30)&&!BA.IsBetween(secondVal,20,30))
                return firstVal;
            else if(!BA.IsBetween(firstVal,20,30)&&BA.IsBetween(secondVal,20,30))
                return secondVal;
            else
                return 0;
        }
        //22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character. 
        public bool Zad22(string sentence)
        {
            int zCounter=0;
            foreach (var item in sentence)
            {
                if (item == 'z')
                    zCounter++;
                if (zCounter>4)
                    return false;
            }
            return zCounter>=2;
        }
        //23. Write a C# Sharp program to check if two given non-negative integers have the same last digit.
        public bool Zad23(int firstVal, int secondVal) => firstVal>=0 && secondVal>=0? firstVal%10==secondVal%10 : false;
        //24. Write a C# Sharp program to convert the last 3 characters of a given string in upper case. If the length of the string has less than 3 then uppercase all the characters. 
        public string Zad24(string sentence) => sentence.Length<3 ? sentence.ToUpper() : sentence[0..^3] + sentence[^3..].ToUpper();
        //25. Write a C# Sharp program to create a new string which is n (non-negative integer) copies of a given string.
        public string Zad25(string sentence, int repeats)
        {
            string withRepeats = string.Empty;
            if (repeats>0)
            {
                for (var i = 0; i < repeats; i++)
                {
                    withRepeats += sentence;
                }
            }
                return withRepeats;
        }
        //26. Write a C# Sharp program to create a new string which is n (non-negative integer) copies of the the first 3 characters of a given string. If the length of the given string is less than 3 then return n copies of the string.
        public string Zad26(string sentence, int count)
        {
            string copies = string.Empty;
            if (count >0)
            {
                if (sentence.Length<3)
                {
                    for (var i = 0; i < count; i++)
                        copies += sentence;
                }
                else
                {
                    for (var i = 0; i < count; i++)
                        copies+=sentence[0..3];
                }
            }
            return copies;
        }
        //27. Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa"
        public int Zad27(string sentence)
        {
            int aaCount=0;
            for (var i = 0; i < sentence.Length-1; i++)
            {
                if (sentence[i]=='a'&& sentence[i+1]=='a')
                    aaCount++;
            }
            return aaCount;
        }
        //28. Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a"
        public bool Zad28(string sentence)
        {
            for (var i = 0; i < sentence.Length-1; i++)
            {
                if (sentence[i]=='a')
                {
                    if (sentence.Substring(i,2)=="aa")
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
        //29. Write a C# Sharp program to create a new string made of every other character starting with the first from a given string.
        public string Zad29(string sentence)
        {
            string everyOtherLetter = string.Empty;

            for (var i = 0; i < sentence.Length; i++)
            {
                if (i%2==0)
                everyOtherLetter+=sentence[i];
            }
            return everyOtherLetter;
        }
        //30. Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd".
        public string Zad30(string sentence)
        {
            int counter =1;
            string copy = string.Empty;
            do
            {
                for (var i = 0; i < counter; i++)
                {
                    copy+=sentence[i];
                }
            } while (counter++<sentence.Length);
            return copy;
        }
        //31. Write a C# Sharp program to count a substring of length 2 appears in a given string and also as the last 2 characters of the string. Do not count the end substring.
        public int Zad31(string sentence)
        {
            int counter = 0;
            if (sentence.Length>=2)
            {
                string sub = sentence.Substring(0,2);
                for (var i = 0; i <sentence.Length-2 ; i++)
                {
                    if (sub==sentence.Substring(i,2))
                     counter++;   
                }
            }
            return counter;
        }
        //32. Write a C# Sharp program to check a specified number is present in a given array of integers.
        public bool Zad32(IEnumerable<int> collection, int searchedVal) => collection.Contains(searchedVal);
        //33. Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element.
        public bool Zad33(int[] array, int searchedVal)
        {
            if (array.Length<4)
                return array.Contains(searchedVal);
            else
            {
                for (var i = 0; i < 4; i++)
                {
                    if (array[i]==searchedVal)
                        return true;
                }
                        return false; 
            }
        }
        //34. Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere
        public bool Zad34(int[] array)
        {
            if (array.Length>2)
            {
                for (var i = 0; i < array.Length-2; i++)
                {
                    if (array[i]==1 && array[i+1]==2 && array[i+2]==3)
                    {
                        return true;
                    }
                }
                
            }
                return false;
        }
        //35. Write a C# Sharp program to compare two given strings and return the number of the positions where they contain the same length 2 substring.
        public int Zad35(string firstSen, string secondSen)
        {
            int loopLength= Math.Min(firstSen.Length,secondSen.Length)-1;
            int counter =0;
            for (var i = 0; i < loopLength; i++)
            {
                if (firstSen.Substring(i,2)==secondSen.Substring(i,2))
                    counter++;
            }
            return counter;
        }
        //37. Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string
        public string Zad37(string sentence)
        {
            int index=0;
            bool flag = true;
            string toReturn = string.Empty;
            do
            {
                toReturn += sentence[index];
                if (flag)
                {
                    flag = false;
                    index++;
                }
                else
                {
                    flag = true;
                    index +=3;
                }
                
            } while (index<sentence.Length);
            return toReturn;
        }
        //38. Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. Also count the situation where the second 5 is actually a 6.
        public int Zad38(int[] array)
        {
            int counter = 0;
            for (var i = 0; i < array.Length-1; i++)
            {
                if (array[i]==5 && (array[i+1]==5 || array[i+1]==6))
                    counter++;
            }
            return counter;
        }
        //39. Write a C# Sharp program to check if a triple is presents in an array of integers or not. If a value appears three times in a row in an array it is called a triple
        public bool Zad39(int[] array)
        {
            for (var i = 0; i < array.Length-2; i++)
            {
                if (array[i]==array[i+1]&& array[i]==array[i+2])
                    return true;
            }
            return false;
        }
        //40. Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30.
        public int Zad40(int firstVal, int secondVal) => BA.IsBetween(firstVal+secondVal,10,20) ? 30 : firstVal+secondVal;
        //41. Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5.
        public bool Zad41(int firstVal, int secondVal) => firstVal+secondVal==5 ||Math.Abs(firstVal-secondVal)==5||Math.Abs(secondVal+firstVal)==5 || secondVal==5 || firstVal==5;
        //42. Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13
        public bool Zad42(int value) => value%13==0 || value%13==1;
        //43. Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both.
        public bool Zad43(int value) => value%3==0 ^ value%7==0;
        //44. Write a C# Sharp program to check if a given number is within 2 of a multiple of 10.
        public bool Zad44(int value) => value<10 ? value%10<=2: value%10<=2 || value%10>=8;
        //45. Write a C# Sharp program to compute the sum of the two given integers. If one of the given integer value is in the range 10..20 inclusive return 18.
        public int Zad45(int firstVal, int secondVal) => BA.IsBetween(firstVal,10,20) || BA.IsBetween(secondVal,10,20) ? 18: firstVal+secondVal;
        //46. Write a C# Sharp program to check whether a given string starts with "F" or ends with "B". If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B" If the string starts with "F" and ends with "B" return "FizzBuzz". In other cases return the original string.
        public string Zad46(string sentence) => sentence.StartsWith('F') && sentence.EndsWith('B') ? "FizzBuzz" : sentence.StartsWith('F') ? "Fizz" : sentence.EndsWith('B') ? "Buzz" : sentence;
        //47. Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers.
        public bool Zad47(int firstVal, int secondVal, int thirdVal) => (firstVal+secondVal==thirdVal || thirdVal+secondVal==firstVal || thirdVal+firstVal==secondVal );
        //48. Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z
        public bool Zad48(int x, int y, int z) => x<y && y<z;
        //49. Write a C# Sharp program to check if three given numbers are in strict increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8.However,if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7.
        public bool Zad49(int firstVal, int secondVal, int thirdVal, bool flag)=> flag? firstVal<=secondVal && secondVal<=thirdVal : firstVal<secondVal && secondVal<thirdVal;
        //50. Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit.
        public bool Zad50(int firstVal, int secondVal) => (firstVal>0 && secondVal>0) && firstVal%10==secondVal%10;
        //51. Write a C# Sharp program to check three given integers and return true if one of them is 20 or more less than one of the others.
        public bool Zad51(int firstVal, int secondVal, int thirdVal)
        {
            if (firstVal-secondVal>=20 ||firstVal-thirdVal>=20 ||thirdVal-secondVal>=20 ||thirdVal-firstVal>=20 || secondVal-firstVal>=20  || secondVal-firstVal>=20 )
                return true;   
             else
                return false;
        }
        //52. Write a C# Sharp program to find the larger from two given integers. However if the two integers have the same remainder when divided by 7, then the return the smaller integer. If the two integers are the same, return 0.
        public int Zad52(int firstVal, int secondVal) => firstVal==secondVal? 0 : firstVal%7==secondVal%7? Math.Min(firstVal,secondVal) : Math.Max(firstVal,secondVal);
        //53. Write a C# Sharp program to check two given integers, each in the range 10..99. Return true if a digit appears in both numbers, such as the 3 in 13 and 33.
        public bool Zad53(int firstVal, int secondVal)
        {
            if (BA.IsBetween(firstVal,10,99)&& BA.IsBetween(secondVal,10,99))
                return firstVal/10 == secondVal/10 || firstVal%10 == secondVal/10 || firstVal/10 == secondVal%10 || firstVal%10==secondVal%10; 
            return false;
        }
        //54. Write a C# Sharp program to compute the sum of two given non-negative integers x and y as long as the sum has the same number of digits as x. If the sum has more digits than x then return x without y.
        public int Zad54(int firstVal, int secondVal) 
        => firstVal>0 && secondVal>0 ? ((firstVal +secondVal).ToString().Length>firstVal.ToString().Length? firstVal : firstVal + secondVal):int.MinValue;
        //55. Write a C# Sharp program to compute the sum of three given integers. If the two values are same return the third value.
        public int Zad55(int firstVal, int secondVal, int thirdVal)
        {
            if (firstVal==secondVal)
                return thirdVal;
            else if (firstVal==thirdVal)
                return secondVal;
            else if(secondVal == thirdVal)
                return firstVal;
            else
                return firstVal+ secondVal+ thirdVal;
        }
        //56. Write a C# Sharp program to compute the sum of the three integers. If one of the values is 13 then do not count it and its right towards the sum.
        public int Zad56(IEnumerable<int> collection)
        {
            int sum=0;
            foreach (int value in collection)
            {
                if (value==13)
                    return sum;
                sum +=value;
            }
            return sum;
        }
        public int Zad57(IEnumerable<int> collection)
        {
            int sum = 0;
            foreach (int value in collection)
            {
                if (BA.IsBetween(value,10,20))
                {
                    if (value==13 || value==17)
                        sum += value;
                }
                else
                    sum += value;
            }
            return sum;
        }
        //58. Write a C# Sharp program to check two given integers and return the value whichever value is nearest to 13 without going over. Return 0 if both numbers go over.
        public int Zad58(int firstVal, int secondVal) 
        => firstVal>13 && secondVal>13? 0: Math.Max(firstVal-13,secondVal-13)>0 ? Math.Min(firstVal,secondVal) : Math.Max(firstVal,secondVal);
        //59. Write a C# Sharp program to check three given integers (small, medium and large) and return true if the difference between small and medium and the difference between medium and large is same
        public bool Zad59(int small, int medium, int large) => small-medium==medium-large;
        //60. Write a C# Sharp program to create a new string using two given strings s1, s2, the format of the new string will be s1s2s2s1.
        public string Zad60(string firstSen, string secondSen) => firstSen+secondSen+secondSen+firstSen;
        //61. Write a C# Sharp program to insert a given string into middle of the another given string of length 4.
        public string Zad61(string sentence, string inserted)=> sentence.Insert((sentence.Length/2),inserted);
        //62. Write a C# Sharp program to create a new string using three copies of the last two character of a given string of length atleast two.
        public string Zad62(string sentence) => sentence.Length>1? sentence[^2..]+sentence[^2..]+sentence[^2..] : "string is not long enough";
        //63. Write a C# Sharp program to create a new string using first two characters of a given string. If the string length is less than 2 then return the original string..
        public string Zad63(string sentence) => sentence.Length>1? sentence[0..2]: sentence;
        //64. Write a C# Sharp program to create a new string of the first half of a given string of even length.
        public string Zad64(string sentence) => sentence[0..(sentence.Length/2)];
        //65. Write a C# Sharp program to create a new string without the first and last character of a given string of length at least two.
        public string Zad65(string sentence) => sentence.Length>1? sentence[1..^1] :string.Empty;
        //66. Write a C# Sharp program to create a new string from two given string one is shorter and another is longer. The format of the new string will be long string + short string + long string.
        public string Zad66(string firstWord, string secondWord) => firstWord.Length>secondWord.Length? firstWord+secondWord+firstWord: secondWord+firstWord+secondWord;
        //67. Write a C# Sharp program to concat two given string of length atleast 1, after removing their first character.
        public string Zad67(string firstSen, string secondSen) => firstSen.Length>0&& secondSen.Length>0? firstSen[1..]+secondSen[1..]: string.Empty;
        //68. Write a C# Sharp program to move the first two characters to the end of a given string of length at least two.
        public string Zad68(string sentence) => sentence.Length>1? sentence[2..]+sentence[0..2]: sentence;
        //69. Write a C# Sharp program to move the last two characters to the start of a given string of length at least two.
        public string Zad69(string sentence) => sentence.Length>1? sentence[^2..]+sentence[0..^2]:sentence;
        //70. Write a C# Sharp program to create a new string without the first and last character of a given string of any length.
        public string Zad70(string sentence) => sentence.Length>2? sentence[1..^1] : string.Empty;
        //71. Write a C# Sharp program to create a new string using the two middle characters of a given string of even length (at least 2)
        public string Zad71(string sentence) => sentence.Length>1? sentence.Substring(sentence.Length/2-1,2): sentence;
        //72. Write a C# Sharp program to check if a given string ends with "on".
        public bool Zad72(string sentence) => sentence.EndsWith("on");
        //73. Write a C# Sharp program to create a new string using the first and last n characters from a given string of length at least n.
        public string Zad73(string sentence, int length)=>length<sentence.Length? sentence[0..length] + sentence[^length..]:sentence;
        //74. Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string.
        public string Zad74(string sentence,int index) => sentence.Substring(index,2);
        //75. Write a C# Sharp program to create a new string taking 3 characters from the middle of a given string at least 3.
        public string Zad75(string sentence) => sentence.Length>2? sentence.Substring(sentence.Length/2-1,3):sentence;
        //76. Write a C# Sharp program to create a new string of length 2, using first two characters of a given string. If the given string length is less than 2 use '#' as missing characters.
        public string Zad76(string sentence) => sentence.Length>1? sentence[0..2]: (sentence.Length==1? sentence+'#':"##");
        //77. Write a C# Sharp program to create a new string taking the first character from a given string and the last character from another given string. If the length of any given string is 0, use '#' as its missing character
        public string Zad77(string firstSen, string secondSen)
        {
            string finalVer = string.Empty;
            finalVer+= firstSen.Length<1? '#': firstSen[0];
            finalVer+= secondSen.Length<1? '#': secondSen[^1];
            return finalVer;
        }
        //78. Write a C# Sharp program to combine two given strings (lowercase). If there are any double character in new string then omit one character.
        public string Zad78(string firstSen, string secondSen) =>firstSen[^1]==secondSen[0]? firstSen+secondSen[1..] : firstSen+secondSen;
        //79. Write a C# Sharp program to create a new string from a given string after swapping last two characters.
        public string Zad79(string sentence)
        {
            if (sentence.Length<2)
                return sentence;
            else
                return sentence[0..^2]+ sentence[^1] + sentence[^2];                
        }
        //80. Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'. If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise return the empty string
        public string Zad80(string sentence) => sentence.StartsWith("abc") ? "abc" : sentence.StartsWith("xyz") ? "xyz" : string.Empty;
        //81. Write a C# Sharp program to check whether the first two characters and last two characters of a given string are same.
        public bool Zad81(string sentence) => sentence[0..2]==sentence[^2..];
        //82. Write a C# Sharp program to combine two given strings. If the given strings have different length remove the characters from the longer string.
        public string Zad82(string firstSen, string secondSen)
        {
            int firstLen = firstSen.Length, secondLen = secondSen.Length;
            if (firstLen==secondLen)
                return firstSen+secondSen;
            else if (firstLen>secondLen)
                return firstSen[0..(secondLen)] +secondSen;
            else
                return firstSen + secondSen[0..(firstLen)];
        }
        //83. Write a C# Sharp program to create a new string using 3 copies of the first 2 characters of a given string. If the length of the given string is less than 2 use the whole string. 
        public string Zad83(string sentence) => sentence.Length<2? sentence+sentence+sentence : sentence[0..2] + sentence[0..2] + sentence[0..2];
        //84. Write a C# Sharp program to create a new string from a given string. If the two characters of the given string from its beginning and end are same return  the given string without the first two characters otherwise return the original string.
        public string Zad84(string sentence) => sentence.Length<1?sentence :sentence[0..2]==sentence[^2..]? sentence.Remove(0,2):sentence;
        //85. Write a C# Sharp program to create a new string from a given string without the first two characters. Keep the first character if it is "p" and keep the second character if it is "y".
        public string Zad85(string sentence)
        {
            if (sentence.Length>1)
            {
                if (sentence[1]=='y')
                   sentence= sentence.Remove(1,1);
                if (sentence[0]=='p')
                    sentence = sentence.Remove(0,1);
            }
            return sentence;
        }
        //86. Write a C# Sharp program to create a new string from a given string without the first and last character if the first or last characters are 'a' otherwise return the original given string
        public string Zad86(string sentence)
        {
            if(sentence.Length>0)
            {
                if (sentence[^1]=='a')
                    sentence= sentence.Remove(sentence.Length-1,1);
                if (sentence[1]=='a')
                    sentence= sentence.Remove(0,1);
            }
            return sentence;
        }
        //87. Write a C# Sharp program to create a new string from a given string. If the first or first two characters is 'a', return the string without those 'a' characters otherwise return the original given string.
        public string Zad87(string sentence) 
        {
            if (sentence.StartsWith("aa"))
                sentence = sentence.Remove(0,2);
            else if(sentence[0]=='a')
                sentence = sentence.Remove(0,1);
            return sentence;
        } 
        //88. Write a C# Sharp program to check a given array of integers of length 1 or more and return true if 10 appears as either first or last element in the given array.
        public bool Zad88(int[] array) => array[0]==10 || array[^1]==10;
        //89. Write a C# Sharp program to check a given array of integers of length 1 or more and return true if the first element and the last element are equal in the given array.
        public bool Zad89(int[] array) => array.Length>0 && array[0]==array[^1];
        //90. Write a C# Sharp program to check two given arrays of integers of length 1 or more and return true if they have the same first element or they have the same last element. 
        public bool Zad90(int[] arrayOne, int[] arrayTwo) => (arrayOne.Length>0&& arrayTwo.Length>0) && (arrayOne[0]==arrayTwo[0]||arrayOne[^1]==arrayTwo[^1]);
        //91. Write a C# Sharp program to compute the sum of the elements of an given array of integers.
        public int Zad91(IEnumerable<int> collection) => collection.Sum();  
        //92. Write a C# Sharp program to rotate the elements of a given array of integers (length 4 ) in left direction and return the new array.
        public int[] Zad92(int[] array)
        {
            int temp = array[0];
            for (var i = 0; i < array.Length-1; i++)
                array[i]= array[i+1];
            array[^1] = temp;
            return array;
        }
        //93. Write a C# Sharp program to reverse a given array of integers and length 5.
        public IEnumerable<int> Zad93(IEnumerable<int> collection) => collection.Reverse();
        //94. Write a C# Sharp program to find out the maximum element between the first or last element in a given array of integers ( length 4), replace all elements with maximum element. 
        public int[] Zad94(int[] array)
        {
            int max;
            if (array.Length>1)
            {
                max = Math.Max(array[0],array[^1]);
                for (var i = 0; i < array.Length; i++)
                {
                    array[i] = max;
                }
            }
            return array;
        }
        //95. Write a C# Sharp program to create a new array containing the middle elements from the two given arrays of integers, each length 5.
        public int[] Zad95(int[] arrayOne, int[] arrayTwo) => new int[] {arrayOne[arrayOne.Length/2],arrayTwo[arrayTwo.Length/2]};
        //96. Write a C# Sharp program to create a new array taking  the first and last elements of a given array of integers and length 1 or more.
        public int[] Zad96(int[] array) => array.Length>0? new int[]{array[0],array[^1]} : new int[] {0};
        //97. Write a C# Sharp program to check if a given array of integers and length 2, contains 15 or 20.
        public bool Zad97(IEnumerable<int> collection) => collection.Contains(15) || collection.Contains(20);
        //98. Write a C# Sharp program to check if a given array of integers and length 2, does not contain 15 or 20.
        public bool Zad98(IEnumerable<int> collection) => !Zad97(collection);
        //99. Write a C# Sharp program to create a new array of integers and length 1 or more. The length of the new array will be double length of the given array and all the elements are 1 except the first element which is equal to the given array.
        public int[] Zad99(int[] array)
        {
            int[] final;
            if(array.Length>0)
            {
                final = new int[array.Length*2];
                final[0]=array[0];
                for (var i = 1; i < array.Length; i++)
                {
                    final[i]=1;
                }
            }
            final = new int[] {0};
           return final; 
        } 
        //100. Write a C# Sharp program to check a given array of integers and return true if the array contains 10 or 20 twice. The length of the array will be 0, 1, or 2.
        public bool Zad100(IEnumerable<int> collection)
        {
            bool flag10=false, flag20=false;
            foreach (var item in collection)
            {
                if (item==10)
                {
                    if (flag10)
                        return true;
                    flag10=true;
                }
                else if(item ==20)
                {
                    if (flag20)
                        return true;
                    flag20=true;
                }
            }
            return false;
        }
        //101. Write a C# Sharp program to check a given array of integers, length 3 and create a new array. If there is a 5 in the given array immediately followed by a 7 then set 7 to 1. 
        public int[] Zad101(int[] array)
        {
            for (var i = 0; i < array.Length-1; i++)
            {
                if (array[i]==5 && array[i+1]==7)
                    array[i+1]=1;
            }
            return array;
        }
        //102. Write a C# Sharp program to compute the sum of the two given arrays of integers, length 3 and find the array which has the largest sum.
        public int[] Zad102(int[] firstArr, int[] secondArr)
        {
            int[] maxValues;
         if (firstArr.Length==secondArr.Length)
         {
            maxValues = new int[firstArr.Length];
            for (var i = 0; i < firstArr.Length; i++)
            {
                maxValues[i] = Math.Max(firstArr[i],secondArr[i]);
            }
         }
         else
         {
            int smallerArr = Math.Min(firstArr.Length,secondArr.Length);
            maxValues = new int[smallerArr];
            for (var i = 0; i <smallerArr ; i++)
            {
                maxValues[i] = Math.Max(firstArr[i],secondArr[i]);
            }
         }
         return maxValues;
        }
        //103. Write a C# Sharp program to create an array taking two middle elements from a given array of integers of length even
        public int[] Zad103(int[] array) => new int[] {array[array.Length/2-1], array[array.Length/2]};
        //104. Write a C# Sharp program to create a new array from two give array of integers, each length 3
        public IEnumerable<int> Zad104(IEnumerable<int> firstArr, IEnumerable<int> secondArr) => firstArr.Concat(secondArr);
        //105. Write a C# Sharp program to create a new array swapping the first and last elements of a given array of integers and length will be least 1. 
        public int[] Zad105(int[] array)
        {
            if (array.Length>0)
            {
                int temp = array[0];
                array[0]= array[^1];
                array[^1]=temp;
            }
            return array;
        }
        //106. Write a C# Sharp program to create a new array length 3 from a given array (length at least 3) using the elements from the middle of the array. 
        public int[] Zad106(int[] array)
        {
            int[] finalArr = array;
            if (array.Length>=3)
            {
                int middle = array.Length/2;
                finalArr = new int[3] {array[middle-1],array[middle],array[middle+1]};
            }
            return finalArr;
        }
        //107. Write a C# Sharp program to find the largest value from first, last, and middle elements of a given array of integers of odd length (at least 1).
        public int Zad107(int[] array) => Math.Max(array[0],Math.Max(array[^1],array[array.Length/2]));
        //108. Write a C# Sharp program to create a new array taking the first two elements from a given array. If the length of the given array is less than 2 then return the give array
        public int[] Zad108(int[] array) => array.Length<2? array : array[0..2];
        //109. Write a C# Sharp program to count even number of elements in a given array of integers.
        public int Zad109(IEnumerable<int> collection)
        {
            int counter = 0;
            foreach (var item in collection)
            {
                if (item%2==0)
                    counter++;
            }
            return counter;
        }
        //110. Write a C# Sharp program to compute the difference between the largest and smallest values in a given array of integers and length one or more. 
        public int Zad110(IEnumerable<int> collection)
        {
            int min= int.MaxValue, max = int.MinValue;
            foreach (var item in collection)
            {
                if (item<min)
                    min=item;
                if (item>max)
                    max = item;
            }
            return max-min;
        }
        //111. Write a C# Sharp program to compute the sum of values in a given array of integers except the number 17. Return 0 if the given array has no integer. 
        public int Zad111(IEnumerable<int> collection) => collection.Sum(x => x!=17? x:0);
        //112. Write a C# Sharp program to compute the sum of the numbers in a given array except those numbers starting with 5 followed by at least one 6. Return 0 if the given array has no integer. 
        public int Zad112(IEnumerable<int>collection)
        {
            bool flag = false;
            int sum = 0;
            foreach (var item in collection)
            {
                sum +=item;
                if (item==5)
                {
                    flag=true;
                }
                else if(item==6&& flag)
                {
                    sum -=11;
                    flag=false;
                }
                else
                    flag = false;
            }
            return sum;
        }
        //113. Write a C# Sharp program to check if a given array of integers contains 5 next to a 5 somewhere.
        public bool Zad113(IEnumerable<int> collection)
        {
            bool flag = false;
            foreach (var item in collection)
            {
                if (item ==5 && flag)
                    return true;
                else if (item ==5)
                    flag = true;
                else
                    flag = false;
            }
            return false;
        }
        //114. Write a C# Sharp program to check whether a given array of integers contains 5's and 7's
        public bool Zad114(IEnumerable<int> collection) => collection.Contains(7) || collection.Contains(5);
        //115. Write a C# Sharp program to check if the sum of all 5' in the array exactly 15 in a given array of integers.
        public bool Zad115(IEnumerable<int> collection) => collection.Sum(x => x==5? 5:0)==15;
        //116. Write a C# Sharp program to check if the number of 3's is greater than the number of 5's.
        public bool Zad116(IEnumerable<int> collection) => collection.Count(x => x==3) >collection.Count(x => x==5);
        //117. Write a C# Sharp program to check if a given array of integers contains a 3 or a 5
        public bool Zad117(IEnumerable<int> collection) => collection.Contains(3) || collection.Contains(5);
        //118. Write a C# Sharp program to check if a given array of integers contains no 3 or a 5
        public bool Zad118(IEnumerable<int> collection) => !Zad118(collection);
        //119. Write a C# Sharp program to check if an array of integers contains a 3 next to a 3 or a 5 next to a 5 or both.
        public bool Zad119(IEnumerable<int> collection)
        {
            bool threeFlag = false, fiveFlag=false;
            foreach (var item in collection)
            {
                if (item==5)
                {
                    if (fiveFlag)
                        return true;
                    fiveFlag = true;
                }
                else if(item ==3)
                {
                    if (threeFlag)
                        return true;
                    threeFlag = true;
                }
                else
                {
                    threeFlag=false;
                    fiveFlag=false;
                }
            }
            return false;
        }
        //120. Write a C# Sharp program to check a given array of integers and return true if the given array contains two 5's next to each other, or two  5 separated by one element.
        public bool Zad120(int[] array)
        {
            if (array.Length>2)
            {
                for (var i = 0; i < array.Length-2; i++)
                {
                    if ((array[i]==5 && (array[i+1]==5 || array[i+2]==5 )) ||(array[i+1]==5 && array[i+2]==5 ))
                        return true;
                }
            }
            else
                 return array[0]==5 && array[1]==5;
            return false;
        }
        //121. Write a C# Sharp program to check a given array of integers and return true if there is a 3 with a 5 somewhere later in the given array.
        public bool Zad121(IEnumerable<int> collection)
        {
            bool isThree=false;
            foreach (var item in collection)
            {
                if (item==3)
                    isThree=true;
                else if(item==5 && isThree)
                    return true;
            }
            return false;
        }
        //122. Write a C# Sharp program to check a given array of integers and return true if the given array contains either 2 even or 2 odd values all next to each other.
        public bool Zad122(int[] array)
        {
            if (array.Length<2)
                return false;
            else
            {
                for (var i = 0; i < array.Length-1; i++)
                {
                    if ((array[i]%2==0 && array[i+1]%2==0)||(array[i]%2!=0 && array[i+1]%2!=0))
                        return true;
                }
                return false;
            }
        }
        //123. Write a C# Sharp program to check a given array of integers and return true if the value 5 appears 5 times and there are no 5 next to each other.
        public bool Zad123(int[] array)
        {
            int counter =0;
            for (var i = 0; i < array.Length-1; i++)
            {
                if (array[i]==5)
                {
                    if (array[i+1]==5)
                        return false;
                    else
                        counter++;
                }
            }
            counter += array[^1]==5? 1 : 0;
            return counter==5;
        }
        //124. Write a C# Sharp program to check a given array of integers and return true if every 5 that appears in the given array is next to another 5.
        public bool Zad124(int[] array)
        {
            bool fiveHasPair= false;
            for (var i = 0; i < array.Length-1; i++)
            {
                if (array[i]==5 && array[i+1]==5)
                {
                    fiveHasPair= true;
                    i++;
                }
                else if (array[i]==5 && array[i+1]!=5)
                return false;
            }
            if (array[^1]==5)
            {
                fiveHasPair = array[^2]==5;
            }
            return fiveHasPair;
        }
        //125. Write a C# Sharp program to check a given array of integers and return true if the specified number of same elements appears at the start and end of the given array.
        public bool Zad125(int[] array, int length) => array[0..length].SequenceEqual(array[^(length)..]);
        //126. Write a C# Sharp program to check a given array of integers and return true if the array contains three increasing adjacent numbers.
        public bool Zad126(int[] array)
        {
            if (array.Length>=3)
            {
                for (var i = 0; i < array.Length-2; i++)
                {
                    if (array[i]<=array[i+1] && array[i+1]<array[i+2])
                        return true;
                }
            }
                return false;
        }
























    }
}