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
                return "brak miejsc zerowych";
        }
        //12. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
        public string Zad12(int rollNumber, string studentName, int physics, int chemistry, int computerApp)
        {
            int totalMarks = physics+chemistry+computerApp;
            float per = totalMarks/3;
            string div = per>=60? "First" : (per<60 && per>=48? "second" : (per<48&&per>=36 ? "pass" : "fail"));
            string outcome = $"Roll no: {rollNumber}\nName of student: {studentName}\n" +
                             $"Physics: {physics}\nChemistry: {chemistry}\n ComputerApplication {computerApp}\n" +
                             $"Total: {totalMarks} \nPercentage: {per}\n Division: {div}";
            return outcome;
        }
        //13. Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below : Go to the editor
        // Temp < 0 then Freezing weather
        // Temp 0-10 then Very Cold weather
        // Temp 10-20 then Cold weather
        // Temp 20-30 then Normal in Temp
        // Temp 30-40 then Its Hot
        // Temp >=40 then Its Very Hot 
        public string Zad13(int temp)
        {
            string tempState= string.Empty;
            switch (temp)
            {
                case <0:
                tempState = "Its freezing";
                break;
                case >=0 and <10:
                tempState = "Its its very cold";
                break;
                case >=10 and <20:
                tempState = "Its cold";
                break;      
                case >=20 and <30:
                tempState = "Its normal temp";
                break;
                case >=30 and <40:
                tempState = "Its hot";
                break;     
                case >=40:
                tempState = "Its very hot";
                break;
                default:
            }
            return tempState;
        }
        //14. Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
        public string Zad14(int sideA, int sideB, int sideC)
        {
            string typeOfTriangle;
            if(sideA==sideB && sideB==sideC)
                typeOfTriangle ="Equilateral";
            else if((sideA==sideB && sideC!=sideA)||(sideC==sideB && sideC!=sideA)||(sideA==sideC && sideC!=sideB))
                typeOfTriangle = "Isosceles";
            else
                typeOfTriangle = "Scalene";
            return typeOfTriangle;

        }
        //15. Write a C# Sharp program to check whether a triangle can be formed by the given value for the angles.
        public string Zad15(int angleA, int angleB, int angleC) => angleA+angleB+angleC ==180? "triangle is valid" : "triangle is not valid";
        //16. Write a C# Sharp program to check whether an alphabet is a vowel or consonant.
        public string Zad16(char letter) => letter=='a'||letter=='e'||letter=='i'||letter=='o'||letter=='u'||letter=='y'? "vowel" : "consonant";
        //17. Write a C# Sharp program to calculate profit and loss on a transaction.
        public string Zad17(int spending, int income)
        {
            int profit = income-spending;
            if (profit>0)
                return $"Profit equals {profit}";
            else
                return $"Loss equals {profit}";
        }
        //18. Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. 
        public string Zad18(int id, string name, int consumed)
        {
            string bill = string.Empty, perUnit="0";
            float price=0, surchage=0;
            switch (consumed)
            {
                case <200:
                price = consumed*1.2f;
                perUnit="1,2";
                break;
                case >=200 and <400:
                price = consumed*1.5f;
                perUnit="1,5";
                break;
                case >=400 and <600:
                price = consumed*1.8f;
                perUnit="1,8";
                break;
                case >600:
                price = consumed*2f;
                perUnit="2";
                break;
                
                default:
                price = 0;
                break;
            }
            if (price>=400)
                surchage= price*0.15f;  
            
            bill=$"Customer ID: {id}\nCustomer name {name}\nUnits consumed {consumed}\nAmount charges @RS {perUnit} per unit: {price}\n"+
                 $"Surchage Amount: {surchage}\nNet amount {price+surchage}";
            return bill;

        }
        //19. Write a program in C# Sharp to accept a grade and declare the equivalent description :
        public string Zad19(char grade)
        {
            string description = string.Empty;
            switch (grade)
            {
                case 'E':
                    description = "Excellent";
                    break;
                case 'V':
                    description = "Very good";
                    break;
                case 'G':
                    description = "Good";
                    break;
                case 'A':
                    description = "Average";
                    break;
                case 'F':
                    description = "Fail";
                    break;
                default:
                    break;
            }
            return description;
        }
        //20. Write a program in C# Sharp to read any day number in integer and display day name in the word.
        public string Zad20(byte day)
        {
            string nameOfTheDay=string.Empty;
            switch (day)
            {
                case 1:
                nameOfTheDay="Monday";
                    break;
                case 2:
                nameOfTheDay="Tuesday";
                    break;
                case 3:
                nameOfTheDay="Wednesday";
                    break;
                case 4:
                nameOfTheDay="Thursday";
                    break;
                case 5:
                nameOfTheDay="Friday";
                    break;
                case 6:
                nameOfTheDay="Saturday";
                    break;
                case 7:
                nameOfTheDay="Sunday";
                    break;
                
                default:
                break;
            }
            return nameOfTheDay;
        }
        //21. Write a program in C# Sharp to read any digit, display in the word.
        public string Zad21(byte digit)
        {
            string name = string.Empty;
            switch (digit)
            {
                case 0:
                    name="zero";
                    break;
                case 1:
                    name="one";
                    break;
                case 2:
                    name="two";
                    break;
                case 3:
                    name="three";
                    break;
                case 4:
                    name="four";
                    break;
                case 5:
                    name="five";
                    break;
                case 6:
                    name="six";
                    break;
                case 7:
                    name="seven";
                    break;
                case 8:
                    name="eight";
                    break;
                case 9:
                    name="nine";
                    break;                                                                                                                                                                                
                default:
                break;
            }
            return name;
        }
        //22. Write a program in C# Sharp to read any Month Number in integer and display Month name in the word. 
        public string Zad22(byte month)
        {
            string name = string.Empty;
            switch (month)
            {
                case 1:
                    name="January";
                    break;
                case 2:
                    name="February";
                    break;
                case 3:
                    name="March";
                    break;
                case 4:
                    name="April";
                    break;
                case 5:
                    name="May";
                    break;
                case 6:
                    name="June";
                    break;
                case 7:
                    name="July";
                    break;
                case 8:
                    name="August";
                    break;
                case 9:
                    name="September";
                    break;
                case 10:
                    name="October";
                    break;
                case 11:
                    name="November";
                    break;
                case 12:
                    name="December";
                    break;                                                                                                                                                                                                                            
                
                default:
                    break;
            }
            return name;
        }
        //23. Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.
        public int Zad23(byte month)
        {
            int amount=0;
            switch (month)
            {
                case 1:
                    amount=31;
                    break;
                case 2:
                    amount=28;
                    break;
                case 3:
                    amount=31;
                    break;
                case 4:
                    amount=30;
                    break;
                case 5:
                    amount=31;
                    break;
                case 6:
                    amount=30;
                    break;
                case 7:
                    amount=31;
                    break;
                case 8:
                    amount=31;
                    break;
                case 9:
                    amount=30;
                    break;
                case 10:
                    amount=31;
                    break;
                case 11:
                    amount=30;
                    break;
                case 12:
                    amount=31;
                    break;                                                                                                                                                                                                                            
                
                default:
                    break;
            }
            return amount;
        }
        //24. Write a program in C# Sharp which is a Menu-Driven Program to compute the area of the various geometrical shape
        public void Zad24(byte figure)
        {

          DataTypes DT = new DataTypes();   
            switch (figure)
            {
                case 1:
                int sideA = int.Parse(Console.ReadLine());
                Console.WriteLine($"Area of a square = {sideA*sideA}");
                break;
                case 2:
                Console.WriteLine($"First side, then height");
                float triangleSide = float.Parse(Console.ReadLine()), triangleHeight=float.Parse(Console.ReadLine());
                Console.WriteLine($"Area of triangle = {triangleSide*triangleHeight/2}");
                break;
                case 3:
                Console.WriteLine($"input circle radius");
                float radius = float.Parse(Console.ReadLine()), per;                
                Console.WriteLine($"Circle area = {DT.Zad5(radius,out per)}");
                break;
                default:
                break;
            }
        }

        //25. Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation
        /// <summary>
        /// calculation = 1 Addition, 2 substracion, 3 multiplication 4 division
        /// </summary>
        public int Zad26(byte calculation, int firstVal, int secondVal)
        {
            int result;
            switch (calculation)
            {
                case 1:
                    result = firstVal+secondVal;
                break;
                case 2:
                    result = firstVal-secondVal;
                break;
                case 3:
                    result = firstVal*secondVal;
                break;
                case 4:
                    result = firstVal/secondVal;
                break;
                
                default:
                result = 0;
                break;
            }
            return result;
        }















    }
}