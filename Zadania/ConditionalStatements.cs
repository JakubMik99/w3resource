namespace Zadania
{
    public class ConditionalStatements
    {
        //1. Write a C# Sharp program to accept two integers and check whether they are equal or not
        public bool Zad1(int firstVal, int secondVal) => firstVal==secondVal;
        //2. Write a C# Sharp program to check whether a given number is even or odd.
        public string Zad2(int value) => value%2==0? "even" : "odd";
        //3. Write a C# Sharp program to check whether a given number is positive or negative.
        public string Zad3(int value) => value<0? "value is negative" : "value is positive";
        //4. Write a C# Sharp program to find whether a given year is a leap year or not.
        public string Zad4(int year) => (year%4==0 || year%400==0) ? "it is a leap year" : "it is not a leap year";
        //5. Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote. 
        public string Zad5(byte age) => age<18? "you are not eligible for casting your vote" : "you are eligible for casting your vote";
        //6. Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
        public int Zad6(int value) => value>0? 1: value<0? -1:0;
        //7. Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.
        public string Zad7(int height) => height <145? "dwarfism" : height>=145 && height<=170? "average height" : height>170 && height <=200? "tall" : "Very tall";
        //8. Write a C# Sharp program to find the largest of three numbers.
        public string Zad8(int firstVal, int secondVal, int thirdVal)
        {
            int max =Math.Max(firstVal,Math.Max(secondVal,thirdVal));

            if (max==firstVal)
                return "First valaue is greatest among three";                
            else if (max==secondVal)
                return "Second valaue is greatest among three";                
            else
                return "Third valaue is greatest among three";                
        }
        //9. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        public string Zad9(int x, int y)
        {
            if(x>0&& y>0)
            return "first";
            else if(x<0&& y>0)
            return "second";
            else if(x<0&& y<0)
            return "third";
            else if(x>0&& y<0)
            return "forth";
            else
            return "somewhere on the axis";
        }
        //10. Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria: Go to the 
        // Marks in Maths >=65
        // Marks in Phy >=55
        // Marks in Chem>=50
        // Total in all three subject >=180
        // or
        // Total in Math and phy >=140 
        public string Zad10(int mathMarks, int phyMarks, int chemMarks)
        {
            int allThree = mathMarks+phyMarks+chemMarks;
            int mathAndPhy= mathMarks+phyMarks;
            if ((allThree>=180 && mathMarks>=65 && phyMarks>=55 && chemMarks>=50) || mathAndPhy>=140)
                return "you are eligible for this course";
            else
                return "you are not eligible for this course";

        }
        //11. Write a C# Sharp program to calculate root of Quadratic Equation.//ax2 + bx + c = 0,
        public string Zad11(int a, int b ,int c)
        {
            int delta=b*b-(4*a*c);
            if(delta==0)
            {
                int x = -b/2*a;
                return $"Miejsce zerowe : {x}";
            }
            else if(delta>0)
            {
                int x1 = (int)((-b+Math.Sqrt(delta))/2*a);
                int x2 = (int)((-b-Math.Sqrt(delta))/2*a);
                return$"Miejsce zerowe1 : {x1} \nMiejsce zerowe2 : {x2}";
            }
            else
                return "brak miejs zerowych";
        }

















    }
}