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













    }
}